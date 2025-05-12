namespace FuncNet.Union.Generator;

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
	{JoinRangeToString("\n", choiceCount, i => $"internal T{i} Value{i} {{ get; init; }}")}

	internal int Index {{ get; init; }}

{JoinRangeToString("\n", choiceCount, i => $"public bool Is{i} => Index == {i};")}

public Union() => throw new InvalidOperationException();

private Union(int index, {JoinRangeToString(", ", choiceCount, i => $"T{i}? value{i} = default")})
{{
	Index = index;
	{JoinRangeToString("\n", choiceCount, i => $"Value{i} = value{i}!;")}
}}

{JoinRangeToString("\n", choiceCount, i => $@"public static implicit operator Union<{CommaSeparatedTs(choiceCount)}>(T{i} value) =>
new Union<{CommaSeparatedTs(choiceCount)}>({i}, value{i}: value);")}

{JoinRangeToString("\n", choiceCount, i => $"public static Union<{CommaSeparatedTs(choiceCount)}> FromT{i}(T{i} value) => value;")}
{JoinRangeToString("\n", choiceCount, i => $"public static async Task<Union<{CommaSeparatedTs(choiceCount)}>> FromT{i}(Task<T{i}> value) => await value;")}
}}
";

	private static string JoinToString<T>(this IEnumerable<T> range, string separator, Func<T, string> toString) =>
		string.Join(separator, range.Select(toString));

	private static string JoinRangeToString(string separator, int start, int count, Func<int, string> toString) =>
		JoinToString(Enumerable.Range(start, count), separator, toString);

	private static string JoinRangeToString(string separator, int count, Func<int, string> toString) =>
		JoinRangeToString(separator, 0, count, toString);

	private static string CommaSeparatedTs(int count) =>
		JoinRangeToString(", ", count, i => $"T{i}");
}