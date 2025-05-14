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

	private static readonly MethodAsyncConfig[] allPossibleAsyncConfigs =
	[
		MethodAsyncConfig.None,
		MethodAsyncConfig.All,
		MethodAsyncConfig.ReturnType | MethodAsyncConfig.AppliedMethodReturnType,
		MethodAsyncConfig.ReturnType | MethodAsyncConfig.InputUnion
	];

	public static IEnumerable<MethodGenerationParams> CreateMethodGenerationParams(
		string methodNameOnly,
		int unionSize,
		GenerateAppliedMethodReturnType generateAppliedMethodReturnType,
		string appliedMethodParameterName) =>
		allPossibleAsyncConfigs
			.Select(asyncConfig => new MethodGenerationParams(
				methodNameOnly, unionSize, generateAppliedMethodReturnType, appliedMethodParameterName, asyncConfig));

	public static IEnumerable<MethodBuilder> GenerateMethods(MethodGenerationParams p) =>
		Enumerable.Range(0, p.UnionSize).Select(mapIndex =>
			new MethodBuilder($"public static {$"Union<{TsNew(p.UnionSize, mapIndex)}>".WrapInAsyncTaskIf(p.IsAsync(MethodAsyncConfig.ReturnType))} {p.MethodNameOnly}{mapIndex}<T{mapIndex}New, {TsOld(p.UnionSize, mapIndex)}>")
				.AddArgument($"this {$"Union<{TsOld(p.UnionSize, mapIndex)}>".WrapInTaskIf(p.IsAsync(MethodAsyncConfig.InputUnion))} union")
				.AddArgument($"Func<T{mapIndex}Old, {p.AppliedMethodReturnType(mapIndex).WrapInTaskIf(p.IsAsync(MethodAsyncConfig.AppliedMethodReturnType))}> {p.AppliedMethodParameterName}")
				.AddArguments(p.IsAsync(MethodAsyncConfig.ReturnType) ? asyncMethodAdditionalArguments : [])
				.AddBodyStatement($"var u = {"union".WrapInAwaitConfiguredFromParameterIf(p.IsAsync(MethodAsyncConfig.InputUnion))}")
				.AddBodyStatement(p.IsAsync(MethodAsyncConfig.ReturnType) ? THROW_IF_CANCELED : "")
				.AddBodyStatement($@"return {GenerateSwitchExpression(
					"u.Index", GenerateSwitchExpressionCases(p, mapIndex)).WrapInAwaitConfiguredFromParameterIf(p.IsAsync(MethodAsyncConfig.AppliedMethodReturnType))}"));

	private static IEnumerable<SwitchCaseText> GenerateSwitchExpressionCases(
		MethodGenerationParams p, int specialIndex) =>
		Enumerable.Range(0, p.UnionSize)
			.Select(i =>
			{
				var variable = i == p.UnionSize - 1 ? "_" : $"{i}";
				return new SwitchCaseText(
					variable,
					GenerateSwitchCaseReturnValue(new SwitchCaseOneSpecial(i, variable, specialIndex), p));
			});

	private static string GenerateSwitchCaseReturnValue(SwitchCaseOneSpecial @case, MethodGenerationParams p) =>
		(@case.Index == @case.SpecialIndex
			? $"{p.AppliedMethodParameterName}(u.Value{@case.Index})"
			: $"u.Value{@case.Index}")
		.WrapInTaskFromResultIf(@case.Index != @case.SpecialIndex && p.IsAsync(MethodAsyncConfig.AppliedMethodReturnType))
		.WrapInNewUnionFromTAccordingly(@case, p);

	private static string WrapInNewUnionFromTAccordingly(
		this string value, SwitchCaseOneSpecial @case, MethodGenerationParams p) =>
		p.AppliedMethodParameterName.Contains("bind", StringComparison.OrdinalIgnoreCase)
			? value.WrapInNewUnionFromTIfNotSpecial(@case, p.UnionSize)
			: value.WrapInNewUnionFromT(@case, p.UnionSize);

	public sealed record class MethodGenerationParams(
		string MethodNameOnly,
		int UnionSize,
		GenerateAppliedMethodReturnType AppliedMethodReturnType,
		string AppliedMethodParameterName,
		MethodAsyncConfig MethodAsyncConfig)
	{
		public bool IsAsync(MethodAsyncConfig asyncConfig) => (asyncConfig & MethodAsyncConfig) != 0;
	}

	public delegate string GenerateAppliedMethodReturnType(int specialIndex);

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