using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result4Match
{public static TResult Match<TResult, TSuccess, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<TError1, TResult> error1,
		Func<TError2, TResult> error2){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			_ => error2(u.Value3),
			};
			
		}

	public static TResult Match<TResult, TSuccess, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<Union<TError1, TError2>, TResult> other){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			_ => other(new Union<TError1, TError2>(u.Value)),
			};
			
		}

	public static TResult Match<TResult, TSuccess, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TSuccess, TResult> success,
		Func<Union<TError0, TError1, TError2>, TResult> other){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => success(u.Value0),
			_ => other(new Union<TError0, TError1, TError2>(u.Value)),
			};
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<TError1, Task<TResult>> error1,
		Func<TError2, Task<TResult>> error2,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			_ => error2(u.Value3),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<Union<TError1, TError2>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			_ => other(new Union<TError1, TError2>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TSuccess, Task<TResult>> success,
		Func<Union<TError0, TError1, TError2>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			_ => other(new Union<TError0, TError1, TError2>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<TError1, Task<TResult>> error1,
		Func<TError2, Task<TResult>> error2,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			_ => error2(u.Value3),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<Union<TError1, TError2>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			_ => other(new Union<TError1, TError2>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2>(this Result<TSuccess, TError0, TError1, TError2> result,
		Func<TSuccess, Task<TResult>> success,
		Func<Union<TError0, TError1, TError2>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			_ => other(new Union<TError0, TError1, TError2>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<TError1, TResult> error1,
		Func<TError2, TResult> error2,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			_ => error2(u.Value3),
			};
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<Union<TError1, TError2>, TResult> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			_ => other(new Union<TError1, TError2>(u.Value)),
			};
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2>(this Task<Result<TSuccess, TError0, TError1, TError2>> result,
		Func<TSuccess, TResult> success,
		Func<Union<TError0, TError1, TError2>, TResult> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => success(u.Value0),
			_ => other(new Union<TError0, TError1, TError2>(u.Value)),
			};
			
		}}
		