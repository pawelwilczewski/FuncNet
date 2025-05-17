namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

internal sealed record class MatchMethodGenerationParams(
	string ExtendedTypeName,
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig,
	int OtherCaseSize,
	string ThisArgumentName,
	UnionGetter GetUnionOnArgument,
	Func<IEnumerable<string>> ElementTypeNamesGenerator) : MethodGenerationParams(ExtendedTypeName, MethodNameOnly, UnionSize, AsyncConfig, ThisArgumentName, GetUnionOnArgument, ElementTypeNamesGenerator);

internal static class MatchExtensionsGenerator
{
	public static IEnumerable<MethodBuilder> GenerateMethods(UnionExtensionMethodsFileGenerationParams p) =>
		CreateAllMethodsGenerationParams(p).Select(GenerateMethod);

	private static IEnumerable<MatchMethodGenerationParams> CreateAllMethodsGenerationParams(UnionExtensionMethodsFileGenerationParams p) =>
		from asyncConfig in allPossibleAsyncMethodConfigs
		from otherCaseSize in Enumerable.Range(1, p.UnionSize - 1)
		select new MatchMethodGenerationParams(p.ExtendedTypeName, p.MethodNameOnly, p.UnionSize, asyncConfig, otherCaseSize, p.ThisArgumentName, p.GetUnionOnArgument, p.ElementTypeNamesGenerator);

	private static MethodBuilder GenerateMethod(MatchMethodGenerationParams p) =>
		new MethodBuilder($"public static {"TResult".WrapInAsyncTaskIf(p.IsAsync(UnionMethodAsyncConfig.ReturnType))} {p.MethodNameOnly}<TResult, {p.TsCommaSeparated()}>")
			.AddArgument($"this {p.ExtendedTypeOfTs().WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion))} {p.ThisArgumentName}")
			.AddArguments(Enumerable.Range(0, p.UnionSize - p.OtherCaseSize).Select(i => $"Func<{p.Ts().ElementAt(i)}, {"TResult".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}> {p.ElementTypeNamesLowerCamelCase().ElementAt(i)}"))
			.AddArgument(GenerateLastArgument(p))
			.AddAsyncArgumentsIfAsync(p)
			.AddBodyStatement($"var u = {p.GetUnionOnArgument(p.ThisArgumentName.WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.InputUnion)))}")
			.AddThrowIfCanceledStatementIfAsync(p)
			.AddBodyStatement($"return {new SwitchExpressionBuilder("u.Index")
				.AddCases(Enumerable.Range(0, p.UnionSize - p.OtherCaseSize)
					.Select(i => new SwitchCaseText(i.ToString(), $"{p.ElementTypeNamesLowerCamelCase().ElementAt(i)}(u.Value{i})")))
				.AddCase(GenerateOtherSwitchCase(p))
				.ToString()
				.WrapInAwaitConfiguredFromParameterIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType))}");

	private static string GenerateLastArgument(MatchMethodGenerationParams p)
	{
		var tResultWrapped = "TResult".WrapInTaskIf(p.IsAsync(UnionMethodAsyncConfig.AppliedMethodReturnType));
		return p.OtherCaseSize <= 1
			? $"Func<{p.Ts().Last()}, {tResultWrapped}> {p.ElementTypeNamesLowerCamelCase().Last()}"
			: $"Func<{p.UnionOfTsOtherCase()}, {tResultWrapped}> other";
	}

	private static SwitchCaseText GenerateOtherSwitchCase(MatchMethodGenerationParams p) => p.OtherCaseSize <= 1
		? new SwitchCaseText("_", $"{p.ElementTypeNamesLowerCamelCase().Last()}(u.Value{p.UnionSize - 1})")
		: new SwitchCaseText("_", $"other(new {p.UnionOfTsOtherCase()}(u.Value))");

	private static string UnionOfTsOtherCase(this MatchMethodGenerationParams p) =>
		$"Union<{string.Join(", ", p.Ts().Skip(p.UnionSize - p.OtherCaseSize).Take(p.OtherCaseSize))}>";

	private static IEnumerable<string> ElementTypeNamesLowerCamelCase(this MatchMethodGenerationParams p) =>
		p.ElementTypeNamesGenerator()
			.Select(typeName => $"{char.ToLower(typeName[0])}{typeName[1..]}")
			.Select(typeName => char.IsDigit(typeName[0]) ? $"t{typeName}" : typeName);
}