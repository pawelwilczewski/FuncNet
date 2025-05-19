using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Union3Tap
{public static Union<T0, T1, T2> Tap0<T0, T1, T2>(this Union<T0, T1, T2> union,
		Action<T0> action){
		var u = union;
			if (u.Index == 0) action(u.Value0);
			return union;
			
		}

	public static Union<T0, T1, T2> Tap1<T0, T1, T2>(this Union<T0, T1, T2> union,
		Action<T1> action){
		var u = union;
			if (u.Index == 1) action(u.Value1);
			return union;
			
		}

	public static Union<T0, T1, T2> Tap2<T0, T1, T2>(this Union<T0, T1, T2> union,
		Action<T2> action){
		var u = union;
			if (u.Index == 2) action(u.Value2);
			return union;
			
		}

	public static async Task<Union<T0, T1, T2>> Tap0<T0, T1, T2>(this Task<Union<T0, T1, T2>> union,
		Func<T0, Task> action,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0) await (action(u.Value0)).ConfigureAwait(false);
			return await (union).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2>> Tap1<T0, T1, T2>(this Task<Union<T0, T1, T2>> union,
		Func<T1, Task> action,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1) await (action(u.Value1)).ConfigureAwait(false);
			return await (union).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2>> Tap2<T0, T1, T2>(this Task<Union<T0, T1, T2>> union,
		Func<T2, Task> action,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 2) await (action(u.Value2)).ConfigureAwait(false);
			return await (union).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2>> Tap0<T0, T1, T2>(this Union<T0, T1, T2> union,
		Func<T0, Task> action,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0) await (action(u.Value0)).ConfigureAwait(false);
			return union;
			
		}

	public static async Task<Union<T0, T1, T2>> Tap1<T0, T1, T2>(this Union<T0, T1, T2> union,
		Func<T1, Task> action,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1) await (action(u.Value1)).ConfigureAwait(false);
			return union;
			
		}

	public static async Task<Union<T0, T1, T2>> Tap2<T0, T1, T2>(this Union<T0, T1, T2> union,
		Func<T2, Task> action,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 2) await (action(u.Value2)).ConfigureAwait(false);
			return union;
			
		}

	public static async Task<Union<T0, T1, T2>> Tap0<T0, T1, T2>(this Task<Union<T0, T1, T2>> union,
		Action<T0> action,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0) action(u.Value0);
			return await (union).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2>> Tap1<T0, T1, T2>(this Task<Union<T0, T1, T2>> union,
		Action<T1> action,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1) action(u.Value1);
			return await (union).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2>> Tap2<T0, T1, T2>(this Task<Union<T0, T1, T2>> union,
		Action<T2> action,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 2) action(u.Value2);
			return await (union).ConfigureAwait(false);
			
		}}
		