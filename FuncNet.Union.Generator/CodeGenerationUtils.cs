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

	public static readonly string[] asyncMethodAdditionalArguments =
	[
		"CancellationToken cancellationToken = default",
		"bool continueOnCapturedContext = true"
	];
	
	public static readonly string asyncMethodAdditionalArgumentsJoined =
		$",\n\t\t{string.Join(",\n\t\t", asyncMethodAdditionalArguments)}";

	public readonly record struct SwitchCase(int Index, string Variable, string Value);
	public readonly record struct SwitchCaseOneSpecial(int Index, string Variable, int SpecialIndex);
	public readonly record struct SwitchCaseText(string Left, string Right);

	public delegate SwitchCaseText GenerateSwitchCaseOneSpecial(SwitchCaseOneSpecial @case);

	public static string GeneratePublicStaticMethod(
		string returnType,
		string name,
		IEnumerable<string> arguments,
		string body) => @$"
	public static {returnType} {name}(
		{string.Join(",\n\t\t", arguments)})
	{{
		{body}
	}}";
}
