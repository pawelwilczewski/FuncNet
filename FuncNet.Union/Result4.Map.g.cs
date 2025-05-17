using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result4Map
{public static Result<TSuccessNew, TError0, TError1, TError2> Map<TSuccessNew, TSuccessOld, TError0, TError1, TError2>(this Result<TSuccessOld, TError0, TError1, TError2> result,
		Func<TSuccessOld, TSuccessNew> mapping){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1, TError2>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value2),
			_ => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value3),
			};
			
		}

	public static Result<TSuccess, TErrorNew, TError1, TError2> MapError0<TSuccess, TErrorNew, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TError0, TErrorNew> mapping){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1, TError2>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TErrorNew, TError1, TError2>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value2),
			_ => Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value3),
			};
			
		}

	public static Result<TSuccess, TError0, TErrorNew, TError2> MapError1<TSuccess, TErrorNew, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TError1, TErrorNew> mapping){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew, TError2>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TErrorNew, TError2>.FromError(mapping(u.Value2)),
			_ => Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value3),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TErrorNew> MapError2<TSuccess, TErrorNew, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TError2, TErrorNew> mapping){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value2),
			_ => Result<TSuccess, TError0, TError1, TErrorNew>.FromError(mapping(u.Value3)),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2>> Map<TSuccessNew, TSuccessOld, TError0, TError1, TError2>(this Task<Result<TSuccessOld, TError0, TError1, TError2>> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => await (Result<TSuccessNew, TError0, TError1, TError2>.FromSuccess(mapping(u.Value0))).ConfigureAwait(false),
			1 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value2),
			_ => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1, TError2>> MapError0<TSuccess, TErrorNew, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TError0, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1, TError2>.FromSuccess(u.Value0),
			1 => await (Result<TSuccess, TErrorNew, TError1, TError2>.FromError(mapping(u.Value1))).ConfigureAwait(false),
			2 => Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value2),
			_ => Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew, TError2>> MapError1<TSuccess, TErrorNew, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TError1, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew, TError2>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value1),
			2 => await (Result<TSuccess, TError0, TErrorNew, TError2>.FromError(mapping(u.Value2))).ConfigureAwait(false),
			_ => Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TErrorNew>> MapError2<TSuccess, TErrorNew, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TError2, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value2),
			_ => await (Result<TSuccess, TError0, TError1, TErrorNew>.FromError(mapping(u.Value3))).ConfigureAwait(false),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2>> Map<TSuccessNew, TSuccessOld, TError0, TError1, TError2>(this Result<TSuccessOld, TError0, TError1, TError2> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => await (Result<TSuccessNew, TError0, TError1, TError2>.FromSuccess(mapping(u.Value0))).ConfigureAwait(false),
			1 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value2),
			_ => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1, TError2>> MapError0<TSuccess, TErrorNew, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TError0, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1, TError2>.FromSuccess(u.Value0),
			1 => await (Result<TSuccess, TErrorNew, TError1, TError2>.FromError(mapping(u.Value1))).ConfigureAwait(false),
			2 => Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value2),
			_ => Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew, TError2>> MapError1<TSuccess, TErrorNew, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TError1, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew, TError2>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value1),
			2 => await (Result<TSuccess, TError0, TErrorNew, TError2>.FromError(mapping(u.Value2))).ConfigureAwait(false),
			_ => Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TErrorNew>> MapError2<TSuccess, TErrorNew, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TError2, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value2),
			_ => await (Result<TSuccess, TError0, TError1, TErrorNew>.FromError(mapping(u.Value3))).ConfigureAwait(false),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2>> Map<TSuccessNew, TSuccessOld, TError0, TError1, TError2>(this Task<Result<TSuccessOld, TError0, TError1, TError2>> result,
		Func<TSuccessOld, TSuccessNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1, TError2>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value2),
			_ => Result<TSuccessNew, TError0, TError1, TError2>.FromError(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1, TError2>> MapError0<TSuccess, TErrorNew, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TError0, TErrorNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1, TError2>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TErrorNew, TError1, TError2>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value2),
			_ => Result<TSuccess, TErrorNew, TError1, TError2>.FromError(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew, TError2>> MapError1<TSuccess, TErrorNew, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TError1, TErrorNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew, TError2>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TErrorNew, TError2>.FromError(mapping(u.Value2)),
			_ => Result<TSuccess, TError0, TErrorNew, TError2>.FromError(u.Value3),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TErrorNew>> MapError2<TSuccess, TErrorNew, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TError2, TErrorNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TErrorNew>.FromError(u.Value2),
			_ => Result<TSuccess, TError0, TError1, TErrorNew>.FromError(mapping(u.Value3)),
			};
			
		}}
		