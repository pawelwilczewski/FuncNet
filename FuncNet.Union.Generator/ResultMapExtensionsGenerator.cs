namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

internal static class ResultMapExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionMethodsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MapMethodGenerationParams> CreateAllMethodsGenerationParams(UnionExtensionMethodsFileGenerationParams p) =>
		from asyncConfig in allPossibleAsyncMethodConfigs
		from specialIndex in Enumerable.Range(0, p.UnionSize)
		select new MapMethodGenerationParams(p.MethodNameOnly, p.UnionSize, asyncConfig, specialIndex);

	private static MethodBuilder GenerateMethod(MapMethodGenerationParams p) =>
		p.SpecialIndex == 0 ? GenerateSuccessMap(p) : GenerateErrorMap(p);

	private static MethodBuilder GenerateSuccessMap(MapMethodGenerationParams p)
	{
		var newResult = $"Result<TSuccessNew, {CommaSeparatedTErrors(p.UnionSize - 1)}>";
		var errorTs = CommaSeparatedTErrors(p.UnionSize - 1);

		return new MethodBuilder($"public static {newResult.WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}<TSuccessNew, TSuccessOld, {errorTs}>")
			.AddArgument($"this {$"Result<TSuccessOld, {errorTs}>".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} result")
			.AddArgument($"Func<TSuccessOld, {"TSuccessNew".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> mapping")
			.AddAsyncArgumentsIfNeeded(p)
			.AddBodyStatement($"var u = ({"result".WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}).Value")
			.AddThrowIfCanceledStatementIfNeeded(p)
			.AddBodyStatement($"return {new SwitchExpressionBuilder("u.Index")
				.AddCase(new SwitchCaseText("0", $"{newResult}.FromSuccess(mapping(u.Value0))".WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))))
				.AddCases(GenerateSuccessMapExpressionCases(p))
				.ToString()
				.WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType) && !p.IsAsync(UnionMethodAsyncConfig.ReturnType))}");
	}

	private static MethodBuilder GenerateErrorMap(MapMethodGenerationParams p)
	{
		var errorIndex = p.SpecialIndex - 1;
		var oldErrorTs = CommaSeparatedTErrors(p.UnionSize - 1);
		var newErrorTypeList = ReplaceErrorTypeAtIndex(p.UnionSize - 1, errorIndex);

		return new MethodBuilder($"public static {$"Result<TSuccess, {newErrorTypeList}>".WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}Error{errorIndex}<TSuccess, TErrorNew, {oldErrorTs}>")
			.AddArgument($"this {$"Result<TSuccess, {oldErrorTs}>".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} result")
			.AddArgument($"Func<TError{errorIndex}, {"TErrorNew".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> mapping")
			.AddAsyncArgumentsIfNeeded(p)
			.AddBodyStatement($"var u = ({"result".WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}).Value")
			.AddThrowIfCanceledStatementIfNeeded(p)
			.AddBodyStatement($"return {new SwitchExpressionBuilder("u.Index")
				.AddCases(GenerateErrorMapExpressionCases(p))
				.ToString()
				.WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType) && !p.IsAsync(UnionMethodAsyncConfig.ReturnType))}");
	}

	private static IEnumerable<SwitchCaseText> GenerateSuccessMapExpressionCases(MapMethodGenerationParams p) =>
		Enumerable.Range(1, p.UnionSize - 1)
			.Select(i =>
			{
				var variable = i == p.UnionSize - 1 ? "_" : $"{i}";
				return new SwitchCaseText(
					variable,
					$"Result<TSuccessNew, {CommaSeparatedTErrors(p.UnionSize - 1)}>.FromError(u.Value{i})");
			});

	private static IEnumerable<SwitchCaseText> GenerateErrorMapExpressionCases(MapMethodGenerationParams p)
	{
		var errorIndex = p.SpecialIndex - 1;
		var newErrorTypeList = ReplaceErrorTypeAtIndex(p.UnionSize - 1, errorIndex);
		var isAsync = p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType);

		return new[] { new SwitchCaseText("0", $"Result<TSuccess, {newErrorTypeList}>.FromSuccess(u.Value0)") }
			.Concat(Enumerable.Range(1, p.UnionSize - 1)
				.Select(i =>
				{
					var variable = i == p.UnionSize - 1 ? "_" : $"{i}";
					return i == p.SpecialIndex
						? new SwitchCaseText(variable, $"Result<TSuccess, {newErrorTypeList}>.FromError(mapping(u.Value{i}))".WrapInAwaitConfiguredFromParameterIf(isAsync))
						: new SwitchCaseText(variable, $"Result<TSuccess, {newErrorTypeList}>.FromError(u.Value{i})");
				}));
	}

	private static string ReplaceErrorTypeAtIndex(int count, int index) =>
		string.Join(", ",
			Enumerable.Range(0, count)
				.Select(i => i == index ? "TErrorNew" : $"TError{i}"));
}