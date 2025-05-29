using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Result3Match
{public static TResult Match<TResult, TSuccess, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<TError1, TResult> error1){
		var u = (result).Value;
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			_ => error1(u.Value2),
			};
			
		}

	public static TResult Match<TResult, TSuccess, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TSuccess, TResult> success,
		Func<Union<TError0, TError1>, TResult> other){
		var u = (result).Value;
			return u.Index switch
		{
			0 => success(u.Value0),
			_ => other(new Union<TError0, TError1>(u.Value)),
			};
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<TError1, Task<TResult>> error1,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			_ => error1(u.Value2),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TSuccess, Task<TResult>> success,
		Func<Union<TError0, TError1>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			_ => other(new Union<TError0, TError1>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<TError1, Task<TResult>> error1,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			_ => error1(u.Value2),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TSuccess, Task<TResult>> success,
		Func<Union<TError0, TError1>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			_ => other(new Union<TError0, TError1>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<TError1, TResult> error1,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			_ => error1(u.Value2),
			};
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TSuccess, TResult> success,
		Func<Union<TError0, TError1>, TResult> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => success(u.Value0),
			_ => other(new Union<TError0, TError1>(u.Value)),
			};
			
		}}
		