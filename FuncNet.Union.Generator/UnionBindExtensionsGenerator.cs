namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

internal sealed record class BindMethodGenerationParams(
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig,
	int SpecialIndex) : MethodGenerationParams(MethodNameOnly, UnionSize, AsyncConfig);

internal static class UnionBindExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionMethodsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<BindMethodGenerationParams> CreateAllMethodsGenerationParams(UnionExtensionMethodsFileGenerationParams p) =>
		from asyncConfig in allPossibleAsyncMethodConfigs
		from specialIndex in Enumerable.Range(0, p.UnionSize)
		select new BindMethodGenerationParams(p.MethodNameOnly, p.UnionSize, asyncConfig, specialIndex);

	private static MethodBuilder GenerateMethod(BindMethodGenerationParams p) =>
		new MethodBuilder($"public static {UnionOfTsOneNew(p.UnionSize, p.SpecialIndex).WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}{p.SpecialIndex}<T{p.SpecialIndex}New, {TsOld(p.UnionSize, p.SpecialIndex)}>")
			.AddArgument($"this {UnionOfTsOneOld(p.UnionSize, p.SpecialIndex).WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} union")
			.AddArgument($"Func<T{p.SpecialIndex}Old, {UnionOfTsOneNew(p.UnionSize, p.SpecialIndex).WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> binding")
			.AddAsyncArgumentsIfNeeded(p)
			.AddBodyStatement($"var u = {"union".WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}")
			.AddThrowIfCanceledStatementIfNeeded(p)
			.AddBodyStatement($"return {new SwitchExpressionBuilder("u.Index")
				.AddCases(GenerateSwitchExpressionCases(p))
				.ToString()
				.WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}");

	private static IEnumerable<SwitchCaseText> GenerateSwitchExpressionCases(BindMethodGenerationParams p) =>
		Enumerable.Range(0, p.UnionSize)
			.Select(i =>
			{
				var variable = i == p.UnionSize - 1 ? "_" : $"{i}";
				return new SwitchCaseText(
					variable,
					GenerateSwitchCaseReturnValue(new SwitchCaseOneSpecial(i, variable, p.SpecialIndex), p));
			});

	private static string GenerateSwitchCaseReturnValue(SwitchCaseOneSpecial @case, BindMethodGenerationParams p) =>
		(@case.Index == p.SpecialIndex ? $"binding(u.Value{@case.Index})" : $"u.Value{@case.Index}")
		.WrapInTaskFromResultIf(@case.Index != p.SpecialIndex && p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))
		.WrapInNewUnionFromTIfNotSpecial(@case, p.UnionSize);
}