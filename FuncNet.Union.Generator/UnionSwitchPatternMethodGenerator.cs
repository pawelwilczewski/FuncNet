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
		GenerateAppliedMethodReturnType generateAppliedMethodReturnType,
		string appliedMethodArgumentName) =>
	[
		new(methodNameOnly,
			unionSize,
			MethodAsyncConfig.None,
			generateAppliedMethodReturnType,
			appliedMethodArgumentName,
			[],
			"",
			@case => new SwitchCaseText(
				@case.Variable,
				GenerateSwitchReturnValue(@case, appliedMethodArgumentName))),
		new(methodNameOnly,
			unionSize,
			MethodAsyncConfig.All,
			generateAppliedMethodReturnType,
			appliedMethodArgumentName,
			asyncMethodAdditionalArguments,
			THROW_IF_CANCELED,
			@case => new SwitchCaseText(
				@case.Variable,
				GenerateSwitchReturnValue(@case, appliedMethodArgumentName)
					.WrapInTaskFromResultIfNotSpecial(@case)
					.WrapInNewUnionFromTIfNotBinding(@case, unionSize, appliedMethodArgumentName))),
		new(methodNameOnly,
			unionSize,
			MethodAsyncConfig.ReturnType | MethodAsyncConfig.AppliedMethodReturnType,
			generateAppliedMethodReturnType,
			appliedMethodArgumentName,
			asyncMethodAdditionalArguments,
			THROW_IF_CANCELED,
			@case => new SwitchCaseText(
				@case.Variable,
				GenerateSwitchReturnValue(@case, appliedMethodArgumentName)
					.WrapInTaskFromResultIfNotSpecial(@case)
					.WrapInNewUnionFromTIfNotBinding(@case, unionSize, appliedMethodArgumentName))),
		new(methodNameOnly,
			unionSize,
			MethodAsyncConfig.ReturnType | MethodAsyncConfig.InputUnion,
			generateAppliedMethodReturnType,
			appliedMethodArgumentName,
			asyncMethodAdditionalArguments,
			THROW_IF_CANCELED,
			@case => new SwitchCaseText(
				@case.Variable,
				GenerateSwitchReturnValue(@case, appliedMethodArgumentName)
					.WrapInNewUnionFromTIfNotSpecial(@case, unionSize)))
	];
	
	public static IEnumerable<MethodBuilder> GenerateMethods(MethodGenerationParams p) =>
		Enumerable.Range(0, p.UnionSize).Select(mapIndex =>
			new MethodBuilder($"public static {$"Union<{TsNew(p.UnionSize, mapIndex)}>".WrapInAsyncTaskIf(p.IsAsync(MethodAsyncConfig.ReturnType))} {p.MethodNameOnly}{mapIndex}<T{mapIndex}New, {TsOld(p.UnionSize, mapIndex)}>")
				.AddArgument($"this {$"Union<{TsOld(p.UnionSize, mapIndex)}>".WrapInTaskIf(p.IsAsync(MethodAsyncConfig.InputUnion))} union")
				.AddArgument($"Func<T{mapIndex}Old, {p.AppliedMethodReturnType(mapIndex).WrapInTaskIf(p.IsAsync(MethodAsyncConfig.AppliedMethodReturnType))}> {p.AppliedMethodArgumentName}")
				.AddArguments(p.AdditionalArguments)
				.AddBodyStatement($"var u = {"union".WrapInAwaitConfiguredFromParameterIf(p.IsAsync(MethodAsyncConfig.InputUnion))}")
				.AddBodyStatement(p.AdditionalCodeAfterUnionAssignment)
				.AddBodyStatement($@"return {GenerateSwitchExpression(
					"u.Index", GenerateSwitchExpressionCases(p.UnionSize, mapIndex, p.GenerateSwitchCase)).WrapInAwaitConfiguredFromParameterIf(p.IsAsync(MethodAsyncConfig.AppliedMethodReturnType))}"));

	private static IEnumerable<SwitchCaseText> GenerateSwitchExpressionCases(
		int unionSize, int specialIndex,
		GenerateSwitchCaseOneSpecial generateCase) =>
		Enumerable.Range(0, unionSize)
			.Select(i =>
			{
				var variable = i == unionSize - 1 ? "_" : $"{i}";
				return generateCase(new SwitchCaseOneSpecial(i, variable, specialIndex));
			});

	private static string GenerateSwitchReturnValue(SwitchCaseOneSpecial @case, string appliedMethodArgumentName) =>
		@case.Index == @case.SpecialIndex
			? $"{appliedMethodArgumentName}(u.Value{@case.Index})"
			: $"u.Value{@case.Index}";

	private static string WrapInNewUnionFromTIfNotBinding(
		this string value, SwitchCaseOneSpecial @case, int unionSize, string appliedMethodName) =>
		appliedMethodName.Contains("bind", StringComparison.OrdinalIgnoreCase)
			? value.WrapInNewUnionFromTIfNotSpecial(@case, unionSize)
			: value.WrapInNewUnionFromT(@case, unionSize);

	public sealed record class MethodGenerationParams(
		string MethodNameOnly,
		int UnionSize,
		MethodAsyncConfig MethodAsyncConfig,
		GenerateAppliedMethodReturnType AppliedMethodReturnType,
		string AppliedMethodArgumentName,
		IEnumerable<string> AdditionalArguments,
		string AdditionalCodeAfterUnionAssignment,
		GenerateSwitchCaseOneSpecial GenerateSwitchCase)
	{
		public bool IsAsync(MethodAsyncConfig asyncConfig) => (asyncConfig & MethodAsyncConfig) != 0;
	}

	public delegate string GenerateAppliedMethodReturnType(int index);

	[Flags]
	public enum MethodAsyncConfig
	{
		None = 0,
		All = ~0,
		ReturnType = 1 << 0,
		InputUnion = 1 << 1,
		AppliedMethodReturnType = 1 << 2,
	}
}