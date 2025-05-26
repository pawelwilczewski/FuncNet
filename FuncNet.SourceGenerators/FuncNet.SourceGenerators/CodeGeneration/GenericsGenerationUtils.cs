namespace FuncNet.Generator.CodeGeneration;

using static StringJoinUtils;

internal static class GenericsGenerationUtils
{
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
}

public delegate string GenerateGenericTypeNameForTIndex(int tIndex);