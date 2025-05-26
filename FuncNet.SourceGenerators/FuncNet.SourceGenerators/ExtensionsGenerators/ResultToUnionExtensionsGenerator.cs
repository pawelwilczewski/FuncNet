using FuncNet.Generator.CodeGeneration;
using FuncNet.Generator.CodeGeneration.Builders;
using FuncNet.Generator.CodeGeneration.Models;

namespace FuncNet.Generator.ExtensionsGenerators;

using static UnionMethodAsyncConfigConsts;
using static GenericsGenerationUtils;

internal static class ResultToUnionExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MethodGenerationParams> CreateAllMethodsGenerationParams(UnionExtensionsFileGenerationParams p) =>
		from asyncConfig in NoneOrAllMethodAsyncConfigs
		select new MethodGenerationParams(
			p.ExtendedTypeName, p.MethodNameOnly, p.UnionSize, asyncConfig, p.ThisArgumentName,
			p.ElementTypeNamesGenerator, p.GetUnionOnArgument, p.FactoryMethodName, p.OtherSwitchCaseReturnValue);

	private static MethodBuilder GenerateMethod(MethodGenerationParams p) =>
		new MethodBuilder($"public static {ResultBackingUnion(p.UnionSize).WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}<{p.TsCommaSeparated()}>")
			.AddArgument($"this {p.ExtendedTypeOfTs().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} {p.ThisArgumentName}")
			.AddBodyStatement($"return ({p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}).Value;");
}