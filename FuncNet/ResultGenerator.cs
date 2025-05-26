using FuncNet.Generator.CodeGeneration;

namespace FuncNet.Generator;

using static GenericsGenerationUtils;
using static StringJoinUtils;

public static class ResultGenerator
{
	public static string GenerateResultFile(string @namespace, int unionSize) =>
		$@"using System;
using System.Threading.Tasks;

#nullable enable

namespace {@namespace};

public readonly partial record struct {ResultOfTs(unionSize)}
{{
    internal {ResultBackingUnion(unionSize)} Value {{ get; init; }}

    public bool IsSuccess => Value.Index == 0;
    public bool IsError => Value.Index != 0;

    public Result() => throw new InvalidOperationException(""Result must be initialized with a value."");

    private Result({ResultBackingUnion(unionSize)} value)
    {{
       Value = value;
    }}

    public static implicit operator {ResultOfTs(unionSize)}(TSuccess value) => new {ResultOfTs(unionSize)}(value);
    {JoinRangeToString("\n    ", unionSize - 1, errorIndex =>
		$"public static implicit operator {ResultOfTs(unionSize)}(TError{errorIndex} value) => new {ResultOfTs(unionSize)}(value);")}

    public static {ResultOfTs(unionSize)} FromSuccess(TSuccess value) => value;
    {JoinRangeToString("\n    ", unionSize - 1, errorIndex =>
		$"public static {ResultOfTs(unionSize)} FromError(TError{errorIndex} value) => value;")}

	public static async Task<{ResultOfTs(unionSize)}> FromSuccess(Task<TSuccess> value) => await value.ConfigureAwait(false);
    {JoinRangeToString("\n    ", unionSize - 1, errorIndex =>
		$"public static async Task<{ResultOfTs(unionSize)}> FromError(Task<TError{errorIndex}> value) => await value.ConfigureAwait(false);")}
}}";
}