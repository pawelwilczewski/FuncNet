using System.Text;

namespace FuncNet.Union.Generator;

internal static class CodeGenerationUtils
{
	public const string THROW_IF_CANCELED = "cancellationToken.ThrowIfCancellationRequested()";

	public static readonly string[] asyncMethodAdditionalArguments =
	[
		"CancellationToken cancellationToken = default"
	];

	public static readonly UnionMethodAsyncConfig[] allPossibleAsyncMethodConfigs =
	[
		UnionMethodAsyncConfig.None,
		UnionMethodAsyncConfig.All,
		UnionMethodAsyncConfig.ReturnType | UnionMethodAsyncConfig.AppliedMethodReturnType,
		UnionMethodAsyncConfig.ReturnType | UnionMethodAsyncConfig.InputUnion
	];

	private static string JoinToString<T>(this IEnumerable<T> range, string separator, Func<T, string> toString) =>
		string.Join(separator, range.Select(toString));

	public static string JoinRangeToString(string separator, int start, int count, Func<int, string> toString) =>
		count < 0 ? string.Empty : JoinToString(Enumerable.Range(start, count), separator, toString);

	public static string JoinRangeToString(string separator, int count, Func<int, string> toString) =>
		JoinRangeToString(separator, 0, count, toString);

	public static string CommaSeparatedTs(int start, int count) =>
		JoinRangeToString(", ", start, count, i => $"T{i}");

	public static string DontWrap(string text) => text;
	public static string WrapInTask(string text) => $"Task<{text}>";
	public static string WrapInTaskFromResult(string text) => $"Task.FromResult({text})";
	public static string WrapInAsyncTask(string text) => $"async {WrapInTask(text)}";

	public static string WrapInAwaitConfigured(string text) =>
		$"await ({text}).ConfigureAwait(false)";

	public static string WrapInTaskIf(this string text, bool shouldWrap) =>
		shouldWrap ? WrapInTask(text) : text;

	public static string WrapInTaskFromResultIf(this string text, bool shouldWrap) =>
		shouldWrap ? WrapInTaskFromResult(text) : text;

	public static string WrapInAsyncTaskIf(this string text, bool shouldWrap) =>
		shouldWrap ? WrapInAsyncTask(text) : text;

	public static string WrapInAwaitConfiguredFromParameterIf(this string text, bool shouldWrap) =>
		shouldWrap ? WrapInAwaitConfigured(text) : text;

	public static string UnionOfTs(int unionSize) => UnionOfTs(0, unionSize);
	public static string UnionOfTs(int start, int count) => $"Union<{CommaSeparatedTs(start, count)}>";

	private static string CommaSeparatedErrorTs(int count) =>
		CommaSeparatedErrorTs(0, count);

	private static string CommaSeparatedErrorTs(int start, int count) =>
		string.Join(", ", Enumerable.Range(start, count).Select(i => $"TError{i}"));

	public static string ResultOfTs(int unionSize) => $"Result<{ResultTs(unionSize)}>";

	public static string ResultTs(int count) => count < 2
		? throw new ArgumentOutOfRangeException(nameof(count))
		: $"TSuccess, {CommaSeparatedErrorTs(count - 1)}";

	public static string ResultUnion(int unionSize) => $"Union<{ResultTs(unionSize)}>";

	public delegate string WrapText(string text);
}

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

	public ClassBuilder(string className) => this.className = className;

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

public readonly record struct SwitchCase(int Index, string Identifier);

public readonly record struct SwitchCaseText(string Left, string Right);

public sealed class SwitchExpressionBuilder
{
	private const string DELIMITER = "\n\t\t";

	private readonly StringBuilder builder = new();

	public SwitchExpressionBuilder(string switchOnIdentifier)
	{
		builder.Append($"{switchOnIdentifier} switch{DELIMITER}{{{DELIMITER}\t");
	}

	public SwitchExpressionBuilder AddCase(SwitchCaseText @case)
	{
		builder.Append($"{@case.Left} => {@case.Right},").Append(DELIMITER).Append('\t');
		return this;
	}

	public SwitchExpressionBuilder AddCases(IEnumerable<SwitchCaseText> cases)
	{
		foreach (var @case in cases)
		{
			AddCase(@case);
		}

		return this;
	}

	public override string ToString() => $"{builder}}}";
}

public sealed class MethodBuilder
{
	private readonly string name;
	private readonly ArgumentListBuilder argumentList = new();
	private readonly StatementsBlockBuilder body = new();

	public MethodBuilder(string name) => this.name = name;

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

internal static class MethodBuilderExtensions
{
	public static MethodBuilder AddAsyncArgumentsIfAsync(this MethodBuilder methodBuilder, MethodGenerationParams p) =>
		methodBuilder.AddArguments(p.IsAsync(UnionMethodAsyncConfig.ReturnType) ? CodeGenerationUtils.asyncMethodAdditionalArguments : []);

	public static MethodBuilder AddThrowIfCanceledStatementIfAsync(this MethodBuilder methodBuilder, MethodGenerationParams p) =>
		methodBuilder.AddBodyStatement(p.IsAsync(UnionMethodAsyncConfig.ReturnType) ? CodeGenerationUtils.THROW_IF_CANCELED : "");
}

internal sealed record class UnionExtensionMethodsFileGenerationParams(
	string Namespace,
	string ExtendedTypeName,
	string MethodNameOnly,
	int UnionSize,
	GenerateAllMethods GenerateAllMethods,
	string ThisArgumentName,
	Func<IEnumerable<string>> ElementTypeNamesGenerator,
	UnionGetter GetUnionOnArgument,
	FactoryMethodNameForTIndex FactoryMethodName)
{
	public string FileName => $"{ExtendedTypeName}{UnionSize}.{MethodNameOnly}.g.cs";
}

internal delegate IEnumerable<MethodBuilder> GenerateAllMethods(UnionExtensionMethodsFileGenerationParams p);

internal record class MethodGenerationParams(
	string ExtendedTypeName,
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig,
	string ThisArgumentName,
	UnionGetter GetUnionOnArgument,
	Func<IEnumerable<string>> ElementTypeNamesGenerator)
{
	public bool IsAsync(UnionMethodAsyncConfig typeToCheck) => (typeToCheck & AsyncConfig) != 0;
}

internal record class MethodGenerationParamsWithSpecialIndex(
	string ExtendedTypeName,
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig,
	string ThisArgumentName,
	Func<IEnumerable<string>> ElementTypeNamesGenerator,
	UnionGetter GetUnionOnArgument,
	FactoryMethodNameForTIndex FactoryMethodName,
	int SpecialIndex) : MethodGenerationParams(ExtendedTypeName, MethodNameOnly, UnionSize, AsyncConfig, ThisArgumentName, GetUnionOnArgument, ElementTypeNamesGenerator);

internal delegate string FactoryMethodNameForTIndex(int tIndex);

internal sealed record class MethodGenerationParamsWithOtherCaseSize(
	string ExtendedTypeName,
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig,
	string ThisArgumentName,
	UnionGetter GetUnionOnArgument,
	Func<IEnumerable<string>> ElementTypeNamesGenerator,
	int OtherCaseSize) : MethodGenerationParams(ExtendedTypeName, MethodNameOnly, UnionSize, AsyncConfig, ThisArgumentName, GetUnionOnArgument, ElementTypeNamesGenerator);

internal delegate string UnionGetter(string argument);

[Flags]
public enum UnionMethodAsyncConfig
{
	None = 0,
	All = ~0,
	ReturnType = 1 << 0,
	InputUnion = 1 << 1,
	AppliedMethodReturnType = 1 << 2
}

internal static class MethodGenerationParamsExtensions
{
	public static IEnumerable<string> Ts(this MethodGenerationParams p) =>
		p.ElementTypeNamesGenerator().Select(t => $"T{t}");

	public static string TsCommaSeparated(this MethodGenerationParams p) =>
		string.Join(", ", p.Ts());

	public static string TsCommaSeparatedWithSpecialReplacement(this MethodGenerationParamsWithSpecialIndex p, Func<string, string> replaceSpecial) =>
		string.Join(", ", p.Ts().Select((t, index) => index == p.SpecialIndex ? replaceSpecial(t) : t));

	public static string TsCommaSeparatedNew(this MethodGenerationParamsWithSpecialIndex p) =>
		p.TsCommaSeparatedWithSpecialReplacement(t => $"{t}New");

	public static string TsCommaSeparatedOld(this MethodGenerationParamsWithSpecialIndex p) =>
		p.TsCommaSeparatedWithSpecialReplacement(t => $"{t}Old");

	public static string ExtendedTypeOfTs(this MethodGenerationParams p) =>
		$"{p.ExtendedTypeName}<{p.TsCommaSeparated()}>";

	public static string ExtendedTypeOfTsNew(this MethodGenerationParamsWithSpecialIndex p) =>
		$"{p.ExtendedTypeName}<{p.TsCommaSeparatedNew()}>";

	public static string ExtendedTypeOfTsOld(this MethodGenerationParamsWithSpecialIndex p) =>
		$"{p.ExtendedTypeName}<{p.TsCommaSeparatedOld()}>";

	public static string WrapInNewExtendedTypeFromT(this string value, SwitchCase @case, MethodGenerationParamsWithSpecialIndex p) =>
		$"{p.ExtendedTypeOfTsNew()}.{p.FactoryMethodName(@case.Index)}({value})";

	public static string WrapInNewExtendedTypeFromTIfNotSpecial(this string value, SwitchCase @case, MethodGenerationParamsWithSpecialIndex p) =>
		p.SpecialIndex == @case.Index ? value : value.WrapInNewExtendedTypeFromT(@case, p);
}