namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

public static class MatchGenerator
{
	public static string GenerateMatchExtensionsFile(string @namespace, int unionSize) => $@"
{GenerateMatchExtensionsHeader(@namespace)}
{GenerateMatchExtensions(unionSize)}
";

	private static string GenerateMatchExtensionsHeader(string namespaceName) => $@"
using System;
using System.Threading.Tasks;

#nullable enable

namespace {namespaceName};
";

	private static string GenerateMatchExtensions(int unionSize) => $@"
public static class Union{unionSize}Match
{{
	public static TResult Match<TResult, {CommaSeparatedTs(unionSize)}>(
		this Union<{CommaSeparatedTs(unionSize)}> union,
		{JoinRangeToString(",\n\t\t", unionSize, i => $"Func<T{i}, TResult> t{i}")}) => union.Index switch
	{{
		{JoinRangeToString(",\n\t\t", unionSize, i => $"{i} => t{i}(union.Value{i})")},
		_ => throw new Unreachable()
	}};
}}
";
}