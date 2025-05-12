namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

public static class UnionGenerator
{
	public static string GenerateUnionFile(string namespaceName, int choiceCount) => $@"
{GenerateUnionHeader(namespaceName)}
{GenerateUnionClass(choiceCount)}
";

	private static string GenerateUnionHeader(string namespaceName) => $@"
using System;
using System.Threading.Tasks;

#nullable enable

namespace {namespaceName};
";

	private static string GenerateUnionClass(int choiceCount) => $@"
public readonly record struct Union<{CommaSeparatedTs(choiceCount)}>
{{
	{JoinRangeToString("\n\t", choiceCount, i => $"internal T{i} Value{i} {{ get; init; }}")}

	internal int Index {{ get; init; }}

	{JoinRangeToString("\n\t", choiceCount, i => $"public bool Is{i} => Index == {i};")}

	public Union() => throw new InvalidOperationException();

	private Union(int index, {JoinRangeToString(", ", choiceCount, i => $"T{i}? value{i} = default")})
	{{
		Index = index;
		{JoinRangeToString("\n\t\t", choiceCount, i => $"Value{i} = value{i}!;")}
	}}

	{JoinRangeToString("\n\t", choiceCount, i =>
		$@"public static implicit operator Union<{CommaSeparatedTs(choiceCount)}>(T{i} value) =>
		new Union<{CommaSeparatedTs(choiceCount)}>({i}, value{i}: value);")}

	{JoinRangeToString("\n\t", choiceCount, i =>
		$"public static Union<{CommaSeparatedTs(choiceCount)}> FromT{i}(T{i} value) => value;")}
	{JoinRangeToString("\n\t", choiceCount, i =>
		$"public static async Task<Union<{CommaSeparatedTs(choiceCount)}>> FromT{i}(Task<T{i}> value) => await value;")}
}}
";
}