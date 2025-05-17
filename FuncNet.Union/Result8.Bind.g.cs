using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result8Bind
{public static Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6> Bind<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			};
			
		}

	public static Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6> BindError0<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError0, Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			_ => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			};
			
		}

	public static Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6> BindError1<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError1, Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => binding(u.Value2),
			3 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			_ => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6> BindError2<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError2, Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => binding(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			_ => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6> BindError3<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError3, Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value3),
			4 => binding(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value6),
			_ => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value7),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6> BindError4<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError4, Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value4),
			5 => binding(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value6),
			_ => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value7),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6> BindError5<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError5, Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value5),
			6 => binding(u.Value6),
			_ => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value7),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew> BindError6<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError6, Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value6),
			_ => binding(u.Value7),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> Bind<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value2)),
			3 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3)),
			4 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4)),
			5 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5)),
			6 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6)),
			_ => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>> BindError0<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError0, Task<Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0)),
			1 => binding(u.Value1),
			2 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value2)),
			3 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3)),
			4 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4)),
			5 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5)),
			6 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6)),
			_ => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>> BindError1<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError1, Task<Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value1)),
			2 => binding(u.Value2),
			3 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3)),
			4 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4)),
			5 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5)),
			6 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6)),
			_ => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>> BindError2<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError2, Task<Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value2)),
			3 => binding(u.Value3),
			4 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value4)),
			5 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value5)),
			6 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value6)),
			_ => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value7)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>> BindError3<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError3, Task<Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value2)),
			3 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value3)),
			4 => binding(u.Value4),
			5 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value5)),
			6 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value6)),
			_ => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value7)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>> BindError4<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError4, Task<Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value2)),
			3 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value3)),
			4 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value4)),
			5 => binding(u.Value5),
			6 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value6)),
			_ => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value7)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>> BindError5<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError5, Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value2)),
			3 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value3)),
			4 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value4)),
			5 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value5)),
			6 => binding(u.Value6),
			_ => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value7)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>> BindError6<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError6, Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value2)),
			3 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value3)),
			4 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value4)),
			5 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value5)),
			6 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value6)),
			_ => binding(u.Value7),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> Bind<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value2)),
			3 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3)),
			4 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4)),
			5 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5)),
			6 => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6)),
			_ => Task.FromResult(Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>> BindError0<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError0, Task<Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0)),
			1 => binding(u.Value1),
			2 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value2)),
			3 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3)),
			4 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4)),
			5 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5)),
			6 => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6)),
			_ => Task.FromResult(Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>> BindError1<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError1, Task<Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value1)),
			2 => binding(u.Value2),
			3 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3)),
			4 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4)),
			5 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5)),
			6 => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6)),
			_ => Task.FromResult(Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>> BindError2<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError2, Task<Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value2)),
			3 => binding(u.Value3),
			4 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value4)),
			5 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value5)),
			6 => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value6)),
			_ => Task.FromResult(Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value7)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>> BindError3<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError3, Task<Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value2)),
			3 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value3)),
			4 => binding(u.Value4),
			5 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value5)),
			6 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value6)),
			_ => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value7)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>> BindError4<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError4, Task<Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value2)),
			3 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value3)),
			4 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value4)),
			5 => binding(u.Value5),
			6 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value6)),
			_ => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value7)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>> BindError5<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError5, Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value2)),
			3 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value3)),
			4 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value4)),
			5 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value5)),
			6 => binding(u.Value6),
			_ => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value7)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>> BindError6<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError6, Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromSuccess(u.Value0)),
			1 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value1)),
			2 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value2)),
			3 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value3)),
			4 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value4)),
			5 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value5)),
			6 => Task.FromResult(Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value6)),
			_ => binding(u.Value7),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> Bind<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>> BindError0<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError0, Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			_ => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>> BindError1<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError1, Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => binding(u.Value2),
			3 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			_ => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>> BindError2<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError2, Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => binding(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			_ => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>> BindError3<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError3, Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value3),
			4 => binding(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value6),
			_ => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4, TError5, TError6>.FromError(u.Value7),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>> BindError4<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError4, Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value4),
			5 => binding(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value6),
			_ => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew, TError5, TError6>.FromError(u.Value7),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>> BindError5<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError5, Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value5),
			6 => binding(u.Value6),
			_ => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TErrorNew, TError6>.FromError(u.Value7),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>> BindError6<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError6, Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TErrorNew>.FromError(u.Value6),
			_ => binding(u.Value7),
			};
			
		}}
		