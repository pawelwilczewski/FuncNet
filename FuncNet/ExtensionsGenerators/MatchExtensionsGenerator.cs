using FuncNet.Generator.CodeGeneration;
using FuncNet.Generator.CodeGeneration.Builders;
using FuncNet.Generator.CodeGeneration.Models;

namespace FuncNet.Generator.ExtensionsGenerators;

using static UnionMethodConfigConsts;

internal static class MatchExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MethodGenerationParamsWithOtherCaseSize> CreateAllMethodsGenerationParams(UnionExtensionsFileGenerationParams p) =>
		from asyncConfig in AllPossibleMethodAsyncConfigs
		from otherCaseSize in Enumerable.Range(1, p.UnionSize - 1)
		select new MethodGenerationParamsWithOtherCaseSize(
			p.ExtendedTypeName, p.MethodNameOnly, p.UnionSize, asyncConfig, p.ThisArgumentName, p.ElementTypeNamesGenerator,
			p.GetUnionOnArgument, p.FactoryMethodName, p.OtherSwitchCaseReturnValue, otherCaseSize);

	private static MethodBuilder GenerateMethod(MethodGenerationParamsWithOtherCaseSize p) =>
		new MethodBuilder($"public static {"TResult".WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}<TResult, {p.TsCommaSeparated()}>")
			.AddArgument($"this {p.ExtendedTypeOfTs().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} {p.ThisArgumentName}")
			.AddArguments(Enumerable.Range(0, p.UnionSize - p.OtherCaseSize).Select(i => $"Func<{p.Ts().ElementAt(i)}, {"TResult".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> {p.ElementTypeNamesLowerCamelCase().ElementAt(i)}"))
			.AddArgument(GenerateLastArgument(p))
			.AddCancellationTokenIfAsync(p)
			.AddBodyStatement($"var u = {p.GetUnionOnArgument(p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion)))}")
			.AddThrowIfCanceledIfAsync(p)
			.AddBodyStatement($"return {new SwitchExpressionBuilder("u.Index")
				.AddCases(Enumerable.Range(0, p.UnionSize - p.OtherCaseSize)
					.Select(i => new SwitchCaseText(i.ToString(), $"{p.ElementTypeNamesLowerCamelCase().ElementAt(i)}(u.Value{i})")))
				.AddCase(GenerateOtherSwitchCase(p))
				.ToString()
				.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}");

	private static string GenerateLastArgument(MethodGenerationParamsWithOtherCaseSize p)
	{
		var tResultWrapped = "TResult".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType));
		return p.OtherCaseSize <= 1
			? $"Func<{p.Ts().Last()}, {tResultWrapped}> {p.ElementTypeNamesLowerCamelCase().Last()}"
			: $"Func<{p.UnionOfTsOtherCase()}, {tResultWrapped}> other";
	}

	private static SwitchCaseText GenerateOtherSwitchCase(MethodGenerationParamsWithOtherCaseSize p) => p.OtherCaseSize <= 1
		? new SwitchCaseText("_", $"{p.ElementTypeNamesLowerCamelCase().Last()}(u.Value{p.UnionSize - 1})")
		: new SwitchCaseText("_", $"other(new {p.UnionOfTsOtherCase()}(u.Value))");

	private static string UnionOfTsOtherCase(this MethodGenerationParamsWithOtherCaseSize p) =>
		$"Union<{string.Join(", ", p.Ts().Skip(p.UnionSize - p.OtherCaseSize).Take(p.OtherCaseSize))}>";

	private static IEnumerable<string> ElementTypeNamesLowerCamelCase(this MethodGenerationParamsWithOtherCaseSize p) =>
		p.ElementTypeNamesGenerator()
			.Select(typeName => $"{char.ToLower(typeName[0])}{typeName.Substring(1)}")
			.Select(typeName => char.IsDigit(typeName[0]) ? $"t{typeName}" : typeName);
}