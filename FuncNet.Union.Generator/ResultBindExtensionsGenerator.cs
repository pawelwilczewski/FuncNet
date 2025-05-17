namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

internal static class ResultBindExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionMethodsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<BindMethodGenerationParams> CreateAllMethodsGenerationParams(UnionExtensionMethodsFileGenerationParams p) =>
		from asyncConfig in allPossibleAsyncMethodConfigs
		from specialIndex in Enumerable.Range(0, p.UnionSize)
		select new BindMethodGenerationParams(p.MethodNameOnly, p.UnionSize, asyncConfig, specialIndex);

	private static MethodBuilder GenerateMethod(BindMethodGenerationParams p) =>
		p.SpecialIndex == 0 ? GenerateSuccessBind(p) : GenerateErrorBind(p);

	private static MethodBuilder GenerateSuccessBind(BindMethodGenerationParams p)
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
				.AddCases(GenerateSuccessBindExpressionCases(p))
				.ToString()
				.WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}");
	}

	private static MethodBuilder GenerateErrorBind(BindMethodGenerationParams p)
	{
		var errorIndex = p.SpecialIndex - 1;
		var oldErrorTs = CommaSeparatedTErrors(p.UnionSize - 1);
		var newErrorTypeList = ReplaceErrorTypeAtIndex(p.UnionSize - 1, errorIndex);

		return new MethodBuilder($"public static {$"Result<TSuccess, {newErrorTypeList}>".WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}Error{errorIndex}<TSuccess, TErrorNew, {oldErrorTs}>")
			.AddArgument($"this {$"Result<TSuccess, {oldErrorTs}>".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} result")
			.AddArgument($"Func<TError{errorIndex}, {$"Result<TSuccess, {newErrorTypeList}>".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> binding")
			.AddAsyncArgumentsIfNeeded(p)
			.AddBodyStatement($"var u = ({"result".WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}).Value")
			.AddThrowIfCanceledStatementIfNeeded(p)
			.AddBodyStatement($"return {new SwitchExpressionBuilder("u.Index")
				.AddCases(GenerateErrorBindExpressionCases(p))
				.ToString()
				.WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}");
	}

	private static IEnumerable<SwitchCaseText> GenerateSuccessBindExpressionCases(BindMethodGenerationParams p) =>
		Enumerable.Range(1, p.UnionSize - 1)
			.Select(i =>
			{
				var variable = i == p.UnionSize - 1 ? "_" : $"{i}";
				return new SwitchCaseText(
					variable,
					$"Result<TSuccessNew, {CommaSeparatedTErrors(p.UnionSize - 1)}>.FromError(u.Value{i})".WrapInTaskFromResultIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType)));
			});

	private static IEnumerable<SwitchCaseText> GenerateErrorBindExpressionCases(BindMethodGenerationParams p)
	{
		var errorIndex = p.SpecialIndex - 1;
		var newErrorTypeList = ReplaceErrorTypeAtIndex(p.UnionSize - 1, errorIndex);
		var isAsync = p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType);

		return new[] { new SwitchCaseText("0", $"Result<TSuccess, {newErrorTypeList}>.FromSuccess(u.Value0)".WrapInTaskFromResultIf(isAsync)) }
			.Concat(
				Enumerable.Range(1, p.UnionSize - 1)
					.Select(i =>
					{
						var variable = i == p.UnionSize - 1 ? "_" : $"{i}";
						return i == p.SpecialIndex
							? new SwitchCaseText(variable, $"binding(u.Value{i})")
							: new SwitchCaseText(variable, $"Result<TSuccess, {newErrorTypeList}>.FromError(u.Value{i})".WrapInTaskFromResultIf(isAsync));
					})
			);
	}

	private static string ReplaceErrorTypeAtIndex(int count, int index) =>
		string.Join(", ",
			Enumerable.Range(0, count)
				.Select(i => i == index ? "TErrorNew" : $"TError{i}"));
}