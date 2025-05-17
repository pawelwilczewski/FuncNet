using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result2Map
{public static Result<TSuccessNew, TError0> Map<TSuccessNew, TSuccessOld, TError0>(this Result<TSuccessOld, TError0> result,
		Func<TSuccessOld, TSuccessNew> mapping){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0>.FromSuccess(mapping(u.Value0)),
			_ => Result<TSuccessNew, TError0>.FromError(u.Value1),
			};
			
		}

	public static Result<TSuccess, TErrorNew> MapError0<TSuccess, TErrorNew, TError0>(this Result<TSuccess, TError0> result,
		Func<TError0, TErrorNew> mapping){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew>.FromSuccess(u.Value0),
			_ => Result<TSuccess, TErrorNew>.FromError(mapping(u.Value1)),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0>> Map<TSuccessNew, TSuccessOld, TError0>(this Task<Result<TSuccessOld, TError0>> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => await (Result<TSuccessNew, TError0>.FromSuccess(mapping(u.Value0))).ConfigureAwait(false),
			_ => Result<TSuccessNew, TError0>.FromError(u.Value1),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew>> MapError0<TSuccess, TErrorNew, TError0>(this Task<Result<TSuccess, TError0>> result,
		Func<TError0, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew>.FromSuccess(u.Value0),
			_ => await (Result<TSuccess, TErrorNew>.FromError(mapping(u.Value1))).ConfigureAwait(false),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0>> Map<TSuccessNew, TSuccessOld, TError0>(this Result<TSuccessOld, TError0> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => await (Result<TSuccessNew, TError0>.FromSuccess(mapping(u.Value0))).ConfigureAwait(false),
			_ => Result<TSuccessNew, TError0>.FromError(u.Value1),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew>> MapError0<TSuccess, TErrorNew, TError0>(this Result<TSuccess, TError0> result,
		Func<TError0, Task<TErrorNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew>.FromSuccess(u.Value0),
			_ => await (Result<TSuccess, TErrorNew>.FromError(mapping(u.Value1))).ConfigureAwait(false),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0>> Map<TSuccessNew, TSuccessOld, TError0>(this Task<Result<TSuccessOld, TError0>> result,
		Func<TSuccessOld, TSuccessNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0>.FromSuccess(mapping(u.Value0)),
			_ => Result<TSuccessNew, TError0>.FromError(u.Value1),
			};
			
		}

	public static async Task<Result<TSuccess, TErrorNew>> MapError0<TSuccess, TErrorNew, TError0>(this Task<Result<TSuccess, TError0>> result,
		Func<TError0, TErrorNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TErrorNew>.FromSuccess(u.Value0),
			_ => Result<TSuccess, TErrorNew>.FromError(mapping(u.Value1)),
			};
			
		}}
		