using System;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;

public readonly partial record struct Result<TSuccess, TError0>
{
    internal Union<TSuccess, TError0> Value { get; init; }

    public bool IsSuccess => Value.Index == 0;
    public bool IsError => Value.Index != 0;

    public Result() => throw new InvalidOperationException("Result must be initialized with a value.");

    private Result(Union<TSuccess, TError0> value)
    {
       Value = value;
    }

    public static implicit operator Result<TSuccess, TError0>(TSuccess value) => new Result<TSuccess, TError0>(value);
    public static implicit operator Result<TSuccess, TError0>(TError0 value) => new Result<TSuccess, TError0>(value);

    

    public static Result<TSuccess, TError0> FromSuccess(TSuccess value) => value;
    public static Result<TSuccess, TError0> FromError(TError0 value) => value;

	public static async Task<Result<TSuccess, TError0>> FromSuccess(Task<TSuccess> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0>> FromError(Task<TError0> value) => await value.ConfigureAwait(false);
}