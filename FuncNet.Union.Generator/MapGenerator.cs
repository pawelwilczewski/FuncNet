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

	public static string GenerateMapExtensionsFile(string @namespace, int unionSize) =>
		new SourceCodeFileBuilder(Header(@namespace))
			.AddClass(new ClassBuilder($"public static class Union{unionSize}Map")
				.AddMethods(GenerateMapMethods(
					unionSize,
					DontWrap,
					DontWrap,
					DontWrap,
					[],
					DontWrap,
					"",
					@case => new SwitchCaseText(
						@case.Variable,
						GenerateSwitchReturnValue(@case)),
					DontWrap))
				.AddMethods(GenerateMapMethods(
					unionSize,
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
					WrapInAwaitConfiguredFromArgument))
				.AddMethods(GenerateMapMethods(
					unionSize,
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
					WrapInAwaitConfiguredFromArgument))
				.AddMethods(GenerateMapMethods(
					unionSize,
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
					DontWrap))).ToString();

	private static IEnumerable<MethodBuilder> GenerateMapMethods(
		int unionSize,
		WrapText wrapMethodResultType,
		WrapText wrapUnionArgument,
		WrapText wrapBranchResultType,
		IEnumerable<string> additionalArguments,
		WrapText wrapUnionValue,
		string additionalCodeAfterUnionAssignment,
		GenerateSwitchCaseOneSpecial generateSwitchCase,
		WrapText wrapReturnValue) => Enumerable.Range(0, unionSize).Select(mapIndex =>
			new MethodBuilder($"public static {wrapMethodResultType($"Union<{TsNew(unionSize, mapIndex)}>")} Map{mapIndex}<T{mapIndex}New, {TsOld(unionSize, mapIndex)}>")
				.AddArgument($"this {wrapUnionArgument($"Union<{TsOld(unionSize, mapIndex)}>")} union")
				.AddArgument($"Func<T{mapIndex}Old, {wrapBranchResultType($"T{mapIndex}New")}> mapping")
				.AddArguments(additionalArguments)
				.AddBodyStatement($"var u = {wrapUnionValue("union")}")
				.AddBodyStatement(additionalCodeAfterUnionAssignment)
				.AddBodyStatement($@"return {wrapReturnValue(GenerateSwitchExpression(
					"u.Index", GenerateSwitchExpressionCases(unionSize, mapIndex, generateSwitchCase)))}"));

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
}