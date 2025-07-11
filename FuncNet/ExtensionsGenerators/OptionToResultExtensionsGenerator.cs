using FuncNet.CodeGeneration;
using FuncNet.CodeGeneration.Builders;
using FuncNet.CodeGeneration.Models;

namespace FuncNet.ExtensionsGenerators;

using static UnionMethodConfigConsts;

internal static class OptionToResultExtensionsGenerator
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
		var errorTs = Enumerable.Range(0, p.NewElementsCount).Select(i => $"TError{i}").CommaSeparated();
		var newGenericArgs = $"{p.Ts().CommaSeparated()}, {errorTs}";
		var newType = $"Result<{newGenericArgs}>";
		var errorIfNoneReturnType = p.NewElementsCount == 1 ? "TError0" : $"Union<{errorTs}>";
		var errorIfNoneValue = $"({"errorIfNone()".WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))})";
		return new MethodBuilder($"public {(p.MethodType is MethodType.Extension ? "static" : "")} {newType.WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}<{(p.MethodType is MethodType.Extension ? newGenericArgs : errorTs)}>")
			.AddArgumentIf($"this {p.TypeOfTs().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} {p.ThisArgumentName}", () => p.MethodType is MethodType.Extension)
			.AddArgument($"Func<{errorIfNoneReturnType.WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> errorIfNone")
			.AddBodyStatement($"var extended = ({p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}).Match<{newType}>("
				+ $"some => {$"{newType}.FromSuccess(some)".WrapInTaskFromResultIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}, {(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType) ? "async " : "")} () => {GenerateValueForErrorCase()})")
			.AddBodyStatement($"return {"extended".WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))};");

		string GenerateValueForErrorCase() => p.NewElementsCount == 1
			? errorIfNoneValue
			: $"{errorIfNoneValue}.Match<{newType}>({Enumerable.Range(0, p.NewElementsCount).Select(i => $"error{i} => error{i}").CommaSeparated()})";
	}
}