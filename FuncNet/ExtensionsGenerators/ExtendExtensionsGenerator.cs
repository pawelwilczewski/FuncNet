using FuncNet.Generator.CodeGeneration;
using FuncNet.Generator.CodeGeneration.Builders;
using FuncNet.Generator.CodeGeneration.Models;

namespace FuncNet.Generator.ExtensionsGenerators;

using static UnionMethodConfigConsts;

internal static class ExtendExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MethodGenerationParamsWithNewElementsCount> CreateAllMethodsGenerationParams(UnionExtensionsFileGenerationParams p) =>
		from asyncConfig in NoneOrAllMethodAsyncConfigs
		from newElementsCount in Enumerable.Range(1, MAX_UNION_SIZE - p.UnionSize)
		select new MethodGenerationParamsWithNewElementsCount(
			p.ExtendedTypeName, p.MethodNameOnly, p.UnionSize, asyncConfig, p.ThisArgumentName,
			p.ElementTypeNamesGenerator, p.GetUnionOnArgument, p.FactoryMethodName, p.OtherSwitchCaseReturnValue,
			newElementsCount);

	private static MethodBuilder GenerateMethod(MethodGenerationParamsWithNewElementsCount p)
	{
		var newGenericArgs = $"{p.TsCommaSeparated()}, {string.Join(", ", Enumerable.Range(p.UnionSize, p.NewElementsCount).Select(i => $"T{i}"))}";
		var newType = $"{p.ExtendedTypeName}<{newGenericArgs}>";
		return new MethodBuilder($"public static {newType.WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}<{newGenericArgs}>")
			.AddArgument($"this {p.ExtendedTypeOfTs().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} {p.ThisArgumentName}")
			.AddBodyStatement($"{newType} extended = {p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}")
			.AddBodyStatement("return extended");
	}
}