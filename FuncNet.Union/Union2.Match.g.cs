using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Union2Match
{public static TResult Match<TResult, T0, T1>(this Union<T0, T1> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1){
		var u = union;
			return u.Index switch
		{
			0 => t0(u.Value0),
			_ => t1(u.Value1),
			};
			
		}

	public static async Task<TResult> Match<TResult, T0, T1>(this Task<Union<T0, T1>> union,
		Func<T0, Task<TResult>> t0,
		Func<T1, Task<TResult>> t1,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => t0(u.Value0),
			_ => t1(u.Value1),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, T0, T1>(this Union<T0, T1> union,
		Func<T0, Task<TResult>> t0,
		Func<T1, Task<TResult>> t1,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => t0(u.Value0),
			_ => t1(u.Value1),
			}).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Match<TResult, T0, T1>(this Task<Union<T0, T1>> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => t0(u.Value0),
			_ => t1(u.Value1),
			};
			
		}}
		