using FuncNet.Generator.CodeGeneration;
using FuncNet.Generator.CodeGeneration.Builders;
using FuncNet.Generator.CodeGeneration.Models;

namespace FuncNet.Generator.ExtensionsGenerators;

using static UnionMethodConfigConsts;

internal static class OptionToResultExtensionsGenerator
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
		var errorTs = string.Join(", ", Enumerable.Range(0, p.NewElementsCount).Select(i => $"TError{i}"));
		var newGenericArgs = $"{p.TsCommaSeparated()}, {errorTs}";
		var newType = $"Result<{newGenericArgs}>";
		var errorIfNoneReturnType = p.NewElementsCount == 1 ? "TError0" : $"Union<{errorTs}>";
		var errorIfNoneValue = $"({"errorIfNone()".WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))})";
		return new MethodBuilder($"public static {newType.WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}<{newGenericArgs}>")
			.AddArgument($"this {p.ExtendedTypeOfTs().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} {p.ThisArgumentName}")
			.AddArgument($"Func<{errorIfNoneReturnType.WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> errorIfNone")
			.AddBodyStatement($"var extended = ({p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}).Match<{newType}, TSome>("
				+ $"some => {$"{newType}.FromSuccess(some)".WrapInTaskFromResultIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}, {(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType) ? "async " : "")} () => {GenerateValueForErrorCase()})")
			.AddBodyStatement($"return {"extended".WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))};");

		string GenerateValueForErrorCase() => p.NewElementsCount == 1
			? errorIfNoneValue
			: $"{errorIfNoneValue}.Match<{newType}, {errorTs}>({string.Join(", ", Enumerable.Range(0, p.NewElementsCount).Select(i => $"error{i} => error{i}"))})";
	}
}