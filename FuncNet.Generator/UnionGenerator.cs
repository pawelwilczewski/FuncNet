using FuncNet.Generator.CodeGeneration;

namespace FuncNet.Generator;

using static GenericsGenerationUtils;
using static StringJoinUtils;

public static class UnionGenerator
{
	public static string GenerateUnionFile(string @namespace, int unionSize) =>
		$@"using System;
using System.Threading.Tasks;

#nullable enable

namespace {@namespace};

public readonly partial record struct {UnionOfTs(unionSize)}
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
		$@"public static implicit operator {UnionOfTs(unionSize)}(T{i} value) =>
		new {UnionOfTs(unionSize)}({i}, value{i}: value);")}

	{JoinRangeToString("\n\t", unionSize, i =>
		$"public static {UnionOfTs(unionSize)} FromT{i}(T{i} value) => value;")}

	{JoinRangeToString("\n\t", unionSize, i =>
		$"public static async Task<{UnionOfTs(unionSize)}> FromT{i}(Task<T{i}> value) => await value;")}
}}";
}