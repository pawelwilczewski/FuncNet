namespace FuncNet.Union.Generator.CodeGeneration;

internal static class StringJoinUtils
{
	private static string JoinToString<T>(this IEnumerable<T> range, string separator, Func<T, string> toString) =>
		string.Join(separator, range.Select(toString));

	public static string JoinRangeToString(string separator, int start, int count, Func<int, string> toString) =>
		count < 0 ? string.Empty : JoinToString(Enumerable.Range(start, count), separator, toString);

	public static string JoinRangeToString(string separator, int count, Func<int, string> toString) =>
		JoinRangeToString(separator, 0, count, toString);
}