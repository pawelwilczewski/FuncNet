namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

internal static class UnionSwitchPatternMethodGenerator
{
	public static string Header(string @namespace) =>
$@"using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace {@namespace};";

	public static MethodGenerationParams[] Params(
		string methodNameOnly,
		int unionSize,
		GenerateFuncReturnType generateFuncReturnType,
		string funcArgumentName) =>
	[
		new(methodNameOnly,
			unionSize,
			DontWrap,
			DontWrap,
			DontWrap,
			generateFuncReturnType,
			funcArgumentName,
			[],
			DontWrap,
			"",
			@case => new SwitchCaseText(
				@case.Variable,
				GenerateSwitchReturnValue(@case, funcArgumentName)),
			DontWrap),
		new(methodNameOnly,
			unionSize,
			WrapInAsyncTask,
			WrapInTask,
			WrapInTask,
			generateFuncReturnType,
			funcArgumentName,
			asyncMethodAdditionalArguments,
			WrapInAwaitConfiguredFromArgument,
			THROW_IF_CANCELED,
			@case => new SwitchCaseText(
				@case.Variable,
				GenerateSwitchReturnValue(@case, funcArgumentName)
					.WrapInTaskFromResultIfNotSpecial(@case)
					.WrapInNewUnionFromTIfNotBinding(@case, unionSize, funcArgumentName)),
			WrapInAwaitConfiguredFromArgument),
		new(methodNameOnly,
			unionSize,
			WrapInAsyncTask,
			DontWrap,
			WrapInTask,
			generateFuncReturnType,
			funcArgumentName,
			asyncMethodAdditionalArguments,
			DontWrap,
			THROW_IF_CANCELED,
			@case => new SwitchCaseText(
				@case.Variable,
				GenerateSwitchReturnValue(@case, funcArgumentName)
					.WrapInTaskFromResultIfNotSpecial(@case)
					.WrapInNewUnionFromTIfNotBinding(@case, unionSize, funcArgumentName)),
			WrapInAwaitConfiguredFromArgument),
		new(methodNameOnly,
			unionSize,
			WrapInAsyncTask,
			WrapInTask,
			DontWrap,
			generateFuncReturnType,
			funcArgumentName,
			asyncMethodAdditionalArguments,
			WrapInAwaitConfiguredFromArgument,
			THROW_IF_CANCELED,
			@case => new SwitchCaseText(
				@case.Variable,
				GenerateSwitchReturnValue(@case, funcArgumentName)
					.WrapInNewUnionFromTIfNotSpecial(@case, unionSize)),
			DontWrap)
	];
	
	public static IEnumerable<MethodBuilder> GenerateMethods(MethodGenerationParams p) =>
		Enumerable.Range(0, p.UnionSize).Select(mapIndex =>
			new MethodBuilder($"public static {p.WrapMethodResultType($"Union<{TsNew(p.UnionSize, mapIndex)}>")} {p.MethodNameOnly}{mapIndex}<T{mapIndex}New, {TsOld(p.UnionSize, mapIndex)}>")
				.AddArgument($"this {p.WrapUnionArgument($"Union<{TsOld(p.UnionSize, mapIndex)}>")} union")
				.AddArgument($"Func<T{mapIndex}Old, {p.WrapBranchResultType(p.FuncReturnType(mapIndex))}> {p.FuncArgumentName}")
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

	private static string GenerateSwitchReturnValue(SwitchCaseOneSpecial @case, string funcArgumentName) =>
		@case.Index == @case.SpecialIndex
			? $"{funcArgumentName}(u.Value{@case.Index})"
			: $"u.Value{@case.Index}";

	private static string WrapInNewUnionFromTIfNotBinding(
		this string value, SwitchCaseOneSpecial @case, int unionSize, string appliedMethodName) =>
		appliedMethodName.Contains("bind", StringComparison.OrdinalIgnoreCase)
			? value.WrapInNewUnionFromTIfNotSpecial(@case, unionSize)
			: value.WrapInNewUnionFromT(@case, unionSize);

	public sealed record class MethodGenerationParams(
		string MethodNameOnly,
		int UnionSize,
		WrapText WrapMethodResultType,
		WrapText WrapUnionArgument,
		WrapText WrapBranchResultType,
		GenerateFuncReturnType FuncReturnType,
		string FuncArgumentName,
		IEnumerable<string> AdditionalArguments,
		WrapText WrapUnionValue,
		string AdditionalCodeAfterUnionAssignment,
		GenerateSwitchCaseOneSpecial GenerateSwitchCase,
		WrapText WrapReturnValue);

	public delegate string GenerateFuncReturnType(int index);
}