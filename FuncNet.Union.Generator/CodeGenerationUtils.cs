using System.Linq.Expressions;

namespace FuncNet.Union.Generator;

public static class CodeGenerationUtils
{
	public static string JoinToString<T>(this IEnumerable<T> range, string separator, Func<T, string> toString) =>
		string.Join(separator, range.Select(toString));

	public static string JoinRangeToString(string separator, int start, int count, Func<int, string> toString) =>
		count < 0 ? string.Empty
			: JoinToString(Enumerable.Range(start, count), separator, toString);

	public static string JoinRangeToString(string separator, int count, Func<int, string> toString) =>
		JoinRangeToString(separator, 0, count, toString);

	public static string CommaSeparatedTs(int start, int count) =>
		JoinRangeToString(", ", start, count, i => $"T{i}");

	public static string CommaSeparatedTs(int count) =>
		CommaSeparatedTs(0, count);

	public static string GenerateSwitchExpression(string switchOn, IEnumerable<SwitchCaseText> cases) => $@"
	{switchOn} switch
	{{
		{cases.JoinToString(",\n\t\t", @case => $"{@case.Left} => {@case.Right}")}
	}}";

	public delegate string WrapText(string text);
	public static string DontWrap(string text) => text;
	public static string WrapInTask(string text) => $"Task<{text}>";
	public static string WrapInTaskFromResult(string text) => $"Task.FromResult({text})";
	public static string WrapInAsyncTask(string text) => $"async {WrapInTask(text)}";
	public static string WrapInAwaitConfiguredFromArgument(string text) =>
		$"await ({text}).ConfigureAwait(continueOnCapturedContext)";

	public const string ASYNC_METHOD_ADDITIONAL_ARGUMENTS =
		$",\n\t\tCancellationToken cancellationToken = default,\n\t\tbool continueOnCapturedContext = true";

	public readonly record struct SwitchCase(int Index, string Variable, string Value);
	public readonly record struct SwitchCaseOneSpecial(int Index, string Variable, int SpecialIndex);
	public readonly record struct SwitchCaseText(string Left, string Right);

	public delegate SwitchCaseText GenerateSwitchCaseOneSpecial(SwitchCaseOneSpecial @case);
}
