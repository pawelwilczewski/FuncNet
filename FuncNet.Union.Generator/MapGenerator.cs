namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

// TODO Pawel: logic is largely shared between Map and Bind - create an appropriate abstraction (this should use switch expression instead of Match)
public static class MapGenerator
{
	private static string Header(string @namespace) => $@"
using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace {@namespace};";

	private static MapMethodGenerationParams[] Params(int unionSize) =>
	[
		new(unionSize,
			DontWrap,
			DontWrap,
			DontWrap,
			[],
			DontWrap,
			"",
			@case => new SwitchCaseText(
				@case.Variable,
				GenerateSwitchReturnValue(@case)),
			DontWrap),
		new(unionSize,
			WrapInAsyncTask,
			WrapInTask,
			WrapInTask,
			asyncMethodAdditionalArguments,
			WrapInAwaitConfiguredFromArgument,
			THROW_IF_CANCELED,
			@case => new SwitchCaseText(
				@case.Variable,
				GenerateSwitchReturnValue(@case)
					.WrapInTaskFromResultIfNotSpecial(@case)
					.WrapInNewUnionFromT(@case, unionSize)),
			WrapInAwaitConfiguredFromArgument),
		new(unionSize,
			WrapInAsyncTask,
			DontWrap,
			WrapInTask,
			asyncMethodAdditionalArguments,
			DontWrap,
			THROW_IF_CANCELED,
			@case => new SwitchCaseText(
				@case.Variable,
				GenerateSwitchReturnValue(@case)
					.WrapInTaskFromResultIfNotSpecial(@case)
					.WrapInNewUnionFromT(@case, unionSize)),
			WrapInAwaitConfiguredFromArgument),
		new(unionSize,
			WrapInAsyncTask,
			WrapInTask,
			DontWrap,
			asyncMethodAdditionalArguments,
			WrapInAwaitConfiguredFromArgument,
			THROW_IF_CANCELED,
			@case => new SwitchCaseText(
				@case.Variable,
				GenerateSwitchReturnValue(@case)
					.WrapInNewUnionFromTIfNotSpecial(@case, unionSize)),
			DontWrap)
	];

	public static string GenerateMapExtensionsFile(string @namespace, int unionSize) =>
		new SourceCodeFileBuilder(Header(@namespace))
			.AddClass(new ClassBuilder($"public static class Union{unionSize}Map")
				.AddMethods(Params(unionSize).SelectMany(GenerateMapMethods)))
			.ToString();

	private static IEnumerable<MethodBuilder> GenerateMapMethods(MapMethodGenerationParams p) =>
		Enumerable.Range(0, p.UnionSize).Select(mapIndex =>
			new MethodBuilder($"public static {p.WrapMethodResultType($"Union<{TsNew(p.UnionSize, mapIndex)}>")} Map{mapIndex}<T{mapIndex}New, {TsOld(p.UnionSize, mapIndex)}>")
				.AddArgument($"this {p.WrapUnionArgument($"Union<{TsOld(p.UnionSize, mapIndex)}>")} union")
				.AddArgument($"Func<T{mapIndex}Old, {p.WrapBranchResultType($"T{mapIndex}New")}> mapping")
				.AddArguments(p.AdditionalArguments)
				.AddBodyStatement($"var u = {p.WrapUnionValue("union")}")
				.AddBodyStatement(p.AdditionalCodeAfterUnionAssignment)
				.AddBodyStatement($@"return {p.WrapReturnValue(GenerateSwitchExpression(
					"u.Index", GenerateSwitchExpressionCases(p.UnionSize, mapIndex, p.GenerateSwitchCase)))}"));

	private static IEnumerable<SwitchCaseText> GenerateSwitchExpressionCases(
		int unionSize, int specialIndex,
		GenerateSwitchCaseOneSpecial generateCase) =>
		Enumerable.Range(0, unionSize)
			.Select(i =>
			{
				var variable = i == unionSize - 1 ? "_" : $"{i}";
				return generateCase(new SwitchCaseOneSpecial(i, variable, specialIndex));
			});

	private static string GenerateSwitchReturnValue(SwitchCaseOneSpecial @case) =>
		@case.Index == @case.SpecialIndex
			? $"mapping(u.Value{@case.Index})"
			: $"u.Value{@case.Index}";

	private sealed record class MapMethodGenerationParams(
		int UnionSize,
		WrapText WrapMethodResultType,
		WrapText WrapUnionArgument,
		WrapText WrapBranchResultType,
		IEnumerable<string> AdditionalArguments,
		WrapText WrapUnionValue,
		string AdditionalCodeAfterUnionAssignment,
		GenerateSwitchCaseOneSpecial GenerateSwitchCase,
		WrapText WrapReturnValue);
}