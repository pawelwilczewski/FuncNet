using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result3Ensure
{public static Result<TSuccess, TError0, TError1> EnsureSuccess<TSuccess, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TSuccess, bool> predicate,
		Func<Result<TSuccess, TError0, TError1>> otherwise){
		var u = (result).Value;
			;
			if (u.Index == 0 && !(predicate(u.Value0))) return otherwise();
			return result;
			
		}

	public static Result<TSuccess, TError0, TError1> EnsureError0<TSuccess, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TError0, bool> predicate,
		Func<Result<TSuccess, TError0, TError1>> otherwise){
		var u = (result).Value;
			;
			if (u.Index == 1 && !(predicate(u.Value1))) return otherwise();
			return result;
			
		}

	public static Result<TSuccess, TError0, TError1> EnsureError1<TSuccess, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TError1, bool> predicate,
		Func<Result<TSuccess, TError0, TError1>> otherwise){
		var u = (result).Value;
			;
			if (u.Index == 2 && !(predicate(u.Value2))) return otherwise();
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1>> EnsureSuccess<TSuccess, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TSuccess, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0 && !(await (predicate(u.Value0)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1>> EnsureError0<TSuccess, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TError0, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1 && !(await (predicate(u.Value1)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1>> EnsureError1<TSuccess, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TError1, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 2 && !(await (predicate(u.Value2)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1>> EnsureSuccess<TSuccess, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TSuccess, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0 && !(await (predicate(u.Value0)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1>> EnsureError0<TSuccess, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TError0, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1 && !(await (predicate(u.Value1)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1>> EnsureError1<TSuccess, TError0, TError1>(this Result<TSuccess, TError0, TError1> result,
		Func<TError1, Task<bool>> predicate,
		Func<Task<Result<TSuccess, TError0, TError1>>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 2 && !(await (predicate(u.Value2)).ConfigureAwait(false))) return await (otherwise()).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1>> EnsureSuccess<TSuccess, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TSuccess, bool> predicate,
		Func<Result<TSuccess, TError0, TError1>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0 && !(predicate(u.Value0))) return otherwise();
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1>> EnsureError0<TSuccess, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TError0, bool> predicate,
		Func<Result<TSuccess, TError0, TError1>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1 && !(predicate(u.Value1))) return otherwise();
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1>> EnsureError1<TSuccess, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result,
		Func<TError1, bool> predicate,
		Func<Result<TSuccess, TError0, TError1>> otherwise,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 2 && !(predicate(u.Value2))) return otherwise();
			return await (result).ConfigureAwait(false);
			
		}}
		