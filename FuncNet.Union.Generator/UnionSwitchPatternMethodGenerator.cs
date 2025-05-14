namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

internal static class UnionSwitchPatternMethodGenerator
{
	public static string GenerateExtensionsFile(string @namespace, MethodGroupGenerationParams p) =>
		new SourceCodeFileBuilder(Header(@namespace))
			.AddClass(new ClassBuilder($"public static class Union{p.UnionSize}{p.MethodNameOnly}")
				.AddMethods(CreateMethodGenerationParams(p).SelectMany(GenerateMethods)))
			.ToString();

	private static string Header(string @namespace) =>
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

	private static IEnumerable<SingleMethodGenerationParams> CreateMethodGenerationParams(MethodGroupGenerationParams p) =>
		allPossibleAsyncConfigs
			.Select(asyncConfig => new SingleMethodGenerationParams(p, asyncConfig));

	private static IEnumerable<MethodBuilder> GenerateMethods(SingleMethodGenerationParams p) =>
		Enumerable.Range(0, p.UnionSize).Select(specialIndex =>
			new MethodBuilder($"public static {$"Union<{TsNew(p.UnionSize, specialIndex)}>".WrapInAsyncTaskIf(p.IsAsync(MethodAsyncConfig.ReturnType))} {p.MethodNameOnly}{specialIndex}<T{specialIndex}New, {TsOld(p.UnionSize, specialIndex)}>")
				.AddArgument($"this {$"Union<{TsOld(p.UnionSize, specialIndex)}>".WrapInTaskIf(p.IsAsync(MethodAsyncConfig.InputUnion))} union")
				.AddArgument($"Func<T{specialIndex}Old, {p.AppliedMethodReturnType(specialIndex).WrapInTaskIf(p.IsAsync(MethodAsyncConfig.AppliedMethodReturnType))}> {p.AppliedMethodParameterName}")
				.AddArguments(p.IsAsync(MethodAsyncConfig.ReturnType) ? asyncMethodAdditionalArguments : [])
				.AddBodyStatement($"var u = {"union".WrapInAwaitConfiguredFromParameterIf(p.IsAsync(MethodAsyncConfig.InputUnion))}")
				.AddBodyStatement(p.IsAsync(MethodAsyncConfig.ReturnType) ? THROW_IF_CANCELED : "")
				.AddBodyStatement($@"return {GenerateSwitchExpression(
					"u.Index", GenerateSwitchExpressionCases(p, specialIndex)).WrapInAwaitConfiguredFromParameterIf(p.IsAsync(MethodAsyncConfig.AppliedMethodReturnType))}"));

	private static IEnumerable<SwitchCaseText> GenerateSwitchExpressionCases(
		SingleMethodGenerationParams p, int specialIndex) =>
		Enumerable.Range(0, p.UnionSize)
			.Select(i =>
			{
				var variable = i == p.UnionSize - 1 ? "_" : $"{i}";
				return new SwitchCaseText(
					variable,
					GenerateSwitchCaseReturnValue(new SwitchCaseOneSpecial(i, variable, specialIndex), p));
			});

	private static string GenerateSwitchCaseReturnValue(SwitchCaseOneSpecial @case, SingleMethodGenerationParams p) =>
		(@case.Index == @case.SpecialIndex
			? $"{p.AppliedMethodParameterName}(u.Value{@case.Index})"
			: $"u.Value{@case.Index}")
		.WrapInTaskFromResultIf(@case.Index != @case.SpecialIndex && p.IsAsync(MethodAsyncConfig.AppliedMethodReturnType))
		.WrapInNewUnionFromTAccordingly(@case, p);

	private static string WrapInNewUnionFromTAccordingly(
		this string value, SwitchCaseOneSpecial @case, SingleMethodGenerationParams p) =>
		p.AppliedMethodParameterName.Contains("bind", StringComparison.OrdinalIgnoreCase)
			? value.WrapInNewUnionFromTIfNotSpecial(@case, p.UnionSize)
			: value.WrapInNewUnionFromT(@case, p.UnionSize);

	public sealed record class MethodGroupGenerationParams(
		string MethodNameOnly,
		int UnionSize,
		GenerateAppliedMethodReturnType AppliedMethodReturnType,
		string AppliedMethodParameterName);

	private sealed record class SingleMethodGenerationParams(
		MethodGroupGenerationParams Params,
		MethodAsyncConfig MethodAsyncConfig)
	{
		public string MethodNameOnly => Params.MethodNameOnly;
		public int UnionSize => Params.UnionSize;
		public GenerateAppliedMethodReturnType AppliedMethodReturnType => Params.AppliedMethodReturnType;
		public string AppliedMethodParameterName => Params.AppliedMethodParameterName;
		
		public bool IsAsync(MethodAsyncConfig asyncConfig) => (asyncConfig & MethodAsyncConfig) != 0;
	}

	public delegate string GenerateAppliedMethodReturnType(int index);

	[Flags]
	private enum MethodAsyncConfig
	{
		None = 0,
		All = ~0,
		ReturnType = 1 << 0,
		InputUnion = 1 << 1,
		AppliedMethodReturnType = 1 << 2,
	}
}