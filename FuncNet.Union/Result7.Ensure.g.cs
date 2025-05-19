using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result7Ensure
{public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> EnsureSuccess<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TSuccess, bool> predicate,
		Func<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> otherwise){
		var u = (result).Value;
			if (u.Index == 0 && !(predicate(u.Value0))) return otherwise();
			return result;
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> EnsureError0<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError0, bool> predicate,
		Func<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> otherwise){
		var u = (result).Value;
			if (u.Index == 1 && !(predicate(u.Value1))) return otherwise();
			return result;
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> EnsureError1<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError1, bool> predicate,
		Func<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> otherwise){
		var u = (result).Value;
			if (u.Index == 2 && !(predicate(u.Value2))) return otherwise();
			return result;
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> EnsureError2<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError2, bool> predicate,
		Func<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> otherwise){
		var u = (result).Value;
			if (u.Index == 3 && !(predicate(u.Value3))) return otherwise();
			return result;
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> EnsureError3<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError3, bool> predicate,
		Func<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> otherwise){
		var u = (result).Value;
			if (u.Index == 4 && !(predicate(u.Value4))) return otherwise();
			return result;
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> EnsureError4<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError4, bool> predicate,
		Func<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> otherwise){
		var u = (result).Value;
			if (u.Index == 5 && !(predicate(u.Value5))) return otherwise();
			return result;
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> EnsureError5<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError5, bool> predicate,
		Func<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> otherwise){
		var u = (result).Value;
			if (u.Index == 6 && !(predicate(u.Value6))) return otherwise();
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureSuccess<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TSuccess, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0 && !(await (predicate(u.Value0)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError0<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError0, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1 && !(await (predicate(u.Value1)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError1<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError1, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 2 && !(await (predicate(u.Value2)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError2<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError2, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 3 && !(await (predicate(u.Value3)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError3<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError3, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 4 && !(await (predicate(u.Value4)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError4<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError4, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 5 && !(await (predicate(u.Value5)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError5<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError5, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 6 && !(await (predicate(u.Value6)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureSuccess<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TSuccess, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0 && !(await (predicate(u.Value0)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError0<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError0, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1 && !(await (predicate(u.Value1)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError1<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError1, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 2 && !(await (predicate(u.Value2)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError2<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError2, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 3 && !(await (predicate(u.Value3)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError3<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError3, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 4 && !(await (predicate(u.Value4)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError4<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError4, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 5 && !(await (predicate(u.Value5)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError5<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError5, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 6 && !(await (predicate(u.Value6)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureSuccess<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TSuccess, bool> predicate,
		Func<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0 && !(predicate(u.Value0))) return otherwise();
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError0<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError0, bool> predicate,
		Func<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1 && !(predicate(u.Value1))) return otherwise();
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError1<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError1, bool> predicate,
		Func<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 2 && !(predicate(u.Value2))) return otherwise();
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError2<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError2, bool> predicate,
		Func<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 3 && !(predicate(u.Value3))) return otherwise();
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError3<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError3, bool> predicate,
		Func<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 4 && !(predicate(u.Value4))) return otherwise();
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError4<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError4, bool> predicate,
		Func<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 5 && !(predicate(u.Value5))) return otherwise();
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> EnsureError5<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError5, bool> predicate,
		Func<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 6 && !(predicate(u.Value6))) return otherwise();
			return await (result).ConfigureAwait(false);
			
		}}
		