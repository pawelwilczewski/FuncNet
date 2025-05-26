using FuncNet.Generator.CodeGeneration;
using FuncNet.Generator.CodeGeneration.Builders;
using FuncNet.Generator.CodeGeneration.Models;

namespace FuncNet.Generator.ExtensionsGenerators;

using static UnionMethodConfigConsts;

internal static class TapExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MethodGenerationParamsWithSpecialIndex> CreateAllMethodsGenerationParams(UnionExtensionsFileGenerationParams p) =>
		from asyncConfig in AllPossibleMethodAsyncConfigs
		from specialIndex in Enumerable.Range(0, p.UnionSize)
		select new MethodGenerationParamsWithSpecialIndex(
			p.ExtendedTypeName, p.MethodNameOnly, p.UnionSize, asyncConfig, p.ThisArgumentName,
			p.ElementTypeNamesGenerator, p.GetUnionOnArgument, p.FactoryMethodName, p.OtherSwitchCaseReturnValue, specialIndex);

	private static MethodBuilder GenerateMethod(MethodGenerationParamsWithSpecialIndex p) =>
		new MethodBuilder($"public static {p.ExtendedTypeOfTs().WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}{p.ElementTypeNamesGenerator().ElementAt(p.SpecialIndex)}<{p.TsCommaSeparated()}>")
			.AddArgument($"this {p.ExtendedTypeOfTs().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} {p.ThisArgumentName}")
			.AddArgument(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType) ? $"Func<{p.Ts().ElementAt(p.SpecialIndex)}, Task> action" : $"Action<{p.Ts().ElementAt(p.SpecialIndex)}> action")
			.AddCancellationTokenIfAsync(p)
			.AddBodyStatement($"var u = {p.GetUnionOnArgument(p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion)))}")
			.AddThrowIfCanceledIfAsync(p)
			.AddBodyStatement($"if (u.Index == {p.SpecialIndex}) {$"action(u.Value{p.SpecialIndex})".WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}")
			.AddBodyStatement($"return {p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}");
}