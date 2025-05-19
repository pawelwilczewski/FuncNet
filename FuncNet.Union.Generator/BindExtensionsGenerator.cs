using FuncNet.Union.Generator.CodeGeneration;
using FuncNet.Union.Generator.CodeGeneration.Builders;
using FuncNet.Union.Generator.CodeGeneration.Models;

namespace FuncNet.Union.Generator;

using static UnionMethodAsyncConfigConsts;

internal static class BindExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionMethodsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MethodGenerationParamsWithSpecialIndex> CreateAllMethodsGenerationParams(UnionExtensionMethodsFileGenerationParams p) =>
		from asyncConfig in AllPossibleMethodAsyncConfigs
		from specialIndex in Enumerable.Range(0, p.UnionSize)
		select new MethodGenerationParamsWithSpecialIndex(
			p.ExtendedTypeName, p.MethodNameOnly, p.UnionSize, asyncConfig, p.ThisArgumentName,
			p.ElementTypeNamesGenerator, p.GetUnionOnArgument, p.FactoryMethodName, specialIndex);

	private static MethodBuilder GenerateMethod(MethodGenerationParamsWithSpecialIndex p) =>
		new MethodBuilder($"public static {p.ExtendedTypeOfTsNew().WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}{p.ElementTypeNamesGenerator().ElementAt(p.SpecialIndex)}<{p.Ts().ElementAt(p.SpecialIndex)}New, {p.TsCommaSeparatedOld()}>")
			.AddArgument($"this {p.ExtendedTypeOfTsOld().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} {p.ThisArgumentName}")
			.AddArgument($"Func<{p.Ts().ElementAt(p.SpecialIndex)}Old, {p.ExtendedTypeOfTsNew().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> binding")
			.AddCancellationTokenIfAsync(p)
			.AddBodyStatement($"var u = {p.GetUnionOnArgument(p.ThisArgumentName.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion)))}")
			.AddThrowIfCanceledIfAsync(p)
			.AddBodyStatement($"return {new SwitchExpressionBuilder("u.Index")
				.AddCases(GenerateSwitchExpressionCases(p))
				.ToString()
				.WrapInAwaitConfiguredIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}");

	private static IEnumerable<SwitchCaseText> GenerateSwitchExpressionCases(MethodGenerationParamsWithSpecialIndex p) =>
		Enumerable.Range(0, p.UnionSize)
			.Select(i =>
			{
				var variable = i == p.UnionSize - 1 ? "_" : $"{i}";
				return new SwitchCaseText(
					variable,
					GenerateSwitchCaseReturnValue(new SwitchCase(i, variable), p));
			});

	private static string GenerateSwitchCaseReturnValue(SwitchCase @case, MethodGenerationParamsWithSpecialIndex p) =>
		(@case.Index == p.SpecialIndex ? $"binding(u.Value{@case.Index})" : $"u.Value{@case.Index}")
		.WrapInTaskFromResultIf(@case.Index != p.SpecialIndex && p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))
		.WrapInNewExtendedTypeFromTIfNotSpecial(@case, p);
}