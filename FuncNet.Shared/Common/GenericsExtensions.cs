using System.Text.RegularExpressions;
using FuncNet.Shared.Config;

namespace FuncNet.Shared.Common;

public static class GenericsExtensions
{
	private static readonly Regex genericsUnwrapRegex = new(".*?<(.*)>", RegexOptions.Compiled);
	private static readonly Regex taskUnwrapRegex = new("(?:^<)*?Task<(.*)>", RegexOptions.Compiled);

	public static string UnwrapGenericArgs(this string typeName)
	{
		var match = genericsUnwrapRegex.Match(typeName);
		return match.Success ? match.Groups[1].Value : typeName;
	}

	public static string UnwrapTaskGenericArg(this string typeName)
	{
		var match = taskUnwrapRegex.Match(typeName);
		return match.Success ? match.Groups[1].Value : typeName;
	}

	public static string FormatGenericsToDisplayString(this IEnumerable<GenericArguments> genericEntries) =>
		$"{string.Join(" and ", genericEntries.Select(generics => $"<{generics.CommaSeparatedArguments}>"))}";
}