using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result3Map
{public static Result<TSuccessNew, TError0, TError1> Map<TSuccessNew, TSuccessOld, TError0, TError1>(this Result<TSuccessOld, TError0, TError1> result,
		Func<TSuccessOld, TSuccessNew> mapping){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1>.FromError(u.Value1),
			_ => Result<TSuccessNew, TError0, TError1>.FromError(u.Value2),
			};
			
		}

	public static Result<TSuccess, TErrorNew, TError1> MapError0<TSuccess, TErrorNew, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TError0, TErrorNew> mapping){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TErrorNew, TError1>.FromError(mapping(u.Value1)),
			_ => Result<TSuccess, TErrorNew, TError1>.FromError(u.Value2),
			};
			
		}

	public static Result<TSuccess, TError0, TErrorNew> MapError1<TSuccess, TErrorNew, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TError1, TErrorNew> mapping){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew>.FromError(u.Value1),
			_ => Result<TSuccess, TError0, TErrorNew>.FromError(mapping(u.Value2)),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1>> Map<TSuccessNew, TSuccessOld, TError0, TError1>(this Task<Result<TSuccessOld, TError0, TError1>> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => await (Result<TSuccessNew, TError0, TError1>.FromSuccess(mapping(u.Value0))).ConfigureAwait(false),
			1 => Result<TSuccessNew, TError0, TError1>.FromError(u.Value1),
			_ => Result<TSuccessNew, TError0, TError1>.FromError(u.Value2),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1>> MapError0<TSuccess, TErrorNew, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TError0, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1>.FromSuccess(u.Value0),
			1 => await (Result<TSuccess, TErrorNew, TError1>.FromError(mapping(u.Value1))).ConfigureAwait(false),
			_ => Result<TSuccess, TErrorNew, TError1>.FromError(u.Value2),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew>> MapError1<TSuccess, TErrorNew, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TError1, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew>.FromError(u.Value1),
			_ => await (Result<TSuccess, TError0, TErrorNew>.FromError(mapping(u.Value2))).ConfigureAwait(false),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1>> Map<TSuccessNew, TSuccessOld, TError0, TError1>(this Result<TSuccessOld, TError0, TError1> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => await (Result<TSuccessNew, TError0, TError1>.FromSuccess(mapping(u.Value0))).ConfigureAwait(false),
			1 => Result<TSuccessNew, TError0, TError1>.FromError(u.Value1),
			_ => Result<TSuccessNew, TError0, TError1>.FromError(u.Value2),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1>> MapError0<TSuccess, TErrorNew, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TError0, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1>.FromSuccess(u.Value0),
			1 => await (Result<TSuccess, TErrorNew, TError1>.FromError(mapping(u.Value1))).ConfigureAwait(false),
			_ => Result<TSuccess, TErrorNew, TError1>.FromError(u.Value2),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew>> MapError1<TSuccess, TErrorNew, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TError1, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew>.FromError(u.Value1),
			_ => await (Result<TSuccess, TError0, TErrorNew>.FromError(mapping(u.Value2))).ConfigureAwait(false),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1>> Map<TSuccessNew, TSuccessOld, TError0, TError1>(this Task<Result<TSuccessOld, TError0, TError1>> result,
		Func<TSuccessOld, TSuccessNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1>.FromError(u.Value1),
			_ => Result<TSuccessNew, TError0, TError1>.FromError(u.Value2),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew, TError1>> MapError0<TSuccess, TErrorNew, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TError0, TErrorNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew, TError1>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TErrorNew, TError1>.FromError(mapping(u.Value1)),
			_ => Result<TSuccess, TErrorNew, TError1>.FromError(u.Value2),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TErrorNew>> MapError1<TSuccess, TErrorNew, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TError1, TErrorNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TErrorNew>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TErrorNew>.FromError(u.Value1),
			_ => Result<TSuccess, TError0, TErrorNew>.FromError(mapping(u.Value2)),
			};
			
		}}
		