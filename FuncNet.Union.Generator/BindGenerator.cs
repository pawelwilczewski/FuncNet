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
	{GenerateBindMethods(
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

	{GenerateBindMethods(
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

	{GenerateBindMethods(
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

	{GenerateBindMethods(
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

	private static string GenerateBindMethods(
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
}