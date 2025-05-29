using System;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;

public readonly partial record struct Result<TSuccess, TError0, TError1, TError2>
{
    internal Union<TSuccess, TError0, TError1, TError2> Value { get; init; }

    public bool IsSuccess => Value.Index == 0;
    public bool IsError => Value.Index != 0;

    public Result() => throw new InvalidOperationException("Result must be initialized with a value.");

    private Result(Union<TSuccess, TError0, TError1, TError2> value)
    {
       Value = value;
    }

    public static implicit operator Result<TSuccess, TError0, TError1, TError2>(TSuccess value) => new Result<TSuccess, TError0, TError1, TError2>(value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2>(TError0 value) => new Result<TSuccess, TError0, TError1, TError2>(value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2>(TError1 value) => new Result<TSuccess, TError0, TError1, TError2>(value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2>(TError2 value) => new Result<TSuccess, TError0, TError1, TError2>(value);

    public static implicit operator Result<TSuccess, TError0, TError1, TError2>(Result<TSuccess, TError0> other) => new Result<TSuccess, TError0, TError1, TError2>(other.Value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2>(Result<TSuccess, TError0, TError1> other) => new Result<TSuccess, TError0, TError1, TError2>(other.Value);

    public static Result<TSuccess, TError0, TError1, TError2> FromSuccess(TSuccess value) => value;
    public static Result<TSuccess, TError0, TError1, TError2> FromError(TError0 value) => value;
    public static Result<TSuccess, TError0, TError1, TError2> FromError(TError1 value) => value;
    public static Result<TSuccess, TError0, TError1, TError2> FromError(TError2 value) => value;

	public static async Task<Result<TSuccess, TError0, TError1, TError2>> FromSuccess(Task<TSuccess> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0, TError1, TError2>> FromError(Task<TError0> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0, TError1, TError2>> FromError(Task<TError1> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0, TError1, TError2>> FromError(Task<TError2> value) => await value.ConfigureAwait(false);
}