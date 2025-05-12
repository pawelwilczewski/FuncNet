using System.Reflection;

var text = UnionGenerator.GenerateUnionFile("FuncNet.Union", 3);
var path = Path.Join(Path.GetFullPath(Assembly.GetExecutingAssembly().Location!), "/../../../../../FuncNet.Union", "Union3.g.cs");

File.WriteAllText(path, text);

public static class UnionGenerator
{
	public static string GenerateUnionFile(string namespaceName, int choiceCount) => $@"
{GenerateUnionHeader(namespaceName)}
{GenerateUnionClass(choiceCount)}
";

	private static string GenerateUnionHeader(string namespaceName) => $@"
#nullable enable

namespace {namespaceName};
";

	private static string GenerateUnionClass(int choiceCount) => $@"
public readonly record struct Union<{JoinRangeToString(choiceCount, i => $"T{i}", ", ")}>
{{
	{JoinRangeToString(choiceCount, i => $"internal T{i}? Value{i} {{ get; init; }}", "\n")}

	internal int Index {{ get; init; }}
}}
";

	private static string JoinToString<T>(this IEnumerable<T> range, Func<T, string> toString, string separator) =>
		string.Join(separator, range.Select(toString));
	
	private static string JoinRangeToString(int start, int count, Func<int, string> toString, string separator) =>
		JoinToString(Enumerable.Range(start, count), toString, separator);

	private static string JoinRangeToString(int count, Func<int, string> toString, string separator) =>
		JoinRangeToString(0, count, toString, separator);
}
