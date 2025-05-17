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
			
		}}
		