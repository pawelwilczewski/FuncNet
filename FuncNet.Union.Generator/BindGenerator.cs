namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;

public static class BindGenerator
{
	public static string GenerateBindExtensionsFile(string @namespace, int unionSize) => $@"
using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace {@namespace};

public static class Union{unionSize}Bind
{{
	{GenerateBindMethod(
		unionSize,
		DontWrap,
		DontWrap,
		DontWrap,
		"",
		DontWrap,
		"",
		@case => new SwitchCaseText(
		@case.Variable,
		GenerateSwitchReturnValue(@case)),
		DontWrap)}

	{GenerateBindMethod(
		unionSize,
		WrapInAsyncTask,
		WrapInTask,
		WrapInTask,
		asyncMethodAdditionalArgumentsJoined,
		WrapInAwaitConfiguredFromArgument,
		"cancellationToken.ThrowIfCancellationRequested();",
		@case => new SwitchCaseText(
		@case.Variable,
		GenerateSwitchReturnValue(@case)
			.WrapInTaskFromResultIfNotSpecial(@case)
			.WrapInNewUnionFromTIfNotSpecial(@case, unionSize)),
		WrapInAwaitConfiguredFromArgument)}

	{GenerateBindMethod(
		unionSize,
		WrapInAsyncTask,
		DontWrap,
		WrapInTask,
		asyncMethodAdditionalArgumentsJoined,
		DontWrap,
		"cancellationToken.ThrowIfCancellationRequested();",
		@case => new SwitchCaseText(
		@case.Variable,
		GenerateSwitchReturnValue(@case)
			.WrapInTaskFromResultIfNotSpecial(@case)
			.WrapInNewUnionFromTIfNotSpecial(@case, unionSize)),
		WrapInAwaitConfiguredFromArgument)}

	{GenerateBindMethod(
		unionSize,
		WrapInAsyncTask,
		WrapInTask,
		DontWrap,
		asyncMethodAdditionalArgumentsJoined,
		WrapInAwaitConfiguredFromArgument,
		"cancellationToken.ThrowIfCancellationRequested();",
		@case => new SwitchCaseText(
		@case.Variable,
		GenerateSwitchReturnValue(@case)
			.WrapInNewUnionFromTIfNotSpecial(@case, unionSize)),
		DontWrap)}
}}
";

	private static string GenerateBindMethod(
		int unionSize,
		WrapText wrapMethodResultType,
		WrapText wrapUnionArgument,
		WrapText wrapBranchResultType,
		string additionalArguments,
		WrapText wrapUnionValue,
		string additionalCodeAfterUnionAssignment,
		GenerateSwitchCaseOneSpecial generateSwitchCase,
		WrapText wrapReturnValue) =>
		JoinRangeToString("\n\n\t", unionSize, bindIndex => $@"
	public static {wrapMethodResultType($"Union<{TsNew(unionSize, bindIndex)}>")} Bind{bindIndex}<T{bindIndex}New, {TsOld(unionSize, bindIndex)}>(
		this {wrapUnionArgument($"Union<{TsOld(unionSize, bindIndex)}>")} union,
		Func<T{bindIndex}Old, {wrapBranchResultType($"Union<{TsNew(unionSize, bindIndex)}>")}> binding{additionalArguments})
	{{
		var u = {wrapUnionValue("union")};
		{additionalCodeAfterUnionAssignment}

		return {wrapReturnValue(GenerateSwitchExpression(
			"u.Index",
			GenerateSwitchExpressionCases(
				unionSize,
				bindIndex,
				generateSwitchCase)))};
	}}");

	private static IEnumerable<string> TsWithSpecialReplacement(int count, int specialIndex, string specialReplacement) =>
		Enumerable.Range(0, count).Select(i => i == specialIndex ? specialReplacement : $"T{i}");

	private static string CommaSeparatedTsWithSpecialReplacement(int count, int specialIndex, string specialReplacement) =>
		string.Join(", ", TsWithSpecialReplacement(count, specialIndex, specialReplacement));

	private static string TsNew(int count, int specialIndex) =>
		CommaSeparatedTsWithSpecialReplacement(count, specialIndex, $"T{specialIndex}New");

	private static string TsOld(int count, int specialIndex) =>
		CommaSeparatedTsWithSpecialReplacement(count, specialIndex, $"T{specialIndex}Old");

	private static IEnumerable<SwitchCaseText> GenerateSwitchExpressionCases(
		int unionSize, int specialIndex,
		GenerateSwitchCaseOneSpecial generateCase) =>
		Enumerable.Range(0, unionSize)
			.Select(i =>
			{
				var variable = i == unionSize - 1 ? "_" : $"{i}";
				return generateCase(new SwitchCaseOneSpecial(i, variable, specialIndex));
			});

	private static string GenerateSwitchReturnValue(SwitchCaseOneSpecial @case) =>
		@case.Index == @case.SpecialIndex
			? $"binding(u.Value{@case.Index})"
			: $"u.Value{@case.Index}";

	private static string WrapInNewUnionFromT(this string value, SwitchCaseOneSpecial @case, int unionSize) =>
		$"Union<{TsNew(unionSize, @case.SpecialIndex)}>.FromT{@case.Index}({value})";

	private static string WrapInNewUnionFromTIfNotSpecial(this string value, SwitchCaseOneSpecial @case, int unionSize) =>
		@case.SpecialIndex == @case.Index ? value : value.WrapInNewUnionFromT(@case, unionSize);
	
	private static string WrapInTaskFromResultIfNotSpecial(this string value, SwitchCaseOneSpecial @case) =>
		@case.Index == @case.SpecialIndex ? value : WrapInTaskFromResult(value);
}