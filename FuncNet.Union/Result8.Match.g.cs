using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result8Match
{public static TResult Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<TError1, TResult> error1,
		Func<TError2, TResult> error2,
		Func<TError3, TResult> error3,
		Func<TError4, TResult> error4,
		Func<TError5, TResult> error5,
		Func<TError6, TResult> error6){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			4 => error3(u.Value4),
			5 => error4(u.Value5),
			6 => error5(u.Value6),
			_ => error6(u.Value7),
			};
			
		}

	public static TResult Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<TError1, TResult> error1,
		Func<TError2, TResult> error2,
		Func<TError3, TResult> error3,
		Func<TError4, TResult> error4,
		Func<Union<TError5, TError6>, TResult> other){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			4 => error3(u.Value4),
			5 => error4(u.Value5),
			_ => other(new Union<TError5, TError6>(u.Value)),
			};
			
		}

	public static TResult Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<TError1, TResult> error1,
		Func<TError2, TResult> error2,
		Func<TError3, TResult> error3,
		Func<Union<TError4, TError5, TError6>, TResult> other){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			4 => error3(u.Value4),
			_ => other(new Union<TError4, TError5, TError6>(u.Value)),
			};
			
		}

	public static TResult Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<TError1, TResult> error1,
		Func<TError2, TResult> error2,
		Func<Union<TError3, TError4, TError5, TError6>, TResult> other){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			_ => other(new Union<TError3, TError4, TError5, TError6>(u.Value)),
			};
			
		}

	public static TResult Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<TError1, TResult> error1,
		Func<Union<TError2, TError3, TError4, TError5, TError6>, TResult> other){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			_ => other(new Union<TError2, TError3, TError4, TError5, TError6>(u.Value)),
			};
			
		}

	public static TResult Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<Union<TError1, TError2, TError3, TError4, TError5, TError6>, TResult> other){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			_ => other(new Union<TError1, TError2, TError3, TError4, TError5, TError6>(u.Value)),
			};
			
		}

	public static TResult Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccess, TResult> success,
		Func<Union<TError0, TError1, TError2, TError3, TError4, TError5, TError6>, TResult> other){
		var u = (result).Value;
			;
			return u.Index switch
		{
			0 => success(u.Value0),
			_ => other(new Union<TError0, TError1, TError2, TError3, TError4, TError5, TError6>(u.Value)),
			};
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<TError1, Task<TResult>> error1,
		Func<TError2, Task<TResult>> error2,
		Func<TError3, Task<TResult>> error3,
		Func<TError4, Task<TResult>> error4,
		Func<TError5, Task<TResult>> error5,
		Func<TError6, Task<TResult>> error6,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			4 => error3(u.Value4),
			5 => error4(u.Value5),
			6 => error5(u.Value6),
			_ => error6(u.Value7),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<TError1, Task<TResult>> error1,
		Func<TError2, Task<TResult>> error2,
		Func<TError3, Task<TResult>> error3,
		Func<TError4, Task<TResult>> error4,
		Func<Union<TError5, TError6>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			4 => error3(u.Value4),
			5 => error4(u.Value5),
			_ => other(new Union<TError5, TError6>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<TError1, Task<TResult>> error1,
		Func<TError2, Task<TResult>> error2,
		Func<TError3, Task<TResult>> error3,
		Func<Union<TError4, TError5, TError6>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			4 => error3(u.Value4),
			_ => other(new Union<TError4, TError5, TError6>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<TError1, Task<TResult>> error1,
		Func<TError2, Task<TResult>> error2,
		Func<Union<TError3, TError4, TError5, TError6>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			_ => other(new Union<TError3, TError4, TError5, TError6>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<TError1, Task<TResult>> error1,
		Func<Union<TError2, TError3, TError4, TError5, TError6>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			_ => other(new Union<TError2, TError3, TError4, TError5, TError6>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<Union<TError1, TError2, TError3, TError4, TError5, TError6>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			_ => other(new Union<TError1, TError2, TError3, TError4, TError5, TError6>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccess, Task<TResult>> success,
		Func<Union<TError0, TError1, TError2, TError3, TError4, TError5, TError6>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			_ => other(new Union<TError0, TError1, TError2, TError3, TError4, TError5, TError6>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<TError1, Task<TResult>> error1,
		Func<TError2, Task<TResult>> error2,
		Func<TError3, Task<TResult>> error3,
		Func<TError4, Task<TResult>> error4,
		Func<TError5, Task<TResult>> error5,
		Func<TError6, Task<TResult>> error6,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			4 => error3(u.Value4),
			5 => error4(u.Value5),
			6 => error5(u.Value6),
			_ => error6(u.Value7),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<TError1, Task<TResult>> error1,
		Func<TError2, Task<TResult>> error2,
		Func<TError3, Task<TResult>> error3,
		Func<TError4, Task<TResult>> error4,
		Func<Union<TError5, TError6>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			4 => error3(u.Value4),
			5 => error4(u.Value5),
			_ => other(new Union<TError5, TError6>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<TError1, Task<TResult>> error1,
		Func<TError2, Task<TResult>> error2,
		Func<TError3, Task<TResult>> error3,
		Func<Union<TError4, TError5, TError6>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			4 => error3(u.Value4),
			_ => other(new Union<TError4, TError5, TError6>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<TError1, Task<TResult>> error1,
		Func<TError2, Task<TResult>> error2,
		Func<Union<TError3, TError4, TError5, TError6>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			_ => other(new Union<TError3, TError4, TError5, TError6>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<TError1, Task<TResult>> error1,
		Func<Union<TError2, TError3, TError4, TError5, TError6>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			_ => other(new Union<TError2, TError3, TError4, TError5, TError6>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccess, Task<TResult>> success,
		Func<TError0, Task<TResult>> error0,
		Func<Union<TError1, TError2, TError3, TError4, TError5, TError6>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			_ => other(new Union<TError1, TError2, TError3, TError4, TError5, TError6>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccess, Task<TResult>> success,
		Func<Union<TError0, TError1, TError2, TError3, TError4, TError5, TError6>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => success(u.Value0),
			_ => other(new Union<TError0, TError1, TError2, TError3, TError4, TError5, TError6>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<TError1, TResult> error1,
		Func<TError2, TResult> error2,
		Func<TError3, TResult> error3,
		Func<TError4, TResult> error4,
		Func<TError5, TResult> error5,
		Func<TError6, TResult> error6,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			4 => error3(u.Value4),
			5 => error4(u.Value5),
			6 => error5(u.Value6),
			_ => error6(u.Value7),
			};
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<TError1, TResult> error1,
		Func<TError2, TResult> error2,
		Func<TError3, TResult> error3,
		Func<TError4, TResult> error4,
		Func<Union<TError5, TError6>, TResult> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			4 => error3(u.Value4),
			5 => error4(u.Value5),
			_ => other(new Union<TError5, TError6>(u.Value)),
			};
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<TError1, TResult> error1,
		Func<TError2, TResult> error2,
		Func<TError3, TResult> error3,
		Func<Union<TError4, TError5, TError6>, TResult> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			4 => error3(u.Value4),
			_ => other(new Union<TError4, TError5, TError6>(u.Value)),
			};
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<TError1, TResult> error1,
		Func<TError2, TResult> error2,
		Func<Union<TError3, TError4, TError5, TError6>, TResult> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			3 => error2(u.Value3),
			_ => other(new Union<TError3, TError4, TError5, TError6>(u.Value)),
			};
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<TError1, TResult> error1,
		Func<Union<TError2, TError3, TError4, TError5, TError6>, TResult> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			2 => error1(u.Value2),
			_ => other(new Union<TError2, TError3, TError4, TError5, TError6>(u.Value)),
			};
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccess, TResult> success,
		Func<TError0, TResult> error0,
		Func<Union<TError1, TError2, TError3, TError4, TError5, TError6>, TResult> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => success(u.Value0),
			1 => error0(u.Value1),
			_ => other(new Union<TError1, TError2, TError3, TError4, TError5, TError6>(u.Value)),
			};
			
		}

	public static async Task<TResult> Match<TResult, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccess, TResult> success,
		Func<Union<TError0, TError1, TError2, TError3, TError4, TError5, TError6>, TResult> other,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => success(u.Value0),
			_ => other(new Union<TError0, TError1, TError2, TError3, TError4, TError5, TError6>(u.Value)),
			};
			
		}}
		