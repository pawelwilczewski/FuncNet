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
			
		}}
		