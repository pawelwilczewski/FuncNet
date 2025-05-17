using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result5Bind
{public static Result<TSuccessNew, TError0, TError1, TError2, TError3> Bind<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3>(this Result<TSuccessOld, TError0, TError1, TError2, TError3> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0, TError1, TError2, TError3>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value2),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value3),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value4),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3>> Bind<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3>(this Task<Result<TSuccessOld, TError0, TError1, TError2, TError3>> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1, TError2, TError3>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value2)),
			3 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value3)),
			_ => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value4)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3>> Bind<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3>(this Result<TSuccessOld, TError0, TError1, TError2, TError3> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1, TError2, TError3>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value2)),
			3 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value3)),
			_ => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value4)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3>> Bind<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3>(this Task<Result<TSuccessOld, TError0, TError1, TError2, TError3>> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0, TError1, TError2, TError3>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value2),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value3),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value4),
			};
			
		}}
		