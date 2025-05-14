using System.Linq.Expressions;
using System.Text;

namespace FuncNet.Union.Generator;

internal static class CodeGenerationUtils
{
	private static string JoinToString<T>(this IEnumerable<T> range, string separator, Func<T, string> toString) =>
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

	public sealed class SourceCodeFileBuilder
	{
		private const string DELIMITER = "\n\t\t";
		
		private readonly StringBuilder builder = new();

		public SourceCodeFileBuilder(string header)
		{
			builder.Append(header).Append(DELIMITER);
		}

		public SourceCodeFileBuilder AddClass(ClassBuilder classBuilder)
		{
			builder.Append(classBuilder).Append(DELIMITER);
			return this;
		}

		public override string ToString() => builder.ToString();
	}

	public sealed class ClassBuilder
	{
		private readonly string className;

		private readonly List<MethodBuilder> methods = [];
		
		public ClassBuilder(string className)
		{
			this.className = className;
		}

		public ClassBuilder AddMethod(MethodBuilder method)
		{
			methods.Add(method);
			return this;
		}

		public ClassBuilder AddMethods(IEnumerable<MethodBuilder> methods)
		{
			this.methods.AddRange(methods);
			return this;
		}

		public override string ToString() => $"{className}\n{{{string.Join("\n\n\t", methods)}}}";
	}

	public sealed class StatementsBlockBuilder
	{
		private const string DELIMITER = "\n\t\t";
		
		private readonly StringBuilder builder = new();

		public StatementsBlockBuilder AddStatement(string statement)
		{
			builder.Append(statement).Append(';').Append(DELIMITER).Append('\t');
			return this;
		}

		public override string ToString() => $"{{{DELIMITER}{builder}{DELIMITER}}}";
	}

	public sealed class MethodBuilder
	{
		private readonly string name;
		private readonly ArgumentListBuilder argumentList = new();
		private readonly StatementsBlockBuilder body = new();

		public MethodBuilder(string name)
		{
			this.name = name;
		}

		public MethodBuilder AddArgument(string argument)
		{
			argumentList.AddArgument(argument);
			return this;
		}

		public MethodBuilder AddArguments(IEnumerable<string> arguments)
		{
			argumentList.AddArguments(arguments);
			return this;
		}

		public MethodBuilder AddBodyStatement(string statement)
		{
			body.AddStatement(statement);
			return this;
		}

		public override string ToString() => $"{name}{argumentList}{body}";
	}
	
	public sealed class ArgumentListBuilder
	{
		private const string DELIMITER = ",\n\t\t";

		private readonly List<string> arguments = [];

		public ArgumentListBuilder AddArgument(string argument)
		{
			arguments.Add(argument);
			return this;
		}

		public ArgumentListBuilder AddArguments(IEnumerable<string> arguments)
		{
			this.arguments.AddRange(arguments);
			return this;
		}

		public override string ToString() => $"({string.Join(DELIMITER, arguments)})";
	}
	
	public delegate string WrapText(string text);
	public static string DontWrap(string text) => text;
	public static string WrapInTask(string text) => $"Task<{text}>";
	public static string WrapInTaskFromResult(string text) => $"Task.FromResult({text})";
	public static string WrapInAsyncTask(string text) => $"async {WrapInTask(text)}";
	public static string WrapInAwaitConfiguredFromParameter(string text) =>
		$"await ({text}).ConfigureAwait(continueOnCapturedContext)";
	
	public static string WrapInTaskIf(this string text, bool shouldWrap) =>
		shouldWrap ? WrapInTask(text) : text;

	public static string WrapInTaskFromResultIf(this string text, bool shouldWrap) =>
		shouldWrap ? WrapInTaskFromResult(text) : text;
	
	public static string WrapInAsyncTaskIf(this string text, bool shouldWrap) =>
		shouldWrap ? WrapInAsyncTask(text) : text;

	public static string WrapInAwaitConfiguredFromParameterIf(this string text, bool shouldWrap) =>
		shouldWrap ? WrapInAwaitConfiguredFromParameter(text) : text;
	
	public static readonly string[] asyncMethodAdditionalArguments =
	[
		"CancellationToken cancellationToken = default",
		"bool continueOnCapturedContext = true"
	];

	public static readonly string asyncMethodAdditionalArgumentsJoined =
		$",\n\t\t{string.Join(",\n\t\t", asyncMethodAdditionalArguments)}";

	public const string THROW_IF_CANCELED = "cancellationToken.ThrowIfCancellationRequested()";

	public readonly record struct SwitchCase(int Index, string Variable, string Value);
	public readonly record struct SwitchCaseOneSpecial(int Index, string Variable, int SpecialIndex);
	public readonly record struct SwitchCaseText(string Left, string Right);

	private static IEnumerable<string> TsWithSpecialReplacement(int count, int specialIndex, string specialReplacement) =>
		Enumerable.Range(0, count).Select(i => i == specialIndex ? specialReplacement : $"T{i}");

	private static string CommaSeparatedTsWithSpecialReplacement(int count, int specialIndex, string specialReplacement) =>
		string.Join(", ", TsWithSpecialReplacement(count, specialIndex, specialReplacement));

	public static string TsOld(int count, int specialIndex) =>
		CommaSeparatedTsWithSpecialReplacement(count, specialIndex, $"T{specialIndex}Old");

	public static string WrapInNewUnionFromT(this string value, SwitchCaseOneSpecial @case, int unionSize) =>
		$"{UnionOfTsOneNew(unionSize, @case.SpecialIndex)}.FromT{@case.Index}({value})";

	public static string WrapInNewUnionFromTIfNotSpecial(this string value, SwitchCaseOneSpecial @case, int unionSize) =>
		@case.SpecialIndex == @case.Index ? value : value.WrapInNewUnionFromT(@case, unionSize);

	public static string UnionOfTs(int unionSize) => $"Union<{CommaSeparatedTs(unionSize)}>";
	public static string UnionOfTs(int start, int count) => $"Union<{CommaSeparatedTs(start, count)}>";
	private static string UnionOfTsOneSpecial(int unionSize, int specialIndex, string specialReplacement) =>
		$"Union<{CommaSeparatedTsWithSpecialReplacement(unionSize, specialIndex, specialReplacement)}>";
	public static string UnionOfTsOneNew(int unionSize, int newIndex) =>
		UnionOfTsOneSpecial(unionSize, newIndex, $"T{newIndex}New");
	public static string UnionOfTsOneOld(int unionSize, int oldIndex) =>
		UnionOfTsOneSpecial(unionSize, oldIndex, $"T{oldIndex}Old");

	[Flags]
	public enum UnionMethodAsyncConfig
	{
		None = 0,
		All = ~0,
		ReturnType = 1 << 0,
		InputUnion = 1 << 1,
		AppliedMethodReturnType = 1 << 2,
	}
}
