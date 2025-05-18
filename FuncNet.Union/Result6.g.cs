using System;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;

public readonly partial record struct Result<TSuccess, TError0, TError1, TError2, TError3, TError4>
{
    internal Union<TSuccess, TError0, TError1, TError2, TError3, TError4> Value { get; init; }

    public bool IsSuccess => Value.Index == 0;
    public bool IsError => Value.Index != 0;

    public Result() => throw new InvalidOperationException("Result must be initialized with a value.");

    private Result(Union<TSuccess, TError0, TError1, TError2, TError3, TError4> value)
    {
       Value = value;
    }

    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(TSuccess value) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(TError0 value) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(TError1 value) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(TError2 value) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(TError3 value) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(TError4 value) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(value);

    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(Result<TSuccess, TError0> other) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(other.Value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(Result<TSuccess, TError0, TError1> other) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(other.Value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(Result<TSuccess, TError0, TError1, TError2> other) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(other.Value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(Result<TSuccess, TError0, TError1, TError2, TError3> other) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4>(other.Value);

    public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4> FromSuccess(TSuccess value) => value;
    public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4> FromError(TError0 value) => value;
    public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4> FromError(TError1 value) => value;
    public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4> FromError(TError2 value) => value;
    public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4> FromError(TError3 value) => value;
    public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4> FromError(TError4 value) => value;

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> FromSuccess(Task<TSuccess> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> FromError(Task<TError0> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> FromError(Task<TError1> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> FromError(Task<TError2> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> FromError(Task<TError3> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> FromError(Task<TError4> value) => await value.ConfigureAwait(false);
}