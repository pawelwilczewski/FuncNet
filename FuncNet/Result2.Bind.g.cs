using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Result2Bind
{public static Result<TSuccessNew, TError0> BindSuccess<TSuccessNew, TSuccessOld, TError0>(this Result<TSuccessOld, TError0> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0>.FromError(u.Value1),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static Result<TSuccess, TError0New> BindError0<TError0New, TSuccess, TError0Old>(this Result<TSuccess, TError0Old> result,
		Func<TError0Old, Result<TSuccess, TError0New>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0>> BindSuccess<TSuccessNew, TSuccessOld, TError0>(this Task<Result<TSuccessOld, TError0>> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0>.FromError(Task.FromResult(u.Value1)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New>> BindError0<TError0New, TSuccess, TError0Old>(this Task<Result<TSuccess, TError0Old>> result,
		Func<TError0Old, Task<Result<TSuccess, TError0New>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => binding(u.Value1),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0>> BindSuccess<TSuccessNew, TSuccessOld, TError0>(this Result<TSuccessOld, TError0> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0>.FromError(Task.FromResult(u.Value1)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New>> BindError0<TError0New, TSuccess, TError0Old>(this Result<TSuccess, TError0Old> result,
		Func<TError0Old, Task<Result<TSuccess, TError0New>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => binding(u.Value1),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0>> BindSuccess<TSuccessNew, TSuccessOld, TError0>(this Task<Result<TSuccessOld, TError0>> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0>.FromError(u.Value1),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0New>> BindError0<TError0New, TSuccess, TError0Old>(this Task<Result<TSuccess, TError0Old>> result,
		Func<TError0Old, Result<TSuccess, TError0New>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}}
		