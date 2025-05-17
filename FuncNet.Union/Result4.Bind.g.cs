using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result4Bind
{public static Result<TSuccessNew, TError0, TError1, TError2> Bind<TSuccessNew, TSuccessOld, TError0, TError1, TError2>(this Result<TSuccessOld, TError0, TError1, TError2> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0, TError1, TError2>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value2),
			_ => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value3),
			};
			
		}

	public static Result<TSuccess, TErrorNew, TError1, TError2> BindError0<TSuccess, TErrorNew, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TError0, Result<TSuccess, TErrorNew, TError1, TError2>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1, TError2>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value2),
			_ => Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value3),
			};
			
		}

	public static Result<TSuccess, TError0, TErrorNew, TError2> BindError1<TSuccess, TErrorNew, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TError1, Result<TSuccess, TError0, TErrorNew, TError2>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew, TError2>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value1),
			2 => binding(u.Value2),
			_ => Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value3),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TErrorNew> BindError2<TSuccess, TErrorNew, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TError2, Result<TSuccess, TError0, TError1, TErrorNew>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value2),
			_ => binding(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2>> Bind<TSuccessNew, TSuccessOld, TError0, TError1, TError2>(this Task<Result<TSuccessOld, TError0, TError1, TError2>> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1, TError2>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value2)),
			_ => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value3)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1, TError2>> BindError0<TSuccess, TErrorNew, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TError0, Task<Result<TSuccess, TErrorNew, TError1, TError2>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2>.FromSuccess(u.Value0)),
			1 => binding(u.Value1),
			2 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value2)),
			_ => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value3)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew, TError2>> BindError1<TSuccess, TErrorNew, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TError1, Task<Result<TSuccess, TError0, TErrorNew, TError2>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value1)),
			2 => binding(u.Value2),
			_ => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value3)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TErrorNew>> BindError2<TSuccess, TErrorNew, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TError2, Task<Result<TSuccess, TError0, TError1, TErrorNew>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value2)),
			_ => binding(u.Value3),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2>> Bind<TSuccessNew, TSuccessOld, TError0, TError1, TError2>(this Result<TSuccessOld, TError0, TError1, TError2> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1, TError2>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value2)),
			_ => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value3)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1, TError2>> BindError0<TSuccess, TErrorNew, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TError0, Task<Result<TSuccess, TErrorNew, TError1, TError2>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2>.FromSuccess(u.Value0)),
			1 => binding(u.Value1),
			2 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value2)),
			_ => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value3)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew, TError2>> BindError1<TSuccess, TErrorNew, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TError1, Task<Result<TSuccess, TError0, TErrorNew, TError2>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value1)),
			2 => binding(u.Value2),
			_ => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value3)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TErrorNew>> BindError2<TSuccess, TErrorNew, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TError2, Task<Result<TSuccess, TError0, TError1, TErrorNew>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value2)),
			_ => binding(u.Value3),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2>> Bind<TSuccessNew, TSuccessOld, TError0, TError1, TError2>(this Task<Result<TSuccessOld, TError0, TError1, TError2>> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0, TError1, TError2>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value2),
			_ => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1, TError2>> BindError0<TSuccess, TErrorNew, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TError0, Result<TSuccess, TErrorNew, TError1, TError2>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1, TError2>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value2),
			_ => Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew, TError2>> BindError1<TSuccess, TErrorNew, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TError1, Result<TSuccess, TError0, TErrorNew, TError2>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew, TError2>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value1),
			2 => binding(u.Value2),
			_ => Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TErrorNew>> BindError2<TSuccess, TErrorNew, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TError2, Result<TSuccess, TError0, TError1, TErrorNew>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value2),
			_ => binding(u.Value3),
			};
			
		}}
		