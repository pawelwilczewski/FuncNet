namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

internal sealed record class ResultBindMethodGenerationParams(
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig) : MethodGenerationParams(MethodNameOnly, UnionSize, AsyncConfig);

internal static class ResultBindExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionMethodsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<ResultBindMethodGenerationParams> CreateAllMethodsGenerationParams(UnionExtensionMethodsFileGenerationParams p) =>
		from asyncConfig in allPossibleAsyncMethodConfigs
		select new ResultBindMethodGenerationParams(p.MethodNameOnly, p.UnionSize, asyncConfig);

	private static MethodBuilder GenerateMethod(ResultBindMethodGenerationParams p)
	{
		var newResult = $"Result<TSuccessNew, {CommaSeparatedTErrors(p.UnionSize - 1)}>";
		var errorTs = CommaSeparatedTErrors(p.UnionSize - 1);

		return new MethodBuilder($"public static {newResult.WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}<TSuccessNew, TSuccessOld, {errorTs}>")
			.AddArgument($"this {$"Result<TSuccessOld, {errorTs}>".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} result")
			.AddArgument($"Func<TSuccessOld, {newResult.WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> binding")
			.AddAsyncArgumentsIfNeeded(p)
			.AddBodyStatement($"var u = ({"result".WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}).Value")
			.AddThrowIfCanceledStatementIfNeeded(p)
			.AddBodyStatement($"return {new SwitchExpressionBuilder("u.Index")
				.AddCase(new SwitchCaseText("0", "binding(u.Value0)"))
				.AddCases(GenerateSwitchExpressionCases(p))
				.ToString()
				.WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}");
	}

	private static IEnumerable<SwitchCaseText> GenerateSwitchExpressionCases(ResultBindMethodGenerationParams p) =>
		Enumerable.Range(1, p.UnionSize - 1)
			.Select(i =>
			{
				var variable = i == p.UnionSize - 1 ? "_" : $"{i}";
				return new SwitchCaseText(
					variable,
					$"Result<TSuccessNew, {CommaSeparatedTErrors(p.UnionSize - 1)}>.FromError(u.Value{i})".WrapInTaskFromResultIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType)));
			});
}