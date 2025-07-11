namespace FuncNet.CodeGeneration;

using static StringJoinUtils;

internal static class GenericsGenerationUtils
{
	public static string TsCommaSeparated(int start, int count) =>
		JoinRangeToString(", ", start, count, i => $"T{i}");

	private static string ErrorTsCommaSeparated(int count) =>
		ErrorTsCommaSeparated(0, count);

	private static string ErrorTsCommaSeparated(int start, int count) =>
		Enumerable.Range(start, count).Select(i => $"TError{i}").CommaSeparated();

	public static string UnionOfTs(int unionSize) => UnionOfTs(0, unionSize);
	public static string UnionOfTs(int start, int count) => $"Union<{TsCommaSeparated(start, count)}>";

	public static string ResultOfTs(int unionSize) => $"Result<{ResultTs(unionSize)}>";

	public static string ResultTs(int count) => count < 2
		? throw new ArgumentOutOfRangeException(nameof(count))
		: $"TSuccess, {ErrorTsCommaSeparated(count - 1)}";

	public static string ResultBackingUnion(int unionSize) => $"Union<{ResultTs(unionSize)}>";
}

public delegate string GenerateGenericTypeNameForTIndex(int tIndex);