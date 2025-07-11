using FuncNet.CodeGeneration;
using FuncNet.CodeGeneration.Builders;
using FuncNet.CodeGeneration.Models;

namespace FuncNet.ExtensionsGenerators;

using static UnionMethodConfigConsts;

internal static class BindExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MethodGenerationParamsWithSpecialIndex> CreateAllMethodsGenerationParams(UnionExtensionsFileGenerationParams p) =>
		from config in MemberAndExtensionMethodConfigs(p.ThisArgumentName)
		from asyncConfig in config.asyncConfig
		from specialIndex in Enumerable.Range(0, p.UnionSize)
		select new MethodGenerationParamsWithSpecialIndex(
			p.ExtendedTypeName, p.MethodNameOnly, p.UnionSize, asyncConfig, config.methodType,
			p.ElementTypeNamesGenerator, p.GetUnionOnArgument, p.FactoryMethodName, p.OtherSwitchCaseReturnValue, specialIndex);

	private static MethodBuilder GenerateMethod(MethodGenerationParamsWithSpecialIndex p) =>
		new MethodBuilder($"public {(p.MethodType is MethodType.Extension ? "static" : "")}"
				+ $" {p.ExtendedTypeOfTsNew().WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))}"
				+ $" {p.MethodNameOnly}{p.ElementTypeNamesGenerator().ElementAt(p.SpecialIndex)}"
				+ $"<{(p.MethodType is MethodType.Extension ? $"{p.Ts().ElementAt(p.SpecialIndex)}New, {p.Ts().CommaSeparated()}" : $"{p.Ts().ElementAt(p.SpecialIndex)}New")}>")
			.AddArgumentIf($"this {p.ExtendedTypeOfTs().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}"
				+ $" {p.ThisArgumentName}", () => p.MethodType is MethodType.Extension)
			.AddArgument($"Func<{p.Ts().ElementAt(p.SpecialIndex)},"
				+ $" {p.ExtendedTypeOfTsNew().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> binding")
			.AddCancellationTokenIfAsync(p)
			.AddBodyStatement($"var u = {p.GetUnionOnArgument(p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion)))}")
			.AddThrowIfCanceledIfAsync(p)
			.AddBodyStatement($"return {new SwitchExpressionBuilder("u.Index")
				.AddCases(GenerateSwitchExpressionCases(p))
				.AddCase(new SwitchCaseText("_", p.OtherSwitchCaseReturnValue(p)))
				.ToString()
				.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}");

	private static IEnumerable<SwitchCaseText> GenerateSwitchExpressionCases(MethodGenerationParamsWithSpecialIndex p) =>
		Enumerable.Range(0, p.UnionSize)
			.Select(i =>
			{
				var variable = i.ToString();
				return new SwitchCaseText(
					variable,
					GenerateSwitchCaseReturnValue(new SwitchCase(i, variable), p));
			});

	private static string GenerateSwitchCaseReturnValue(SwitchCase @case, MethodGenerationParamsWithSpecialIndex p) =>
		(@case.Index == p.SpecialIndex ? $"binding(u.Value{@case.Index})" : $"u.Value{@case.Index}")
		.WrapInTaskFromResultIf(@case.Index != p.SpecialIndex && p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))
		.WrapInNewExtendedTypeFromTIfNotSpecial(@case, p);
}