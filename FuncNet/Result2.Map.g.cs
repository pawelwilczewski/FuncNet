using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Result2Map
{public static Result<TSuccessNew, TError0> MapSuccess<TSuccessNew, TSuccessOld, TError0>(this Result<TSuccessOld, TError0> result,
		Func<TSuccessOld, TSuccessNew> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0>.FromError(u.Value1),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static Result<TSuccess, TError0New> MapError0<TError0New, TSuccess, TError0Old>(this Result<TSuccess, TError0Old> result,
		Func<TError0Old, TError0New> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0New>.FromError(mapping(u.Value1)),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0>> MapSuccess<TSuccessNew, TSuccessOld, TError0>(this Task<Result<TSuccessOld, TError0>> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccessNew, TError0>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0>.FromError(Task.FromResult(u.Value1)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New>> MapError0<TError0New, TSuccess, TError0Old>(this Task<Result<TSuccess, TError0Old>> result,
		Func<TError0Old, Task<TError0New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0New>.FromError(mapping(u.Value1)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0>> MapSuccess<TSuccessNew, TSuccessOld, TError0>(this Result<TSuccessOld, TError0> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccessNew, TError0>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0>.FromError(Task.FromResult(u.Value1)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New>> MapError0<TError0New, TSuccess, TError0Old>(this Result<TSuccess, TError0Old> result,
		Func<TError0Old, Task<TError0New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0New>.FromError(mapping(u.Value1)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0>> MapSuccess<TSuccessNew, TSuccessOld, TError0>(this Task<Result<TSuccessOld, TError0>> result,
		Func<TSuccessOld, TSuccessNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0>.FromError(u.Value1),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0New>> MapError0<TError0New, TSuccess, TError0Old>(this Task<Result<TSuccess, TError0Old>> result,
		Func<TError0Old, TError0New> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0New>.FromError(mapping(u.Value1)),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}}
		