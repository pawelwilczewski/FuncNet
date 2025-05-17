using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result3Bind
{public static Result<TSuccessNew, TError0, TError1> Bind<TSuccessNew, TSuccessOld, TError0, TError1>(this Result<TSuccessOld, TError0, TError1> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0, TError1>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1>.FromError(u.Value1),
			_ => Result<TSuccessNew, TError0, TError1>.FromError(u.Value2),
			};
			
		}

	public static Result<TSuccess, TErrorNew, TError1> BindError0<TSuccess, TErrorNew, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TError0, Result<TSuccess, TErrorNew, TError1>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			_ => Result<TSuccess, TErrorNew, TError1>.FromError(u.Value2),
			};
			
		}

	public static Result<TSuccess, TError0, TErrorNew> BindError1<TSuccess, TErrorNew, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TError1, Result<TSuccess, TError0, TErrorNew>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew>.FromError(u.Value1),
			_ => binding(u.Value2),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1>> Bind<TSuccessNew, TSuccessOld, TError0, TError1>(this Task<Result<TSuccessOld, TError0, TError1>> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Task.FromResult(Result<TSuccessNew, TError0, TError1>.FromError(u.Value1)),
			_ => Task.FromResult(Result<TSuccessNew, TError0, TError1>.FromError(u.Value2)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1>> BindError0<TSuccess, TErrorNew, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TError0, Task<Result<TSuccess, TErrorNew, TError1>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TErrorNew, TError1>.FromSuccess(u.Value0)),
			1 => binding(u.Value1),
			_ => Task.FromResult(Result<TSuccess, TErrorNew, TError1>.FromError(u.Value2)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew>> BindError1<TSuccess, TErrorNew, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TError1, Task<Result<TSuccess, TError0, TErrorNew>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TErrorNew>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TErrorNew>.FromError(u.Value1)),
			_ => binding(u.Value2),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1>> Bind<TSuccessNew, TSuccessOld, TError0, TError1>(this Result<TSuccessOld, TError0, TError1> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Task.FromResult(Result<TSuccessNew, TError0, TError1>.FromError(u.Value1)),
			_ => Task.FromResult(Result<TSuccessNew, TError0, TError1>.FromError(u.Value2)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1>> BindError0<TSuccess, TErrorNew, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TError0, Task<Result<TSuccess, TErrorNew, TError1>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TErrorNew, TError1>.FromSuccess(u.Value0)),
			1 => binding(u.Value1),
			_ => Task.FromResult(Result<TSuccess, TErrorNew, TError1>.FromError(u.Value2)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew>> BindError1<TSuccess, TErrorNew, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TError1, Task<Result<TSuccess, TError0, TErrorNew>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TErrorNew>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TErrorNew>.FromError(u.Value1)),
			_ => binding(u.Value2),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1>> Bind<TSuccessNew, TSuccessOld, TError0, TError1>(this Task<Result<TSuccessOld, TError0, TError1>> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0, TError1>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1>.FromError(u.Value1),
			_ => Result<TSuccessNew, TError0, TError1>.FromError(u.Value2),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1>> BindError0<TSuccess, TErrorNew, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TError0, Result<TSuccess, TErrorNew, TError1>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			_ => Result<TSuccess, TErrorNew, TError1>.FromError(u.Value2),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew>> BindError1<TSuccess, TErrorNew, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TError1, Result<TSuccess, TError0, TErrorNew>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew>.FromError(u.Value1),
			_ => binding(u.Value2),
			};
			
		}}
		