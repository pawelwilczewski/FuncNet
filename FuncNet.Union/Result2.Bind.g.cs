using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result2Bind
{public static Result<TSuccessNew, TError0> Bind<TSuccessNew, TSuccessOld, TError0>(this Result<TSuccessOld, TError0> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => binding(u.Value0),
			_ => Result<TSuccessNew, TError0>.FromError(u.Value1),
			};
			
		}

	public static Result<TSuccess, TErrorNew> BindError0<TSuccess, TErrorNew, TError0>(this Result<TSuccess, TError0> result,
		Func<TError0, Result<TSuccess, TErrorNew>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew>.FromSuccess(u.Value0),
			_ => binding(u.Value1),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0>> Bind<TSuccessNew, TSuccessOld, TError0>(this Task<Result<TSuccessOld, TError0>> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			_ => Task.FromResult(Result<TSuccessNew, TError0>.FromError(u.Value1)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TErrorNew>> BindError0<TSuccess, TErrorNew, TError0>(this Task<Result<TSuccess, TError0>> result,
		Func<TError0, Task<Result<TSuccess, TErrorNew>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TErrorNew>.FromSuccess(u.Value0)),
			_ => binding(u.Value1),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0>> Bind<TSuccessNew, TSuccessOld, TError0>(this Result<TSuccessOld, TError0> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			_ => Task.FromResult(Result<TSuccessNew, TError0>.FromError(u.Value1)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TErrorNew>> BindError0<TSuccess, TErrorNew, TError0>(this Result<TSuccess, TError0> result,
		Func<TError0, Task<Result<TSuccess, TErrorNew>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TErrorNew>.FromSuccess(u.Value0)),
			_ => binding(u.Value1),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0>> Bind<TSuccessNew, TSuccessOld, TError0>(this Task<Result<TSuccessOld, TError0>> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => binding(u.Value0),
			_ => Result<TSuccessNew, TError0>.FromError(u.Value1),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew>> BindError0<TSuccess, TErrorNew, TError0>(this Task<Result<TSuccess, TError0>> result,
		Func<TError0, Result<TSuccess, TErrorNew>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew>.FromSuccess(u.Value0),
			_ => binding(u.Value1),
			};
			
		}}
		