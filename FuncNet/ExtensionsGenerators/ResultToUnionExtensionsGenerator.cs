using FuncNet.CodeGeneration;
using FuncNet.CodeGeneration.Builders;
using FuncNet.CodeGeneration.Models;

namespace FuncNet.ExtensionsGenerators;

using static UnionMethodConfigConsts;
using static GenericsGenerationUtils;

internal static class ResultToUnionExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MethodGenerationParams> CreateAllMethodsGenerationParams(UnionExtensionsFileGenerationParams p) =>
		from asyncConfig in AllOrNoneNoneMethodAsyncConfigs
		select new MethodGenerationParams(
			p.ExtendedTypeName, p.MethodNameOnly, p.UnionSize, asyncConfig, asyncConfig == UnionMethodAsyncConfig.None ? new MethodType.Member() : new MethodType.Extension(p.ThisArgumentName),
			p.ElementTypeNamesGenerator, p.GetUnionOnArgument, p.FactoryMethodName, p.OtherSwitchCaseReturnValue);

	private static MethodBuilder GenerateMethod(MethodGenerationParams p) =>
		new MethodBuilder($"public {(p.MethodType is MethodType.Extension ? "static" : "")}"
				+ $" {ResultBackingUnion(p.UnionSize).WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))}"
				+ $" {p.MethodNameOnly}{(p.MethodType is MethodType.Extension ? $"<{p.Ts().CommaSeparated()}>" : "")}")
			.AddArgumentIf($"this {p.ExtendedTypeOfTs().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} {p.ThisArgumentName}", () => p.MethodType is MethodType.Extension)
			.AddBodyStatement($"return ({p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}).Value;");
}