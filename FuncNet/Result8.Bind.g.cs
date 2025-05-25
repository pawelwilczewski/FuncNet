using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Result8Bind
{public static Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccessOld, Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6> BindError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError0Old, Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6> BindError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError1Old, Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => binding(u.Value2),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6> BindError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6> result,
		Func<TError2Old, Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => binding(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6> BindError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6> result,
		Func<TError3Old, Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value3),
			4 => binding(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6> BindError4<TError4New, TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6> result,
		Func<TError4Old, Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value4),
			5 => binding(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6> BindError5<TError5New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6> result,
		Func<TError5Old, Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value5),
			6 => binding(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New> BindError6<TError6New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old> result,
		Func<TError6Old, Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>> binding){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value6),
			7 => binding(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>> BindError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError0Old, Task<Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>> BindError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError1Old, Task<Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => binding(u.Value2),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>> BindError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6>> result,
		Func<TError2Old, Task<Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => binding(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>> BindError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6>> result,
		Func<TError3Old, Task<Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => binding(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>> BindError4<TError4New, TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6>> result,
		Func<TError4Old, Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => binding(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>> BindError5<TError5New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6>> result,
		Func<TError5Old, Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => binding(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>> BindError6<TError6New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old>> result,
		Func<TError6Old, Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value6)),
			7 => binding(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccessOld, Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>> BindError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError0Old, Task<Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>> BindError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError1Old, Task<Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => binding(u.Value2),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>> BindError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6> result,
		Func<TError2Old, Task<Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => binding(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>> BindError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6> result,
		Func<TError3Old, Task<Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => binding(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>> BindError4<TError4New, TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6> result,
		Func<TError4Old, Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => binding(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>> BindError5<TError5New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6> result,
		Func<TError5Old, Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => binding(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>> BindError6<TError6New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old> result,
		Func<TError6Old, Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>>> binding,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value6)),
			7 => binding(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> BindSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
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
			7 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>> BindError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError0Old, Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => binding(u.Value1),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>> BindError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError1Old, Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => binding(u.Value2),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>> BindError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6>> result,
		Func<TError2Old, Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => binding(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>> BindError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6>> result,
		Func<TError3Old, Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value3),
			4 => binding(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>> BindError4<TError4New, TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6>> result,
		Func<TError4Old, Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value4),
			5 => binding(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>> BindError5<TError5New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6>> result,
		Func<TError5Old, Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value5),
			6 => binding(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>> BindError6<TError6New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old>> result,
		Func<TError6Old, Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>> binding,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value6),
			7 => binding(u.Value7),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}}
		