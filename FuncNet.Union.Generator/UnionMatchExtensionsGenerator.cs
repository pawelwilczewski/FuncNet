namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

internal sealed record class MatchMethodGenerationParams(
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig,
	int OtherCaseSize) : MethodGenerationParams(MethodNameOnly, UnionSize, AsyncConfig);

internal static class UnionMatchExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionMethodsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MatchMethodGenerationParams> CreateAllMethodsGenerationParams(UnionExtensionMethodsFileGenerationParams p) =>
		from asyncConfig in allPossibleAsyncMethodConfigs
		from otherCaseSize in Enumerable.Range(1, p.UnionSize - 1)
		select new MatchMethodGenerationParams(p.MethodNameOnly, p.UnionSize, asyncConfig, otherCaseSize);

	private static MethodBuilder GenerateMethod(MatchMethodGenerationParams p) =>
		new MethodBuilder($"public static {"TResult".WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}<TResult, {CommaSeparatedTs(p.UnionSize)}>")
			.AddArgument($"this {UnionOfTs(p.UnionSize).WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} union")
			.AddArguments(Enumerable.Range(0, p.UnionSize - p.OtherCaseSize).Select(i => $"Func<T{i}, {"TResult".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> t{i}"))
			.AddArgument(GenerateLastArgumentCode(p))
			.AddAsyncArgumentsIfNeeded(p)
			.AddBodyStatement($"var u = {"union".WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}")
			.AddThrowIfCanceledStatementIfNeeded(p)
			.AddBodyStatement($"return {new SwitchExpressionBuilder("u.Index")
				.AddCases(Enumerable.Range(0, p.UnionSize - p.OtherCaseSize)
					.Select(i => new SwitchCaseText(i.ToString(), $"t{i}(u.Value{i})")))
				.AddCase(GenerateOtherSwitchCase(p))
				.ToString()
				.WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}");

	private static string GenerateLastArgumentCode(MatchMethodGenerationParams p)
	{
		var tResultWrapped = "TResult".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType));
		return p.OtherCaseSize <= 1
			? $"Func<T{p.UnionSize - 1}, {tResultWrapped}> t{p.UnionSize - 1}"
			: $"Func<{UnionOfTs(p.UnionSize - p.OtherCaseSize, p.OtherCaseSize)}, {tResultWrapped}> other";
	}

	private static SwitchCaseText GenerateOtherSwitchCase(MatchMethodGenerationParams p) => p.OtherCaseSize <= 1
		? new SwitchCaseText("_", $"t{p.UnionSize - 1}(u.Value{p.UnionSize - 1})")
		: new SwitchCaseText("_", $"other(new {UnionOfTs(p.UnionSize - p.OtherCaseSize, p.OtherCaseSize)}(u.Value))");
}