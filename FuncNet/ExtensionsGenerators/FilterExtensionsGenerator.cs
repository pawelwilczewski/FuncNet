using FuncNet.CodeGeneration;
using FuncNet.CodeGeneration.Builders;
using FuncNet.CodeGeneration.Models;

namespace FuncNet.ExtensionsGenerators;

using static UnionMethodConfigConsts;

internal static class FilterExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MethodGenerationParamsWithSpecialIndex> CreateAllMethodsGenerationParams(UnionExtensionsFileGenerationParams p) =>
		from asyncConfig in AllPossibleMethodAsyncConfigs
		from specialIndex in Enumerable.Range(0, p.UnionSize)
		select new MethodGenerationParamsWithSpecialIndex(
			p.ExtendedTypeName, p.MethodNameOnly, p.UnionSize, asyncConfig, p.ThisArgumentName,
			p.ElementTypeNamesGenerator, p.GetUnionOnArgument, p.FactoryMethodName, p.OtherSwitchCaseReturnValue, specialIndex);

	public static MethodBuilder GenerateMethod(MethodGenerationParamsWithSpecialIndex p) =>
		new MethodBuilder($"public static {p.ExtendedTypeOfTs().WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}{p.ElementTypeNamesGenerator().ElementAt(p.SpecialIndex)}<{p.TsCommaSeparated()}>")
			.AddArgument($"this {p.ExtendedTypeOfTs().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} {p.ThisArgumentName}")
			.AddArgument($"Func<{p.Ts().ElementAt(p.SpecialIndex)}, {"bool".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> predicate")
			.AddArgument($"Func<{p.ExtendedTypeOfTs().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> otherwise")
			.AddCancellationTokenIfAsync(p)
			.AddBodyStatement($"var u = {p.GetUnionOnArgument(p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion)))}")
			.AddThrowIfCanceledIfAsync(p)
			.AddBodyStatement($"if (u.Index == {p.SpecialIndex} && !({$"predicate(u.Value{p.SpecialIndex})".WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))})) return {"otherwise()".WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}")
			.AddBodyStatement($"return {p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}");
}