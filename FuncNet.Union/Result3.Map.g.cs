using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result3Map
{public static Result<TSuccessNew, TError0, TError1> MapSuccess<TSuccessNew, TSuccessOld, TError0, TError1>(this Result<TSuccessOld, TError0, TError1> result,
		Func<TSuccessOld, TSuccessNew> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1>.FromError(u.Value2),
			_ => throw new Unreachable(),
			};
			
		}

	public static Result<TSuccess, TError0New, TError1> MapError0<TError0New, TSuccess, TError0Old, TError1>(this Result<TSuccess, TError0Old, TError1> result,
		Func<TError0Old, TError0New> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0New, TError1>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TError0New, TError1>.FromError(u.Value2),
			_ => throw new Unreachable(),
			};
			
		}

	public static Result<TSuccess, TError0, TError1New> MapError1<TError1New, TSuccess, TError0, TError1Old>(this Result<TSuccess, TError0, TError1Old> result,
		Func<TError1Old, TError1New> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1New>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1New>.FromError(mapping(u.Value2)),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1>> MapSuccess<TSuccessNew, TSuccessOld, TError0, TError1>(this Task<Result<TSuccessOld, TError0, TError1>> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccessNew, TError0, TError1>.FromError(Task.FromResult(u.Value2)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1>> MapError0<TError0New, TSuccess, TError0Old, TError1>(this Task<Result<TSuccess, TError0Old, TError1>> result,
		Func<TError0Old, Task<TError0New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0New, TError1>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TError0New, TError1>.FromError(Task.FromResult(u.Value2)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New>> MapError1<TError1New, TSuccess, TError0, TError1Old>(this Task<Result<TSuccess, TError0, TError1Old>> result,
		Func<TError1Old, Task<TError1New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1New>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1New>.FromError(mapping(u.Value2)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1>> MapSuccess<TSuccessNew, TSuccessOld, TError0, TError1>(this Result<TSuccessOld, TError0, TError1> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccessNew, TError0, TError1>.FromError(Task.FromResult(u.Value2)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1>> MapError0<TError0New, TSuccess, TError0Old, TError1>(this Result<TSuccess, TError0Old, TError1> result,
		Func<TError0Old, Task<TError0New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0New, TError1>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TError0New, TError1>.FromError(Task.FromResult(u.Value2)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New>> MapError1<TError1New, TSuccess, TError0, TError1Old>(this Result<TSuccess, TError0, TError1Old> result,
		Func<TError1Old, Task<TError1New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1New>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1New>.FromError(mapping(u.Value2)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1>> MapSuccess<TSuccessNew, TSuccessOld, TError0, TError1>(this Task<Result<TSuccessOld, TError0, TError1>> result,
		Func<TSuccessOld, TSuccessNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1>.FromError(u.Value2),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1>> MapError0<TError0New, TSuccess, TError0Old, TError1>(this Task<Result<TSuccess, TError0Old, TError1>> result,
		Func<TError0Old, TError0New> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0New, TError1>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TError0New, TError1>.FromError(u.Value2),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New>> MapError1<TError1New, TSuccess, TError0, TError1Old>(this Task<Result<TSuccess, TError0, TError1Old>> result,
		Func<TError1Old, TError1New> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1New>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1New>.FromError(mapping(u.Value2)),
			_ => throw new Unreachable(),
			};
			
		}}
		