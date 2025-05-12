namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

public static class UnionGenerator
{
	public static string GenerateUnionFile(string @namespace, int unionSize) => $@"
{GenerateUnionHeader(@namespace)}
{GenerateUnionClass(unionSize)}
";

	private static string GenerateUnionHeader(string namespaceName) => $@"
using System;
using System.Threading.Tasks;

#nullable enable

namespace {namespaceName};
";

	private static string GenerateUnionClass(int unionSize) => $@"
public readonly record struct Union<{CommaSeparatedTs(unionSize)}>
{{
	{JoinRangeToString("\n\t", unionSize, i => $"internal T{i} Value{i} {{ get; init; }}")}

	internal int Index {{ get; init; }}

	{JoinRangeToString("\n\t", unionSize, i => $"public bool Is{i} => Index == {i};")}

	internal object? Value => Index switch
	{{
		{JoinRangeToString(",\n\t\t", unionSize, i => $"{i} => Value{i}")},
		_ => throw new Unreachable()
	}};

	public Union() => throw new InvalidOperationException();

	private Union(int index, {JoinRangeToString(", ", unionSize, i => $"T{i}? value{i} = default")})
	{{
		Index = index;
		{JoinRangeToString("\n\t\t", unionSize, i => $"Value{i} = value{i}!;")}
	}}

	internal Union(object? value) : this(-1)
	{{
		switch (value)
		{{
			{JoinRangeToString("\n\t\t\t", unionSize, i => $"case T{i} matchedValue: Value{i} = matchedValue; Index = {i}; break;")}
			default: throw new Unreachable();
		}}
	}}

	{JoinRangeToString("\n\t", unionSize, i =>
		$@"public static implicit operator Union<{CommaSeparatedTs(unionSize)}>(T{i} value) =>
		new Union<{CommaSeparatedTs(unionSize)}>({i}, value{i}: value);")}

	{JoinRangeToString("\n\t", 1, unionSize - 1, otherUnionSize =>
		$@"public static implicit operator Union<{CommaSeparatedTs(unionSize)}>(Union<{CommaSeparatedTs(otherUnionSize)}> other) =>
		new Union<{CommaSeparatedTs(unionSize)}>(other.Index, {JoinRangeToString(", ", otherUnionSize, i => $"other.Value{i}")});")}

	{JoinRangeToString("\n\t", unionSize, i =>
		$"public static Union<{CommaSeparatedTs(unionSize)}> FromT{i}(T{i} value) => value;")}

	{JoinRangeToString("\n\t", unionSize, i =>
		$"public static async Task<Union<{CommaSeparatedTs(unionSize)}>> FromT{i}(Task<T{i}> value) => await value;")}
}}
";
}