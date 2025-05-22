using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Union6Match
{public static TResult Match<TResult, T0, T1, T2, T3, T4, T5>(this Union<T0, T1, T2, T3, T4, T5> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<T3, TResult> t3,
		Func<T4, TResult> t4,
		Func<T5, TResult> t5){
		var u = union;
			return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			3 => t3(u.Value3),
			4 => t4(u.Value4),
			_ => t5(u.Value5),
			};
			
		}

	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5>(this Union<T0, T1, T2, T3, T4, T5> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<T3, TResult> t3,
		Func<Union<T4, T5>, TResult> other){
		var u = union;
			return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			3 => t3(u.Value3),
			_ => other(new Union<T4, T5>(u.Value)),
			};
			
		}

	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5>(this Union<T0, T1, T2, T3, T4, T5> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<Union<T3, T4, T5>, TResult> other){
		var u = union;
			return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			_ => other(new Union<T3, T4, T5>(u.Value)),
			};
			
		}

	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5>(this Union<T0, T1, T2, T3, T4, T5> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<Union<T2, T3, T4, T5>, TResult> other){
		var u = union;
			return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			_ => other(new Union<T2, T3, T4, T5>(u.Value)),
			};
			
		}

	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5>(this Union<T0, T1, T2, T3, T4, T5> union,
		Func<T0, TResult> t0,
		Func<Union<T1, T2, T3, T4, T5>, TResult> other){
		var u = union;
			return u.Index switch
		{
			0 => t0(u.Value0),
			_ => other(new Union<T1, T2, T3, T4, T5>(u.Value)),
			};
			
		}

	public static async Task<TResult> Match<TResult, T0, T1, T2, T3, T4, T5>(this Task<Union<T0, T1, T2, T3, T4, T5>> union,
		Func<T0, Task<TResult>> t0,
		Func<T1, Task<TResult>> t1,
		Func<T2, Task<TResult>> t2,
		Func<T3, Task<TResult>> t3,
		Func<T4, Task<TResult>> t4,
		Func<T5, Task<TResult>> t5,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			3 => t3(u.Value3),
			4 => t4(u.Value4),
			_ => t5(u.Value5),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, T0, T1, T2, T3, T4, T5>(this Task<Union<T0, T1, T2, T3, T4, T5>> union,
		Func<T0, Task<TResult>> t0,
		Func<T1, Task<TResult>> t1,
		Func<T2, Task<TResult>> t2,
		Func<T3, Task<TResult>> t3,
		Func<Union<T4, T5>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			3 => t3(u.Value3),
			_ => other(new Union<T4, T5>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, T0, T1, T2, T3, T4, T5>(this Task<Union<T0, T1, T2, T3, T4, T5>> union,
		Func<T0, Task<TResult>> t0,
		Func<T1, Task<TResult>> t1,
		Func<T2, Task<TResult>> t2,
		Func<Union<T3, T4, T5>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			_ => other(new Union<T3, T4, T5>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, T0, T1, T2, T3, T4, T5>(this Task<Union<T0, T1, T2, T3, T4, T5>> union,
		Func<T0, Task<TResult>> t0,
		Func<T1, Task<TResult>> t1,
		Func<Union<T2, T3, T4, T5>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			_ => other(new Union<T2, T3, T4, T5>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, T0, T1, T2, T3, T4, T5>(this Task<Union<T0, T1, T2, T3, T4, T5>> union,
		Func<T0, Task<TResult>> t0,
		Func<Union<T1, T2, T3, T4, T5>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => t0(u.Value0),
			_ => other(new Union<T1, T2, T3, T4, T5>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, T0, T1, T2, T3, T4, T5>(this Union<T0, T1, T2, T3, T4, T5> union,
		Func<T0, Task<TResult>> t0,
		Func<T1, Task<TResult>> t1,
		Func<T2, Task<TResult>> t2,
		Func<T3, Task<TResult>> t3,
		Func<T4, Task<TResult>> t4,
		Func<T5, Task<TResult>> t5,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			3 => t3(u.Value3),
			4 => t4(u.Value4),
			_ => t5(u.Value5),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, T0, T1, T2, T3, T4, T5>(this Union<T0, T1, T2, T3, T4, T5> union,
		Func<T0, Task<TResult>> t0,
		Func<T1, Task<TResult>> t1,
		Func<T2, Task<TResult>> t2,
		Func<T3, Task<TResult>> t3,
		Func<Union<T4, T5>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			3 => t3(u.Value3),
			_ => other(new Union<T4, T5>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, T0, T1, T2, T3, T4, T5>(this Union<T0, T1, T2, T3, T4, T5> union,
		Func<T0, Task<TResult>> t0,
		Func<T1, Task<TResult>> t1,
		Func<T2, Task<TResult>> t2,
		Func<Union<T3, T4, T5>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			_ => other(new Union<T3, T4, T5>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, T0, T1, T2, T3, T4, T5>(this Union<T0, T1, T2, T3, T4, T5> union,
		Func<T0, Task<TResult>> t0,
		Func<T1, Task<TResult>> t1,
		Func<Union<T2, T3, T4, T5>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			_ => other(new Union<T2, T3, T4, T5>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, T0, T1, T2, T3, T4, T5>(this Union<T0, T1, T2, T3, T4, T5> union,
		Func<T0, Task<TResult>> t0,
		Func<Union<T1, T2, T3, T4, T5>, Task<TResult>> other,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => t0(u.Value0),
			_ => other(new Union<T1, T2, T3, T4, T5>(u.Value)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, T0, T1, T2, T3, T4, T5>(this Task<Union<T0, T1, T2, T3, T4, T5>> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<T3, TResult> t3,
		Func<T4, TResult> t4,
		Func<T5, TResult> t5,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			3 => t3(u.Value3),
			4 => t4(u.Value4),
			_ => t5(u.Value5),
			};
			
		}

	public static async Task<TResult> Match<TResult, T0, T1, T2, T3, T4, T5>(this Task<Union<T0, T1, T2, T3, T4, T5>> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<T3, TResult> t3,
		Func<Union<T4, T5>, TResult> other,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			3 => t3(u.Value3),
			_ => other(new Union<T4, T5>(u.Value)),
			};
			
		}

	public static async Task<TResult> Match<TResult, T0, T1, T2, T3, T4, T5>(this Task<Union<T0, T1, T2, T3, T4, T5>> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<Union<T3, T4, T5>, TResult> other,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			_ => other(new Union<T3, T4, T5>(u.Value)),
			};
			
		}

	public static async Task<TResult> Match<TResult, T0, T1, T2, T3, T4, T5>(this Task<Union<T0, T1, T2, T3, T4, T5>> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<Union<T2, T3, T4, T5>, TResult> other,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			_ => other(new Union<T2, T3, T4, T5>(u.Value)),
			};
			
		}

	public static async Task<TResult> Match<TResult, T0, T1, T2, T3, T4, T5>(this Task<Union<T0, T1, T2, T3, T4, T5>> union,
		Func<T0, TResult> t0,
		Func<Union<T1, T2, T3, T4, T5>, TResult> other,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => t0(u.Value0),
			_ => other(new Union<T1, T2, T3, T4, T5>(u.Value)),
			};
			
		}}
		