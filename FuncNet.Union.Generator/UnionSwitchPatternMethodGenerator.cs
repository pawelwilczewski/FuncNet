namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

internal static class UnionSwitchPatternMethodGenerator
{
	public static string GenerateExtensionsFile(string @namespace, MethodGroupGenerationParams p) =>
		new SourceCodeFileBuilder(Header(@namespace))
			.AddClass(new ClassBuilder($"public static class Union{p.UnionSize}{p.MethodNameOnly}")
				.AddMethods(CreateAllMethodsGenerationParams(p).Select(GenerateMethod)))
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

	private static IEnumerable<SingleMethodGenerationParams> CreateAllMethodsGenerationParams(MethodGroupGenerationParams p) =>
		from asyncConfig in allPossibleAsyncConfigs
		from specialIndex in Enumerable.Range(0, p.UnionSize)
		select new SingleMethodGenerationParams(p, asyncConfig, specialIndex);

	private static MethodBuilder GenerateMethod(SingleMethodGenerationParams p) =>
		new MethodBuilder($"public static {$"{UnionOfTsOneNew(p.UnionSize, p.SpecialIndex)}".WrapInAsyncTaskIf(p.IsAsync(MethodAsyncConfig.ReturnType))} {p.MethodNameOnly}{p.SpecialIndex}<T{p.SpecialIndex}New, {TsOld(p.UnionSize, p.SpecialIndex)}>")
			.AddArgument($"this {$"{UnionOfTsOneOld(p.UnionSize, p.SpecialIndex)}".WrapInTaskIf(p.IsAsync(MethodAsyncConfig.InputUnion))} union")
			.AddArgument($"Func<T{p.SpecialIndex}Old, {p.AppliedMethodReturnType(p.SpecialIndex).WrapInTaskIf(p.IsAsync(MethodAsyncConfig.AppliedMethodReturnType))}> {p.AppliedMethodParameterName}")
			.AddArguments(p.IsAsync(MethodAsyncConfig.ReturnType) ? asyncMethodAdditionalArguments : [])
			.AddBodyStatement($"var u = {"union".WrapInAwaitConfiguredFromParameterIf(p.IsAsync(MethodAsyncConfig.InputUnion))}")
			.AddBodyStatement(p.IsAsync(MethodAsyncConfig.ReturnType) ? THROW_IF_CANCELED : "")
			.AddBodyStatement($@"return {GenerateSwitchExpression(
				"u.Index", GenerateSwitchExpressionCases(p)).WrapInAwaitConfiguredFromParameterIf(p.IsAsync(MethodAsyncConfig.AppliedMethodReturnType))}");

	private static IEnumerable<SwitchCaseText> GenerateSwitchExpressionCases(
		SingleMethodGenerationParams p) =>
		Enumerable.Range(0, p.UnionSize)
			.Select(i =>
			{
				var variable = i == p.UnionSize - 1 ? "_" : $"{i}";
				return new SwitchCaseText(
					variable,
					GenerateSwitchCaseReturnValue(new SwitchCaseOneSpecial(i, variable, p.SpecialIndex), p));
			});

	private static string GenerateSwitchCaseReturnValue(SwitchCaseOneSpecial @case, SingleMethodGenerationParams p) =>
		(@case.Index == p.SpecialIndex
			? $"{p.AppliedMethodParameterName}(u.Value{@case.Index})"
			: $"u.Value{@case.Index}")
		.WrapInTaskFromResultIf(@case.Index != p.SpecialIndex && p.IsAsync(MethodAsyncConfig.AppliedMethodReturnType))
		.WrapInNewUnionFromTAccordingly(@case, p);

	private static string WrapInNewUnionFromTAccordingly(
		this string value, SwitchCaseOneSpecial @case, SingleMethodGenerationParams p) =>
		p.AppliedMethodParameterName.Contains("bind", StringComparison.OrdinalIgnoreCase) // TODO Pawel: bad design to rely on "bind" but seems fine for now
			? value.WrapInNewUnionFromTIfNotSpecial(@case, p.UnionSize)
			: value.WrapInNewUnionFromT(@case, p.UnionSize);

	public sealed record class MethodGroupGenerationParams(
		string MethodNameOnly,
		int UnionSize,
		GenerateAppliedMethodReturnType AppliedMethodReturnType,
		string AppliedMethodParameterName);

	private sealed record class SingleMethodGenerationParams(
		MethodGroupGenerationParams Params,
		MethodAsyncConfig MethodAsyncConfig,
		int SpecialIndex)
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