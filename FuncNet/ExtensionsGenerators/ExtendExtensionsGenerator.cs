using FuncNet.CodeGeneration;
using FuncNet.CodeGeneration.Builders;
using FuncNet.CodeGeneration.Models;

namespace FuncNet.ExtensionsGenerators;

using static UnionMethodConfigConsts;

internal static class ExtendExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MethodGenerationParamsWithNewElementsCount> CreateAllMethodsGenerationParams(UnionExtensionsFileGenerationParams p) =>
		from config in AllOrNoneMemberAndExtensionMethodConfigs(p.ThisArgumentName)
		from asyncConfig in config.asyncConfig
		from newElementsCount in Enumerable.Range(1, MAX_UNION_SIZE - p.UnionSize)
		select new MethodGenerationParamsWithNewElementsCount(
			p.TypeName, p.MethodNameOnly, p.UnionSize, asyncConfig, config.methodType,
			p.ElementTypeNamesGenerator, p.GetUnionOnArgument, p.FactoryMethodName, p.OtherSwitchCaseReturnValue,
			newElementsCount);

	private static MethodBuilder GenerateMethod(MethodGenerationParamsWithNewElementsCount p)
	{
		var addedGenerics = $"{Enumerable.Range(p.UnionSize, p.NewElementsCount).Select(i => $"T{i}").CommaSeparated()}";
		var newGenericArgs = $"{p.Ts().CommaSeparated()}, {addedGenerics}";
		var newType = $"{p.TypeName}<{newGenericArgs}>";
		return new MethodBuilder($"public {(p.MethodType is MethodType.Extension ? "static" : "")}"
				+ $" {newType.WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))}"
				+ $" {p.MethodNameOnly}<{(p.MethodType is MethodType.Extension ? newGenericArgs : addedGenerics)}>")
			.AddArgumentIf($"this {p.TypeOfTs().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} {p.ThisArgumentName}", () => p.MethodType is MethodType.Extension)
			.AddBodyStatement($"{newType} extended = {p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}")
			.AddBodyStatement("return extended");
	}
}