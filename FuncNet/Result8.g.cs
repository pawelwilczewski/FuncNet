using System;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;

public readonly partial record struct Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>
{
    internal Union<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> Value { get; init; }

    public bool IsSuccess => Value.Index == 0;
    public bool IsError => Value.Index != 0;

    public Result() => throw new InvalidOperationException("Result must be initialized with a value.");

    private Result(Union<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> value)
    {
       Value = value;
    }

    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(TSuccess value) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(TError0 value) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(TError1 value) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(TError2 value) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(TError3 value) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(TError4 value) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(TError5 value) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(TError6 value) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(value);

    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(Result<TSuccess, TError0> other) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(other.Value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(Result<TSuccess, TError0, TError1> other) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(other.Value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(Result<TSuccess, TError0, TError1, TError2> other) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(other.Value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(Result<TSuccess, TError0, TError1, TError2, TError3> other) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(other.Value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(Result<TSuccess, TError0, TError1, TError2, TError3, TError4> other) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(other.Value);
    public static implicit operator Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> other) => new Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(other.Value);

    public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> FromSuccess(TSuccess value) => value;
    public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> FromError(TError0 value) => value;
    public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> FromError(TError1 value) => value;
    public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> FromError(TError2 value) => value;
    public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> FromError(TError3 value) => value;
    public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> FromError(TError4 value) => value;
    public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> FromError(TError5 value) => value;
    public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> FromError(TError6 value) => value;

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> FromSuccess(Task<TSuccess> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> FromError(Task<TError0> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> FromError(Task<TError1> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> FromError(Task<TError2> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> FromError(Task<TError3> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> FromError(Task<TError4> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> FromError(Task<TError5> value) => await value.ConfigureAwait(false);
    public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> FromError(Task<TError6> value) => await value.ConfigureAwait(false);
}