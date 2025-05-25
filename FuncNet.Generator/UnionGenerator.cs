using System.Collections.Immutable;
using FuncNet.Generator.CodeGeneration;

namespace FuncNet.Generator;

using static GenericsGenerationUtils;
using static StringJoinUtils;

public static class UnionGenerator
{
	private static readonly Lock lockObj = new();

	public static string GenerateUnionFile(string @namespace, int unionSize) =>
		$@"using System;
using System.Threading.Tasks;

#nullable enable

namespace {@namespace};

public readonly record struct {UnionOfTs(unionSize)}
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
		$"public static {UnionOfTs(unionSize)} FromT{i}(T{i} value) => value;")}

	{JoinRangeToString("\n\t", unionSize, i =>
		$"public static async Task<{UnionOfTs(unionSize)}> FromT{i}(Task<T{i}> value) => await value;")}

	{JoinRangeToString("\n\t", unionSize, i =>
		$@"public static implicit operator {UnionOfTs(unionSize)}(T{i} value) =>
		new {UnionOfTs(unionSize)}({i}, value{i}: value);")}

	{GenerateAllPermutedImplicitConversions(unionSize)}
}}";

	private static string GenerateAllPermutedImplicitConversions(int unionSize)
	{
		var unionIndices = Enumerable.Range(0, unionSize).ToImmutableArray();
		var conversions = Enumerable.Range(2, unionSize - 1)
			.SelectMany(permutationSize =>
			{
				var permutations = GeneratePermutations(unionIndices, permutationSize);
				return permutationSize > 4 ? permutations.Take(1) : permutations;
			})
			.Where(permutation => permutation.Length != unionSize || !permutation.SequenceEqual(unionIndices))
			.Select(permutation => GeneratePermutedImplicitConversion(unionSize, permutation));

		return string.Join("\n\t", conversions);
	}

	private static string GeneratePermutedImplicitConversion(int unionSize, int[] permutation)
	{
		var sourceTypes = string.Join(", ", permutation.Select(i => $"T{i}"));

		var valueMapping = string.Join(", ", Enumerable.Range(0, permutation.Length)
			.Select(i => $"value{permutation[i]}: other.Value{i}"));

		return $@"public static implicit operator {UnionOfTs(unionSize)}(Union<{sourceTypes}> other) =>
		new {UnionOfTs(unionSize)}(other.Value);";
	}

	private static IEnumerable<T[]> GeneratePermutations<T>(IImmutableList<T> list, int length)
	{
		if (length == 1) return list.Select(t => new[] { t });

		return GeneratePermutations(list, length - 1)
			.SelectMany(
				t => list.Where(o => !t.Contains(o)),
				(t1, t2) => t1.Concat([t2]).ToArray());
	}
}