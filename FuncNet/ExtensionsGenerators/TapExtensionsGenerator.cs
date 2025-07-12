using FuncNet.CodeGeneration;
using FuncNet.CodeGeneration.Builders;
using FuncNet.CodeGeneration.Models;

namespace FuncNet.ExtensionsGenerators;

using static UnionMethodConfigConsts;

internal static class TapExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MethodGenerationParamsWithSpecialIndex> CreateAllMethodsGenerationParams(UnionExtensionsFileGenerationParams p) =>
		from config in MemberAndExtensionMethodConfigs(p.ThisArgumentName)
		from asyncConfig in config.asyncConfig
		from specialIndex in Enumerable.Range(0, p.UnionSize)
		select new MethodGenerationParamsWithSpecialIndex(
			p.TypeName, p.MethodNameOnly, p.UnionSize, asyncConfig, config.methodType,
			p.ElementTypeNamesGenerator, p.GetUnionOnArgument, p.FactoryMethodName, p.OtherSwitchCaseReturnValue, specialIndex);

	private static MethodBuilder GenerateMethod(MethodGenerationParamsWithSpecialIndex p) =>
		new MethodBuilder($"public {(p.MethodType is MethodType.Extension ? "static" : "")}"
				+ $" {p.TypeOfTs().WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))}"
				+ $" {p.MethodNameOnly}{p.ElementTypeNamesGenerator().ElementAt(p.SpecialIndex)}{p.AsyncSuffixOrEmpty}"
				+ $"{(p.MethodType is MethodType.Extension ? $"<{p.Ts().CommaSeparated()}>" : "")}")
			.AddArgumentIf($"this {p.TypeOfTs().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}"
				+ $" {p.ThisArgumentName}", () => p.MethodType is MethodType.Extension)
			.AddArgument(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType)
				? $"Func<{p.Ts().ElementAt(p.SpecialIndex)}, Task> action"
				: $"Action<{p.Ts().ElementAt(p.SpecialIndex)}> action")
			.AddCancellationTokenIfAsync(p)
			.AddBodyStatement($"var u = {p.GetUnionOnArgument(p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion)))}")
			.AddThrowIfCanceledIfAsync(p)
			.AddBodyStatement($"if (u.Index == {p.SpecialIndex}) {$"action(u.Value{p.SpecialIndex})".WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}")
			.AddBodyStatement($"return {p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}");
}