using FuncNet.CodeGeneration;
using FuncNet.CodeGeneration.Builders;
using FuncNet.CodeGeneration.Models;

namespace FuncNet.ExtensionsGenerators;

using static UnionMethodConfigConsts;

internal static class ZipExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MethodGenerationParams> CreateAllMethodsGenerationParams(UnionExtensionsFileGenerationParams p) =>
		from asyncConfig in AllPossibleMethodAsyncConfigs
		select new MethodGenerationParams(
			p.TypeName, p.MethodNameOnly, p.UnionSize, asyncConfig, new MethodType.Extension(p.ThisArgumentName),
			p.ElementTypeNamesGenerator, p.GetUnionOnArgument, p.FactoryMethodName, p.OtherSwitchCaseReturnValue);

	private static MethodBuilder GenerateMethod(MethodGenerationParams p) =>
		new MethodBuilder($"public {(p.MethodType is MethodType.Extension ? "static" : "")} {"TResult".WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}<TResult, {p.Ts().CommaSeparated()}>")
			.AddArgument($"this IEnumerable<{p.TypeOfTs().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}> values")
			.AddArgument($"Func<{string.Join(", ", p.Ts().Select(t => $"IEnumerable<{t}>"))}, {"TResult".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> zip")
			.AddCancellationTokenIfAsync(p)
			.AddBodyStatement($"var results = ({(p.IsAsync(UnionMethodAsyncConfig.InputUnion) ? "Task.WhenAll(values)".WrapInAwaitConfigured() : "values")}).ToArray()")
			.AddBodyStatement($"return {$"zip({string.Join(", ", Enumerable.Range(0, p.UnionSize)
				.Select(i => $"results.Where(x => {p.GetUnionOnArgument("x")}.Index == {i}).Select(x => {p.GetUnionOnArgument("x")}.Value{i})"))})".WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}");
}