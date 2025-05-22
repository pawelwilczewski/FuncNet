using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Union5Filter
{public static Union<T0, T1, T2, T3, T4> Filter0<T0, T1, T2, T3, T4>(this Union<T0, T1, T2, T3, T4> union,
		Func<T0, bool> predicate,
		Func<Union<T0, T1, T2, T3, T4>> otherwise){
		var u = union;
			if (u.Index == 0 && !(predicate(u.Value0))) return otherwise();
			return union;
			
		}

	public static Union<T0, T1, T2, T3, T4> Filter1<T0, T1, T2, T3, T4>(this Union<T0, T1, T2, T3, T4> union,
		Func<T1, bool> predicate,
		Func<Union<T0, T1, T2, T3, T4>> otherwise){
		var u = union;
			if (u.Index == 1 && !(predicate(u.Value1))) return otherwise();
			return union;
			
		}

	public static Union<T0, T1, T2, T3, T4> Filter2<T0, T1, T2, T3, T4>(this Union<T0, T1, T2, T3, T4> union,
		Func<T2, bool> predicate,
		Func<Union<T0, T1, T2, T3, T4>> otherwise){
		var u = union;
			if (u.Index == 2 && !(predicate(u.Value2))) return otherwise();
			return union;
			
		}

	public static Union<T0, T1, T2, T3, T4> Filter3<T0, T1, T2, T3, T4>(this Union<T0, T1, T2, T3, T4> union,
		Func<T3, bool> predicate,
		Func<Union<T0, T1, T2, T3, T4>> otherwise){
		var u = union;
			if (u.Index == 3 && !(predicate(u.Value3))) return otherwise();
			return union;
			
		}

	public static Union<T0, T1, T2, T3, T4> Filter4<T0, T1, T2, T3, T4>(this Union<T0, T1, T2, T3, T4> union,
		Func<T4, bool> predicate,
		Func<Union<T0, T1, T2, T3, T4>> otherwise){
		var u = union;
			if (u.Index == 4 && !(predicate(u.Value4))) return otherwise();
			return union;
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Filter0<T0, T1, T2, T3, T4>(this Task<Union<T0, T1, T2, T3, T4>> union,
		Func<T0, Task<bool>> predicate,
		Func<Task<Union<T0, T1, T2, T3, T4>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0 && !(await (predicate(u.Value0)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return await (union).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Filter1<T0, T1, T2, T3, T4>(this Task<Union<T0, T1, T2, T3, T4>> union,
		Func<T1, Task<bool>> predicate,
		Func<Task<Union<T0, T1, T2, T3, T4>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1 && !(await (predicate(u.Value1)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return await (union).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Filter2<T0, T1, T2, T3, T4>(this Task<Union<T0, T1, T2, T3, T4>> union,
		Func<T2, Task<bool>> predicate,
		Func<Task<Union<T0, T1, T2, T3, T4>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 2 && !(await (predicate(u.Value2)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return await (union).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Filter3<T0, T1, T2, T3, T4>(this Task<Union<T0, T1, T2, T3, T4>> union,
		Func<T3, Task<bool>> predicate,
		Func<Task<Union<T0, T1, T2, T3, T4>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 3 && !(await (predicate(u.Value3)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return await (union).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Filter4<T0, T1, T2, T3, T4>(this Task<Union<T0, T1, T2, T3, T4>> union,
		Func<T4, Task<bool>> predicate,
		Func<Task<Union<T0, T1, T2, T3, T4>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 4 && !(await (predicate(u.Value4)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return await (union).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Filter0<T0, T1, T2, T3, T4>(this Union<T0, T1, T2, T3, T4> union,
		Func<T0, Task<bool>> predicate,
		Func<Task<Union<T0, T1, T2, T3, T4>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0 && !(await (predicate(u.Value0)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return union;
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Filter1<T0, T1, T2, T3, T4>(this Union<T0, T1, T2, T3, T4> union,
		Func<T1, Task<bool>> predicate,
		Func<Task<Union<T0, T1, T2, T3, T4>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1 && !(await (predicate(u.Value1)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return union;
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Filter2<T0, T1, T2, T3, T4>(this Union<T0, T1, T2, T3, T4> union,
		Func<T2, Task<bool>> predicate,
		Func<Task<Union<T0, T1, T2, T3, T4>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 2 && !(await (predicate(u.Value2)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return union;
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Filter3<T0, T1, T2, T3, T4>(this Union<T0, T1, T2, T3, T4> union,
		Func<T3, Task<bool>> predicate,
		Func<Task<Union<T0, T1, T2, T3, T4>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 3 && !(await (predicate(u.Value3)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return union;
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Filter4<T0, T1, T2, T3, T4>(this Union<T0, T1, T2, T3, T4> union,
		Func<T4, Task<bool>> predicate,
		Func<Task<Union<T0, T1, T2, T3, T4>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 4 && !(await (predicate(u.Value4)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return union;
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Filter0<T0, T1, T2, T3, T4>(this Task<Union<T0, T1, T2, T3, T4>> union,
		Func<T0, bool> predicate,
		Func<Union<T0, T1, T2, T3, T4>> otherwise,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0 && !(predicate(u.Value0))) return otherwise();
			return await (union).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Filter1<T0, T1, T2, T3, T4>(this Task<Union<T0, T1, T2, T3, T4>> union,
		Func<T1, bool> predicate,
		Func<Union<T0, T1, T2, T3, T4>> otherwise,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1 && !(predicate(u.Value1))) return otherwise();
			return await (union).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Filter2<T0, T1, T2, T3, T4>(this Task<Union<T0, T1, T2, T3, T4>> union,
		Func<T2, bool> predicate,
		Func<Union<T0, T1, T2, T3, T4>> otherwise,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 2 && !(predicate(u.Value2))) return otherwise();
			return await (union).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Filter3<T0, T1, T2, T3, T4>(this Task<Union<T0, T1, T2, T3, T4>> union,
		Func<T3, bool> predicate,
		Func<Union<T0, T1, T2, T3, T4>> otherwise,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 3 && !(predicate(u.Value3))) return otherwise();
			return await (union).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Filter4<T0, T1, T2, T3, T4>(this Task<Union<T0, T1, T2, T3, T4>> union,
		Func<T4, bool> predicate,
		Func<Union<T0, T1, T2, T3, T4>> otherwise,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 4 && !(predicate(u.Value4))) return otherwise();
			return await (union).ConfigureAwait(false);
			
		}}
		