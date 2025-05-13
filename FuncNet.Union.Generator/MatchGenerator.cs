namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

public static class MatchGenerator
{
	public static string GenerateMatchExtensionsFile(string @namespace, int unionSize) => $@"
using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace {@namespace};

public static class Union{unionSize}Match
{{
	{GenerateOtherCaseAsUnionVariants(unionSize, DontWrap, DontWrap, DontWrap, "", DontWrap, "", DontWrap)}

	{GenerateOtherCaseAsUnionVariants(
		unionSize,
		WrapInAsyncTask,
		WrapInTask,
		WrapInTask,
		ASYNC_METHOD_ADDITIONAL_ARGUMENTS,
		WrapInAwaitConfiguredFromArgument,
		"cancellationToken.ThrowIfCancellationRequested();",
		WrapInAwaitConfiguredFromArgument)}

	{GenerateOtherCaseAsUnionVariants(
		unionSize,
		WrapInAsyncTask,
		DontWrap,
		WrapInTask,
		ASYNC_METHOD_ADDITIONAL_ARGUMENTS,
		DontWrap,
		"cancellationToken.ThrowIfCancellationRequested();",
		WrapInAwaitConfiguredFromArgument)}

	{GenerateOtherCaseAsUnionVariants(
		unionSize,
		WrapInAsyncTask,
		WrapInTask,
		DontWrap,
		ASYNC_METHOD_ADDITIONAL_ARGUMENTS,
		WrapInAwaitConfiguredFromArgument,
		"cancellationToken.ThrowIfCancellationRequested();",
		DontWrap)}
}}
";

	private static string GenerateOtherCaseAsUnionVariants(
		int unionSize,
		WrapText wrapMethodResultType,
		WrapText wrapUnionArgument,
		WrapText wrapBranchResultType,
		string additionalArguments,
		WrapText wrapUnionValue,
		string additionalCodeAfterUnionAssignment,
		WrapText wrapReturnValue) =>
		JoinRangeToString("\n\n\t", 1, unionSize - 1, otherCaseSize => $@"
	public static {wrapMethodResultType("TResult")} Match<TResult, {CommaSeparatedTs(unionSize)}>(
		this {wrapUnionArgument($"Union<{CommaSeparatedTs(unionSize)}>")} union,
		{JoinRangeToString(",\n\t\t", unionSize - otherCaseSize, i => $"Func<T{i}, {wrapBranchResultType("TResult")}> t{i}")},
		{GenerateLastArgumentCode(unionSize, otherCaseSize, wrapBranchResultType)}{additionalArguments})
	{{
		var u = {wrapUnionValue("union")};
		{additionalCodeAfterUnionAssignment}

		return {wrapReturnValue($@"u.Index switch
		{{
			{JoinRangeToString(",\n\t\t\t", unionSize - otherCaseSize, i => $"{i} => t{i}(u.Value{i})")},
			{GenerateLastSwitchCaseCode(unionSize, otherCaseSize)}
		}}")};
	}}");

	private static string GenerateLastArgumentCode(int unionSize, int caseSize, WrapText wrapBranchResultType) => caseSize <= 1
		? $"Func<T{unionSize - 1}, {wrapBranchResultType("TResult")}> t{unionSize - 1}"
		: $"Func<Union<{CommaSeparatedTs(unionSize - caseSize, caseSize)}>, {wrapBranchResultType("TResult")}> other";

	private static string GenerateLastSwitchCaseCode(int unionSize, int caseSize) => caseSize <= 1
		? $"_ => t{unionSize - 1}(u.Value{unionSize - 1})"
		: $"_ => other(new Union<{CommaSeparatedTs(unionSize - caseSize, caseSize)}>(u.Value))";
}