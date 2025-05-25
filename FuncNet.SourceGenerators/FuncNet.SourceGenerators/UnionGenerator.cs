using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace FuncNet.SourceGenerators;

[Generator]
public sealed class UnionGenerator : ISourceGenerator
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
		_ => throw new ArgumentOutOfRangeException(nameof(Index))
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
			default: throw new ArgumentOutOfRangeException(nameof(value));
		}}
	}}

	{JoinRangeToString("\n\t", unionSize, i =>
		$"public static {UnionOfTs(unionSize)} FromT{i}(T{i} value) => value;")}

	{JoinRangeToString("\n\t", unionSize, i =>
		$"public static async Task<{UnionOfTs(unionSize)}> FromT{i}(Task<T{i}> value) => await value;")}

	{JoinRangeToString("\n\t", unionSize, i =>
		$@"public static implicit operator {UnionOfTs(unionSize)}(T{i} value) =>
		new {UnionOfTs(unionSize)}({i}, value{i}: value);")}
}}";

	private static string JoinToString<T>(IEnumerable<T> range, string separator, Func<T, string> toString) =>
		string.Join(separator, range.Select(toString));

	public static string JoinRangeToString(string separator, int start, int count, Func<int, string> toString) =>
		count < 0 ? string.Empty : JoinToString(Enumerable.Range(start, count), separator, toString);

	public static string JoinRangeToString(string separator, int count, Func<int, string> toString) =>
		JoinRangeToString(separator, 0, count, toString);

	public static string CommaSeparatedTs(int start, int count) =>
		JoinRangeToString(", ", start, count, i => $"T{i}");

	private static string CommaSeparatedErrorTs(int count) =>
		CommaSeparatedErrorTs(0, count);

	private static string CommaSeparatedErrorTs(int start, int count) =>
		string.Join(", ", Enumerable.Range(start, count).Select(i => $"TError{i}"));

	public static string UnionOfTs(int unionSize) => UnionOfTs(0, unionSize);
	public static string UnionOfTs(int start, int count) => $"Union<{CommaSeparatedTs(start, count)}>";

	public static string ResultOfTs(int unionSize) => $"Result<{ResultTs(unionSize)}>";

	public static string ResultTs(int count) => count < 2
		? throw new ArgumentOutOfRangeException(nameof(count))
		: $"TSuccess, {CommaSeparatedErrorTs(count - 1)}";

	public static string ResultBackingUnion(int unionSize) => $"Union<{ResultTs(unionSize)}>";

	public void Initialize(GeneratorInitializationContext context) { }

	public void Execute(GeneratorExecutionContext context)
	{
		for (var i = 1; i < 9; ++i)
		{
			context.AddSource($"Union{i}", GenerateUnionFile("FuncNet", i));
		}
	}
}