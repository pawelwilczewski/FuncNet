using static FuncNet.Union.Generator.CodeGenerationUtils;

namespace FuncNet.Union.Generator;

internal static class ResultMatchExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionMethodsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MatchMethodGenerationParams> CreateAllMethodsGenerationParams(UnionExtensionMethodsFileGenerationParams p) =>
		from asyncConfig in allPossibleAsyncMethodConfigs
		from otherCaseSize in Enumerable.Range(1, p.UnionSize - 1)
		select new MatchMethodGenerationParams(p.ExtendedTypeName, p.MethodNameOnly, p.UnionSize, asyncConfig, otherCaseSize, p.ThisArgumentName, p.GetUnionOnArgument, p.ElementTypeNamesGenerator);

	private static MethodBuilder GenerateMethod(MatchMethodGenerationParams p) =>
		new MethodBuilder($"public static {"TResult".WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}<TResult, {ResultTs(p.UnionSize)}>")
			.AddArgument($"this {ResultOfTs(p.UnionSize).WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} result")
			.AddArgument($"Func<TSuccess, {"TResult".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> success")
			.AddArguments(Enumerable.Range(1, p.UnionSize - p.OtherCaseSize - 1).Select(i => $"Func<TError{i - 1}, {"TResult".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> error{i - 1}"))
			.AddArgument(GenerateLastArgumentCode(p))
			.AddAsyncArgumentsIfAsync(p)
			.AddBodyStatement($"var u = ({"result".WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}).Value")
			.AddThrowIfCanceledStatementIfAsync(p)
			.AddBodyStatement($"return {new SwitchExpressionBuilder("u.Index")
				.AddCase(new SwitchCaseText("0", "success(u.Value0)"))
				.AddCases(Enumerable.Range(1, p.UnionSize - p.OtherCaseSize - 1)
					.Select(i => new SwitchCaseText(i.ToString(), $"error{i - 1}(u.Value{i})")))
				.AddCase(GenerateOtherSwitchCase(p))
				.ToString()
				.WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}");

	private static string GenerateLastArgumentCode(MatchMethodGenerationParams p)
	{
		var tResultWrapped = "TResult".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType));
		return p.OtherCaseSize <= 1
			? $"Func<TError{p.UnionSize - 2}, {tResultWrapped}> error{p.UnionSize - 2}"
			: $"Func<{UnionOfTErrors(p.UnionSize - p.OtherCaseSize - 1, p.OtherCaseSize)}, {tResultWrapped}> other";
	}

	private static SwitchCaseText GenerateOtherSwitchCase(MatchMethodGenerationParams p) => p.OtherCaseSize <= 1
		? new SwitchCaseText("_", $"error{p.UnionSize - 2}(u.Value{p.UnionSize - 1})")
		: new SwitchCaseText("_", $"other(new {UnionOfTErrors(p.UnionSize - p.OtherCaseSize - 1, p.OtherCaseSize)}(u.Value))");
}