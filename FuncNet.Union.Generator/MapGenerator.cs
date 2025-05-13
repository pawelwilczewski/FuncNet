namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

public static class MapGenerator
{
	public static string GenerateMapExtensionsFile(string @namespace, int unionSize) => $@"
using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace {@namespace};

public static class Union{unionSize}Map
{{
	{GenerateMapMethod(
		unionSize,
		DontWrap,
		DontWrap,
		DontWrap,
		"",
		DontWrap,
		"",
		DontWrap,
		DontWrap)}

	{GenerateMapMethod(
		unionSize,
		WrapInAsyncTask,
		WrapInTask,
		WrapInTask,
		ASYNC_METHOD_ADDITIONAL_ARGUMENTS,
		WrapInAwaitConfiguredFromArgument,
		"cancellationToken.ThrowIfCancellationRequested();",
		WrapInTaskFromResult,
		WrapInAwaitConfiguredFromArgument)}

	{GenerateMapMethod(
		unionSize,
		WrapInAsyncTask,
		DontWrap,
		WrapInTask,
		ASYNC_METHOD_ADDITIONAL_ARGUMENTS,
		DontWrap,
		"cancellationToken.ThrowIfCancellationRequested();",
		WrapInTaskFromResult,
		WrapInAwaitConfiguredFromArgument)}

	{GenerateMapMethod(
		unionSize,
		WrapInAsyncTask,
		WrapInTask,
		DontWrap,
		ASYNC_METHOD_ADDITIONAL_ARGUMENTS,
		WrapInAwaitConfiguredFromArgument,
		"cancellationToken.ThrowIfCancellationRequested();",
		DontWrap,
		DontWrap)}
}}
";

	private static string GenerateMapMethod(
		int unionSize,
		WrapText wrapMethodResultType,
		WrapText wrapUnionArgument,
		WrapText wrapBranchResultType,
		string additionalArguments,
		WrapText wrapUnionValue,
		string additionalCodeAfterUnionAssignment,
		WrapText wrapRegularMatchCase,
		WrapText wrapReturnValue) =>
		JoinRangeToString("\n\n\t", unionSize, mapIndex => $@"
	public static {wrapMethodResultType($"Union<{TsNew(unionSize, mapIndex)}>")} Map{mapIndex}<T{mapIndex}New, {TsOld(unionSize, mapIndex)}>(
		this {wrapUnionArgument($"Union<{TsOld(unionSize, mapIndex)}>")} union,
		Func<T{mapIndex}Old, {wrapBranchResultType($"T{mapIndex}New")}> mapping{additionalArguments})
	{{
		var u = {wrapUnionValue("union")};
		{additionalCodeAfterUnionAssignment}

		return {wrapReturnValue($@"u.Match(
			{string.Join(",\n\t\t\t", Enumerable.Range(0, unionSize).Select(i => GenerateMatchCase(i, mapIndex, unionSize, wrapRegularMatchCase)))})")};
	}}");

	private static IEnumerable<string> TsWithSpecialReplacement(int count, int specialIndex, string specialReplacement) =>
		Enumerable.Range(0, count).Select(i => i == specialIndex ? specialReplacement : $"T{i}");

	private static string CommaSeparatedTsWithSpecialReplacement(int count, int specialIndex, string specialReplacement) =>
		string.Join(", ", TsWithSpecialReplacement(count, specialIndex, specialReplacement));

	private static string TsNew(int count, int specialIndex) => CommaSeparatedTsWithSpecialReplacement(count, specialIndex, $"T{specialIndex}New");

	private static string TsOld(int count, int specialIndex) => CommaSeparatedTsWithSpecialReplacement(count, specialIndex, $"T{specialIndex}Old");

	private static string GenerateMatchCase(int index, int specialIndex, int unionSize, WrapText wrapRegularCase) => index == specialIndex
		? $"t{index} => Union<{TsNew(unionSize, specialIndex)}>.FromT{index}(mapping(t{index}))"
		: $"t{index} => {wrapRegularCase($"Union<{TsNew(unionSize, specialIndex)}>.FromT{index}(t{index})")}";
}