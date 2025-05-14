namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

internal static class MapAndBindExtensionsGenerator
{
	public sealed record class MapOrBindMethodsGenerationParams(
		string MethodNameOnly,
		int UnionSize,
		GenerateAppliedMethodReturnType AppliedMethodReturnType,
		string AppliedMethodParameterName);

	public delegate string GenerateAppliedMethodReturnType(int index);

	public static string GenerateExtensionsFile(string @namespace, MapOrBindMethodsGenerationParams p) =>
		new SourceCodeFileBuilder(Header(@namespace))
			.AddClass(new ClassBuilder($"public static class Union{p.UnionSize}{p.MethodNameOnly}")
				.AddMethods(CreateAllMethodsGenerationParams(p).Select(GenerateMethod)))
			.ToString();

	private static string Header(string @namespace) =>
$@"using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace {@namespace};";

	private static IEnumerable<MapOrBindMethodGenerationParams> CreateAllMethodsGenerationParams(MapOrBindMethodsGenerationParams p) =>
		from asyncConfig in allPossibleAsyncMethodConfigs
		from specialIndex in Enumerable.Range(0, p.UnionSize)
		select new MapOrBindMethodGenerationParams(p, asyncConfig, specialIndex);

	private static MethodBuilder GenerateMethod(MapOrBindMethodGenerationParams p) =>
		new MethodBuilder($"public static {$"{UnionOfTsOneNew(p.UnionSize, p.SpecialIndex)}".WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}{p.SpecialIndex}<T{p.SpecialIndex}New, {TsOld(p.UnionSize, p.SpecialIndex)}>")
			.AddArgument($"this {$"{UnionOfTsOneOld(p.UnionSize, p.SpecialIndex)}".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} union")
			.AddArgument($"Func<T{p.SpecialIndex}Old, {p.AppliedMethodReturnType(p.SpecialIndex).WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> {p.AppliedMethodParameterName}")
			.AddArguments(p.IsAsync(UnionMethodAsyncConfig.ReturnType) ? asyncMethodAdditionalArguments : [])
			.AddBodyStatement($"var u = {"union".WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))}")
			.AddBodyStatement(p.IsAsync(UnionMethodAsyncConfig.ReturnType) ? THROW_IF_CANCELED : "")
			.AddBodyStatement($@"return {GenerateSwitchExpression(
				"u.Index", GenerateSwitchExpressionCases(p)).WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}");

	private static IEnumerable<SwitchCaseText> GenerateSwitchExpressionCases(
		MapOrBindMethodGenerationParams p) =>
		Enumerable.Range(0, p.UnionSize)
			.Select(i =>
			{
				var variable = i == p.UnionSize - 1 ? "_" : $"{i}";
				return new SwitchCaseText(
					variable,
					GenerateSwitchCaseReturnValue(new SwitchCaseOneSpecial(i, variable, p.SpecialIndex), p));
			});

	private static string GenerateSwitchCaseReturnValue(SwitchCaseOneSpecial @case, MapOrBindMethodGenerationParams p) =>
		(@case.Index == p.SpecialIndex
			? $"{p.AppliedMethodParameterName}(u.Value{@case.Index})"
			: $"u.Value{@case.Index}")
		.WrapInTaskFromResultIf(@case.Index != p.SpecialIndex && p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))
		.WrapInNewUnionFromTAccordingly(@case, p);

	private static string WrapInNewUnionFromTAccordingly(
		this string value, SwitchCaseOneSpecial @case, MapOrBindMethodGenerationParams p) =>
		p.AppliedMethodParameterName.Contains("bind", StringComparison.OrdinalIgnoreCase) // TODO Pawel: bad design to rely on "bind" but seems fine for now
			? value.WrapInNewUnionFromTIfNotSpecial(@case, p.UnionSize)
			: value.WrapInNewUnionFromT(@case, p.UnionSize);

	private sealed record class MapOrBindMethodGenerationParams(
		MapOrBindMethodsGenerationParams Params,
		UnionMethodAsyncConfig MethodAsyncConfig,
		int SpecialIndex)
	{
		public string MethodNameOnly => Params.MethodNameOnly;
		public int UnionSize => Params.UnionSize;
		public GenerateAppliedMethodReturnType AppliedMethodReturnType => Params.AppliedMethodReturnType;
		public string AppliedMethodParameterName => Params.AppliedMethodParameterName;

		public bool IsAsync(UnionMethodAsyncConfig asyncConfig) => (asyncConfig & MethodAsyncConfig) != 0;
	}
}