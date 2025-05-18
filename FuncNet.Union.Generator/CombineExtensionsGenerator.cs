namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

internal static class CombineExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionMethodsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MethodGenerationParamsWithOptionsCount> CreateAllMethodsGenerationParams(UnionExtensionMethodsFileGenerationParams p) =>
		from asyncConfig in allPossibleAsyncMethodConfigs
		from optionsCount in Enumerable.Range(2, 5)
		select new MethodGenerationParamsWithOptionsCount(
			p.ExtendedTypeName, p.MethodNameOnly, p.UnionSize, asyncConfig, p.ThisArgumentName,
			p.ElementTypeNamesGenerator, p.GetUnionOnArgument, p.FactoryMethodName, optionsCount);

	private static MethodBuilder GenerateMethod(MethodGenerationParamsWithOptionsCount p)
	{
		var successTs = string.Join(", ", Enumerable.Range(0, p.OptionsCount).Select(i => $"{p.Ts().First()}{i}"));
		var errorTs = string.Join(", ", p.Ts().Skip(1));
		var joinReturnType = "TResult".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType));

		return new MethodBuilder($"public static {"TResult".WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}<TResult, {successTs}, {errorTs}>")
			.AddArguments(Enumerable.Range(0, p.OptionsCount).Select(i => $"{$"Result<TSuccess{i}, {errorTs}>".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} result{i}"))
			.AddArgument($"Func<{successTs}, {joinReturnType}> combineSuccess")
			.AddArgument($"Func<{string.Join(", ", p.Ts().Skip(1).Select(t => $"IReadOnlyList<{t}>"))}, {joinReturnType}> combineErrors")
			.AddAsyncArgumentsIfAsync(p)
			.AddBodyStatements(Enumerable.Range(0, p.OptionsCount).Select(i => $"var r{i} = {$"result{i}".WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}"))
			.AddBodyStatement(new IfStatementBuilder($"{string.Join("\n\t\t\t&& ", Enumerable.Range(0, p.OptionsCount).Select(i => $"r{i}.IsSuccess"))}")
				.AddStatement($"return {$"combineSuccess({string.Join(", ", Enumerable.Range(0, p.OptionsCount).Select(i => $"r{i}.Value.Value0"))})".WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}")
				.ToString())
			.AddThrowIfCanceledStatementIfAsync(p)
			.AddBodyStatements(Enumerable.Range(0, p.UnionSize - 1)
				.Select(errorIndex => $"var errors{errorIndex} = new List<TError{errorIndex}>();\n\t\t"
					+ $"{string.Join(";\n\t\t", Enumerable.Range(0, p.OptionsCount).Select(resultIndex => $"if (r{resultIndex}.Value.Index == {errorIndex + 1}) errors{errorIndex}.Add(r{resultIndex}.Value.Value{errorIndex + 1})"))}"))
			.AddBodyStatement($"return {$"combineErrors({string.Join(", ", Enumerable.Range(0, p.UnionSize - 1).Select(i => $"errors{i}"))})".WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}");
	}
}