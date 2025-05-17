using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result4Bind
{public static Result<TSuccessNew, TError0, TError1, TError2> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2>(this Result<TSuccessOld, TError0, TError1, TError2> result,
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

	public static Result<TSuccess, TError0New, TError1, TError2> BindError0<TError0New, TSuccess, TError0Old, TError1, TError2>(this Result<TSuccess, TError0Old, TError1, TError2> result,
		Func<TError0Old, Result<TSuccess, TError0New, TError1, TError2>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TError0New, TError1, TError2>.FromError(u.Value2),
			_ => Result<TSuccess, TError0New, TError1, TError2>.FromError(u.Value3),
			};
			
		}

	public static Result<TSuccess, TError0, TError1New, TError2> BindError1<TError1New, TSuccess, TError0, TError1Old, TError2>(this Result<TSuccess, TError0, TError1Old, TError2> result,
		Func<TError1Old, Result<TSuccess, TError0, TError1New, TError2>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1New, TError2>.FromError(u.Value1),
			2 => binding(u.Value2),
			_ => Result<TSuccess, TError0, TError1New, TError2>.FromError(u.Value3),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2New> BindError2<TError2New, TSuccess, TError0, TError1, TError2Old>(this Result<TSuccess, TError0, TError1, TError2Old> result,
		Func<TError2Old, Result<TSuccess, TError0, TError1, TError2New>> binding){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2New>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2New>.FromError(u.Value2),
			_ => binding(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2>> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2>(this Task<Result<TSuccessOld, TError0, TError1, TError2>> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1, TError2>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(Task.FromResult(u.Value2)),
			_ => Result<TSuccessNew, TError0, TError1, TError2>.FromError(Task.FromResult(u.Value3)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1, TError2>> BindError0<TError0New, TSuccess, TError0Old, TError1, TError2>(this Task<Result<TSuccess, TError0Old, TError1, TError2>> result,
		Func<TError0Old, Task<Result<TSuccess, TError0New, TError1, TError2>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2>.FromSuccess(Task.FromResult(u.Value0)),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TError0New, TError1, TError2>.FromError(Task.FromResult(u.Value2)),
			_ => Result<TSuccess, TError0New, TError1, TError2>.FromError(Task.FromResult(u.Value3)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New, TError2>> BindError1<TError1New, TSuccess, TError0, TError1Old, TError2>(this Task<Result<TSuccess, TError0, TError1Old, TError2>> result,
		Func<TError1Old, Task<Result<TSuccess, TError0, TError1New, TError2>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1New, TError2>.FromError(Task.FromResult(u.Value1)),
			2 => binding(u.Value2),
			_ => Result<TSuccess, TError0, TError1New, TError2>.FromError(Task.FromResult(u.Value3)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2New>> BindError2<TError2New, TSuccess, TError0, TError1, TError2Old>(this Task<Result<TSuccess, TError0, TError1, TError2Old>> result,
		Func<TError2Old, Task<Result<TSuccess, TError0, TError1, TError2New>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2New>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2New>.FromError(Task.FromResult(u.Value2)),
			_ => binding(u.Value3),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2>> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2>(this Result<TSuccessOld, TError0, TError1, TError2> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1, TError2>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(Task.FromResult(u.Value2)),
			_ => Result<TSuccessNew, TError0, TError1, TError2>.FromError(Task.FromResult(u.Value3)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1, TError2>> BindError0<TError0New, TSuccess, TError0Old, TError1, TError2>(this Result<TSuccess, TError0Old, TError1, TError2> result,
		Func<TError0Old, Task<Result<TSuccess, TError0New, TError1, TError2>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2>.FromSuccess(Task.FromResult(u.Value0)),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TError0New, TError1, TError2>.FromError(Task.FromResult(u.Value2)),
			_ => Result<TSuccess, TError0New, TError1, TError2>.FromError(Task.FromResult(u.Value3)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New, TError2>> BindError1<TError1New, TSuccess, TError0, TError1Old, TError2>(this Result<TSuccess, TError0, TError1Old, TError2> result,
		Func<TError1Old, Task<Result<TSuccess, TError0, TError1New, TError2>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1New, TError2>.FromError(Task.FromResult(u.Value1)),
			2 => binding(u.Value2),
			_ => Result<TSuccess, TError0, TError1New, TError2>.FromError(Task.FromResult(u.Value3)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2New>> BindError2<TError2New, TSuccess, TError0, TError1, TError2Old>(this Result<TSuccess, TError0, TError1, TError2Old> result,
		Func<TError2Old, Task<Result<TSuccess, TError0, TError1, TError2New>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2New>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2New>.FromError(Task.FromResult(u.Value2)),
			_ => binding(u.Value3),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2>> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2>(this Task<Result<TSuccessOld, TError0, TError1, TError2>> result,
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

	public static async Task<Result<TSuccess, TError0New, TError1, TError2>> BindError0<TError0New, TSuccess, TError0Old, TError1, TError2>(this Task<Result<TSuccess, TError0Old, TError1, TError2>> result,
		Func<TError0Old, Result<TSuccess, TError0New, TError1, TError2>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TError0New, TError1, TError2>.FromError(u.Value2),
			_ => Result<TSuccess, TError0New, TError1, TError2>.FromError(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New, TError2>> BindError1<TError1New, TSuccess, TError0, TError1Old, TError2>(this Task<Result<TSuccess, TError0, TError1Old, TError2>> result,
		Func<TError1Old, Result<TSuccess, TError0, TError1New, TError2>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1New, TError2>.FromError(u.Value1),
			2 => binding(u.Value2),
			_ => Result<TSuccess, TError0, TError1New, TError2>.FromError(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2New>> BindError2<TError2New, TSuccess, TError0, TError1, TError2Old>(this Task<Result<TSuccess, TError0, TError1, TError2Old>> result,
		Func<TError2Old, Result<TSuccess, TError0, TError1, TError2New>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2New>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2New>.FromError(u.Value2),
			_ => binding(u.Value3),
			};
			
		}}
		