using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result6Bind
{public static Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4>(this Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value2),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static Result<TSuccess, TError0New, TError1, TError2, TError3, TError4> BindError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3, TError4>(this Result<TSuccess, TError0Old, TError1, TError2, TError3, TError4> result,
		Func<TError0Old, Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(u.Value2),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static Result<TSuccess, TError0, TError1New, TError2, TError3, TError4> BindError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3, TError4>(this Result<TSuccess, TError0, TError1Old, TError2, TError3, TError4> result,
		Func<TError1Old, Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(u.Value1),
			2 => binding(u.Value2),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2New, TError3, TError4> BindError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3, TError4>(this Result<TSuccess, TError0, TError1, TError2Old, TError3, TError4> result,
		Func<TError2Old, Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(u.Value2),
			3 => binding(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3New, TError4> BindError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old, TError4>(this Result<TSuccess, TError0, TError1, TError2, TError3Old, TError4> result,
		Func<TError3Old, Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(u.Value3),
			4 => binding(u.Value4),
			_ => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(u.Value5),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4New> BindError4<TError4New, TSuccess, TError0, TError1, TError2, TError3, TError4Old>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4Old> result,
		Func<TError4Old, Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(u.Value4),
			_ => binding(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4>(this Task<Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4>> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value4)),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value5)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>> BindError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3, TError4>(this Task<Result<TSuccess, TError0Old, TError1, TError2, TError3, TError4>> result,
		Func<TError0Old, Task<Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromSuccess(Task.FromResult(u.Value0)),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value4)),
			_ => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value5)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>> BindError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3, TError4>(this Task<Result<TSuccess, TError0, TError1Old, TError2, TError3, TError4>> result,
		Func<TError1Old, Task<Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value1)),
			2 => binding(u.Value2),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value4)),
			_ => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value5)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>> BindError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3, TError4>(this Task<Result<TSuccess, TError0, TError1, TError2Old, TError3, TError4>> result,
		Func<TError2Old, Task<Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(Task.FromResult(u.Value2)),
			3 => binding(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(Task.FromResult(u.Value4)),
			_ => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(Task.FromResult(u.Value5)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>> BindError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old, TError4>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3Old, TError4>> result,
		Func<TError3Old, Task<Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(Task.FromResult(u.Value3)),
			4 => binding(u.Value4),
			_ => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(Task.FromResult(u.Value5)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>> BindError4<TError4New, TSuccess, TError0, TError1, TError2, TError3, TError4Old>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4Old>> result,
		Func<TError4Old, Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(Task.FromResult(u.Value4)),
			_ => binding(u.Value5),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4>(this Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value4)),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value5)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>> BindError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3, TError4>(this Result<TSuccess, TError0Old, TError1, TError2, TError3, TError4> result,
		Func<TError0Old, Task<Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromSuccess(Task.FromResult(u.Value0)),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value4)),
			_ => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value5)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>> BindError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3, TError4>(this Result<TSuccess, TError0, TError1Old, TError2, TError3, TError4> result,
		Func<TError1Old, Task<Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value1)),
			2 => binding(u.Value2),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value4)),
			_ => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(Task.FromResult(u.Value5)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>> BindError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3, TError4>(this Result<TSuccess, TError0, TError1, TError2Old, TError3, TError4> result,
		Func<TError2Old, Task<Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(Task.FromResult(u.Value2)),
			3 => binding(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(Task.FromResult(u.Value4)),
			_ => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(Task.FromResult(u.Value5)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>> BindError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old, TError4>(this Result<TSuccess, TError0, TError1, TError2, TError3Old, TError4> result,
		Func<TError3Old, Task<Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(Task.FromResult(u.Value3)),
			4 => binding(u.Value4),
			_ => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(Task.FromResult(u.Value5)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>> BindError4<TError4New, TSuccess, TError0, TError1, TError2, TError3, TError4Old>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4Old> result,
		Func<TError4Old, Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(Task.FromResult(u.Value4)),
			_ => binding(u.Value5),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4>(this Task<Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4>> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value2),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>> BindError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3, TError4>(this Task<Result<TSuccess, TError0Old, TError1, TError2, TError3, TError4>> result,
		Func<TError0Old, Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(u.Value2),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>> BindError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3, TError4>(this Task<Result<TSuccess, TError0, TError1Old, TError2, TError3, TError4>> result,
		Func<TError1Old, Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(u.Value1),
			2 => binding(u.Value2),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>> BindError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3, TError4>(this Task<Result<TSuccess, TError0, TError1, TError2Old, TError3, TError4>> result,
		Func<TError2Old, Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(u.Value2),
			3 => binding(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>> BindError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old, TError4>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3Old, TError4>> result,
		Func<TError3Old, Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(u.Value3),
			4 => binding(u.Value4),
			_ => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>> BindError4<TError4New, TSuccess, TError0, TError1, TError2, TError3, TError4Old>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4Old>> result,
		Func<TError4Old, Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New>.FromError(u.Value4),
			_ => binding(u.Value5),
			};
			
		}}
		