using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result2Match
{public static TResult Match<TResult, TSuccess, TError0>(this Result<TSuccess, TError0> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => success(u.Value0),
			_ => error0(u.Value1),
			};
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0>(this Task<Result<TSuccess, TError0>> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			_ => error0(u.Value1),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0>(this Result<TSuccess, TError0> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			_ => error0(u.Value1),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0>(this Task<Result<TSuccess, TError0>> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => success(u.Value0),
			_ => error0(u.Value1),
			};
			
		}}
		