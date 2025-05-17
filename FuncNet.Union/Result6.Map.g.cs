using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result6Map
{public static Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4> Map<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4>(this Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4> result,
		Func<TSuccessOld, TSuccessNew> mapping){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value2),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4> MapError0<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4> result,
		Func<TError0, TErrorNew> mapping){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value2),
			3 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4> MapError1<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4> result,
		Func<TError1, TErrorNew> mapping){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(mapping(u.Value2)),
			3 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4> MapError2<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4> result,
		Func<TError2, TErrorNew> mapping){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(mapping(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4> MapError3<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4> result,
		Func<TError3, TErrorNew> mapping){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(mapping(u.Value4)),
			_ => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value5),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew> MapError4<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4> result,
		Func<TError4, TErrorNew> mapping){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value4),
			_ => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(mapping(u.Value5)),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>> Map<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4>(this Task<Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4>> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => await (Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromSuccess(mapping(u.Value0))).ConfigureAwait(false),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value2),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>> MapError0<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> result,
		Func<TError0, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromSuccess(u.Value0),
			1 => await (Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(mapping(u.Value1))).ConfigureAwait(false),
			2 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value2),
			3 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>> MapError1<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> result,
		Func<TError1, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value1),
			2 => await (Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(mapping(u.Value2))).ConfigureAwait(false),
			3 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>> MapError2<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> result,
		Func<TError2, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value2),
			3 => await (Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(mapping(u.Value3))).ConfigureAwait(false),
			4 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>> MapError3<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> result,
		Func<TError3, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value3),
			4 => await (Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(mapping(u.Value4))).ConfigureAwait(false),
			_ => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>> MapError4<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> result,
		Func<TError4, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value4),
			_ => await (Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(mapping(u.Value5))).ConfigureAwait(false),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>> Map<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4>(this Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => await (Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromSuccess(mapping(u.Value0))).ConfigureAwait(false),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value2),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>> MapError0<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4> result,
		Func<TError0, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromSuccess(u.Value0),
			1 => await (Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(mapping(u.Value1))).ConfigureAwait(false),
			2 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value2),
			3 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>> MapError1<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4> result,
		Func<TError1, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value1),
			2 => await (Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(mapping(u.Value2))).ConfigureAwait(false),
			3 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>> MapError2<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4> result,
		Func<TError2, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value2),
			3 => await (Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(mapping(u.Value3))).ConfigureAwait(false),
			4 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>> MapError3<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4> result,
		Func<TError3, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value3),
			4 => await (Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(mapping(u.Value4))).ConfigureAwait(false),
			_ => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>> MapError4<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4> result,
		Func<TError4, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value4),
			_ => await (Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(mapping(u.Value5))).ConfigureAwait(false),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>> Map<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4>(this Task<Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4>> result,
		Func<TSuccessOld, TSuccessNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value2),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>> MapError0<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> result,
		Func<TError0, TErrorNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value2),
			3 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TErrorNew, TError1, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>> MapError1<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> result,
		Func<TError1, TErrorNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(mapping(u.Value2)),
			3 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TError0, TErrorNew, TError2, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>> MapError2<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> result,
		Func<TError2, TErrorNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(mapping(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value4),
			_ => Result<TSuccess, TError0, TError1, TErrorNew, TError3, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>> MapError3<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> result,
		Func<TError3, TErrorNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(mapping(u.Value4)),
			_ => Result<TSuccess, TError0, TError1, TError2, TErrorNew, TError4>.FromError(u.Value5),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>> MapError4<TSuccess, TErrorNew, TError0, TError1, TError2, TError3, TError4>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> result,
		Func<TError4, TErrorNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(u.Value4),
			_ => Result<TSuccess, TError0, TError1, TError2, TError3, TErrorNew>.FromError(mapping(u.Value5)),
			};
			
		}}
		