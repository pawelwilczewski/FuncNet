using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result3Bind
{public static Result<TSuccessNew, TError0, TError1> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1>(this Result<TSuccessOld, TError0, TError1> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0, TError1>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1>.FromError(u.Value1),
			_ => Result<TSuccessNew, TError0, TError1>.FromError(u.Value2),
			};
			
		}

	public static Result<TSuccess, TError0New, TError1> BindError0<TError0New, TSuccess, TError0Old, TError1>(this Result<TSuccess, TError0Old, TError1> result,
		Func<TError0Old, Result<TSuccess, TError0New, TError1>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			_ => Result<TSuccess, TError0New, TError1>.FromError(u.Value2),
			};
			
		}

	public static Result<TSuccess, TError0, TError1New> BindError1<TError1New, TSuccess, TError0, TError1Old>(this Result<TSuccess, TError0, TError1Old> result,
		Func<TError1Old, Result<TSuccess, TError0, TError1New>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1New>.FromError(u.Value1),
			_ => binding(u.Value2),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1>> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1>(this Task<Result<TSuccessOld, TError0, TError1>> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1>.FromError(Task.FromResult(u.Value1)),
			_ => Result<TSuccessNew, TError0, TError1>.FromError(Task.FromResult(u.Value2)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1>> BindError0<TError0New, TSuccess, TError0Old, TError1>(this Task<Result<TSuccess, TError0Old, TError1>> result,
		Func<TError0Old, Task<Result<TSuccess, TError0New, TError1>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1>.FromSuccess(Task.FromResult(u.Value0)),
			1 => binding(u.Value1),
			_ => Result<TSuccess, TError0New, TError1>.FromError(Task.FromResult(u.Value2)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New>> BindError1<TError1New, TSuccess, TError0, TError1Old>(this Task<Result<TSuccess, TError0, TError1Old>> result,
		Func<TError1Old, Task<Result<TSuccess, TError0, TError1New>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1New>.FromError(Task.FromResult(u.Value1)),
			_ => binding(u.Value2),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1>> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1>(this Result<TSuccessOld, TError0, TError1> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1>.FromError(Task.FromResult(u.Value1)),
			_ => Result<TSuccessNew, TError0, TError1>.FromError(Task.FromResult(u.Value2)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1>> BindError0<TError0New, TSuccess, TError0Old, TError1>(this Result<TSuccess, TError0Old, TError1> result,
		Func<TError0Old, Task<Result<TSuccess, TError0New, TError1>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1>.FromSuccess(Task.FromResult(u.Value0)),
			1 => binding(u.Value1),
			_ => Result<TSuccess, TError0New, TError1>.FromError(Task.FromResult(u.Value2)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New>> BindError1<TError1New, TSuccess, TError0, TError1Old>(this Result<TSuccess, TError0, TError1Old> result,
		Func<TError1Old, Task<Result<TSuccess, TError0, TError1New>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1New>.FromError(Task.FromResult(u.Value1)),
			_ => binding(u.Value2),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1>> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1>(this Task<Result<TSuccessOld, TError0, TError1>> result,
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

	public static async Task<Result<TSuccess, TError0New, TError1>> BindError0<TError0New, TSuccess, TError0Old, TError1>(this Task<Result<TSuccess, TError0Old, TError1>> result,
		Func<TError0Old, Result<TSuccess, TError0New, TError1>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			_ => Result<TSuccess, TError0New, TError1>.FromError(u.Value2),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New>> BindError1<TError1New, TSuccess, TError0, TError1Old>(this Task<Result<TSuccess, TError0, TError1Old>> result,
		Func<TError1Old, Result<TSuccess, TError0, TError1New>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1New>.FromError(u.Value1),
			_ => binding(u.Value2),
			};
			
		}}
		