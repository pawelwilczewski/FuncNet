namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

public static class MatchGenerator
{
	public static string GenerateMatchExtensionsFile(string @namespace, int unionSize) => $@"
using System;
using System.Threading.Tasks;

#nullable enable

namespace {@namespace};

public static class Union{unionSize}Match
{{
	{GenerateOtherCaseAsUnionVariants(unionSize)}
}}
";

	private static string GenerateOtherCaseAsUnionVariants(int unionSize) =>
		JoinRangeToString("\n\n\t", 1, unionSize - 1, otherCaseSize => $@"
	public static TResult Match<TResult, {CommaSeparatedTs(unionSize)}>(
		this Union<{CommaSeparatedTs(unionSize)}> union,
		{JoinRangeToString(",\n\t\t", unionSize - otherCaseSize, i => $"Func<T{i}, TResult> t{i}")},
		{GenerateLastArgumentCode(unionSize, otherCaseSize)})
	{{
		var u = union;

		return u.Index switch
		{{
			{JoinRangeToString(",\n\t\t\t", unionSize - otherCaseSize, i => $"{i} => t{i}(u.Value{i})")},
			{GenerateLastSwitchCaseCode(unionSize, otherCaseSize)}
		}};
	}}");

	private static string GenerateLastArgumentCode(int unionSize, int caseSize) => caseSize <= 1
		? $"Func<T{unionSize - 1}, TResult> t{unionSize - 1}"
		: $"Func<Union<{CommaSeparatedTs(unionSize - caseSize, caseSize)}>, TResult> other";

	private static string GenerateLastSwitchCaseCode(int unionSize, int caseSize) => caseSize <= 1
		? $"_ => t{unionSize - 1}(u.Value{unionSize - 1})"
		: $"_ => other(new Union<{CommaSeparatedTs(unionSize - caseSize, caseSize)}>(u.Value))";
}