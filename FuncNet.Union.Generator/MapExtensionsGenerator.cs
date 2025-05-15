namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

internal static class MapExtensionsGenerator
{
	public static string GenerateMapExtensionsFile(ExtensionsFileGenerationParams p) =>
		new SourceCodeFileBuilder(Header(p.Namespace))
			.AddClass(new ClassBuilder($"public static class Union{p.UnionSize}{p.MethodNameOnly}")
				.AddMethods(CreateAllMethodsGenerationParams(p).Select(GenerateMethod)))
			.ToString();

	private static string Header(string @namespace) =>
$@"using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace {@namespace};";

	private static IEnumerable<MapMethodGenerationParams> CreateAllMethodsGenerationParams(
		ExtensionsFileGenerationParams p) =>
		from asyncConfig in allPossibleAsyncMethodConfigs
		from specialIndex in Enumerable.Range(0, p.UnionSize)
		select new MapMethodGenerationParams(p.MethodNameOnly, p.UnionSize, asyncConfig, specialIndex);

	private static MethodBuilder GenerateMethod(MapMethodGenerationParams p) =>
		new MethodBuilder($"public static {UnionOfTsOneNew(p.UnionSize, p.SpecialIndex).WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}{p.SpecialIndex}<T{p.SpecialIndex}New, {TsOld(p.UnionSize, p.SpecialIndex)}>")
			.AddArgument($"this {UnionOfTsOneOld(p.UnionSize, p.SpecialIndex).WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} union")
			.AddArgument($"Func<T{p.SpecialIndex}Old, {$"T{p.SpecialIndex}New".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> mapping")
			.AddAsyncArgumentsIfNeeded(p)
			.AddBodyStatement($"var u = {"union".WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}")
			.AddThrowIfCanceledStatementIfNeeded(p)
			.AddBodyStatement($"return {new SwitchExpressionBuilder("u.Index")
				.AddCases(GenerateSwitchExpressionCases(p))
				.ToString()
				.WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}");

	private static IEnumerable<SwitchCaseText> GenerateSwitchExpressionCases(
		MapMethodGenerationParams p) =>
		Enumerable.Range(0, p.UnionSize)
			.Select(i =>
			{
				var variable = i == p.UnionSize - 1 ? "_" : $"{i}";
				return new SwitchCaseText(
					variable,
					GenerateSwitchCaseReturnValue(new SwitchCaseOneSpecial(i, variable, p.SpecialIndex), p));
			});

	private static string GenerateSwitchCaseReturnValue(SwitchCaseOneSpecial @case, MapMethodGenerationParams p) =>
		(@case.Index == p.SpecialIndex ? $"mapping(u.Value{@case.Index})" : $"u.Value{@case.Index}")
		.WrapInTaskFromResultIf(@case.Index != p.SpecialIndex && p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))
		.WrapInNewUnionFromT(@case, p.UnionSize);

	private sealed record class MapMethodGenerationParams(
		string MethodNameOnly,
		int UnionSize,
		UnionMethodAsyncConfig AsyncConfig,
		int SpecialIndex) : MethodGenerationParams(MethodNameOnly, UnionSize, AsyncConfig);
}