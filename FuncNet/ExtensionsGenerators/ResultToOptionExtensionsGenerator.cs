using FuncNet.CodeGeneration;
using FuncNet.CodeGeneration.Builders;
using FuncNet.CodeGeneration.Models;

namespace FuncNet.ExtensionsGenerators;

using static UnionMethodConfigConsts;

internal static class ResultToOptionExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MethodGenerationParams> CreateAllMethodsGenerationParams(UnionExtensionsFileGenerationParams p) =>
		from config in AllOrNoneMemberAndExtensionMethodConfigs(p.ThisArgumentName)
		from asyncConfig in config.asyncConfig
		select new MethodGenerationParams(
			p.ExtendedTypeName, p.MethodNameOnly, p.UnionSize, asyncConfig, config.methodType,
			p.ElementTypeNamesGenerator, p.GetUnionOnArgument, p.FactoryMethodName, p.OtherSwitchCaseReturnValue);

	private static MethodBuilder GenerateMethod(MethodGenerationParams p) =>
		new MethodBuilder($"public {(p.MethodType is MethodType.Extension ? "static" : "")}"
				+ $" {"Option<TSuccess>".WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))}"
				+ $" {p.MethodNameOnly}"
				+ $"{(p.MethodType is MethodType.Extension ? $"<{p.Ts().CommaSeparated()}>" : "")}")
			.AddArgumentIf($"this {p.ExtendedTypeOfTs().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}"
				+ $" {p.ThisArgumentName}", () => p.MethodType is MethodType.Extension)
			.AddBodyStatement($"var r = {p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}")
			.AddBodyStatement("return r.IsSuccess ? Option<TSuccess>.Some(r.Value.Value0) : Option<TSuccess>.None;");
}