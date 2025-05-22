using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Result2Tap
{public static Result<TSuccess, TError0> TapSuccess<TSuccess, TError0>(this Result<TSuccess, TError0> result,
		Action<TSuccess> action){
		var u = (result).Value;
			if (u.Index == 0) action(u.Value0);
			return result;
			
		}

	public static Result<TSuccess, TError0> TapError0<TSuccess, TError0>(this Result<TSuccess, TError0> result,
		Action<TError0> action){
		var u = (result).Value;
			if (u.Index == 1) action(u.Value1);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0>> TapSuccess<TSuccess, TError0>(this Task<Result<TSuccess, TError0>> result,
		Func<TSuccess, Task> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0) await (action(u.Value0)).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0>> TapError0<TSuccess, TError0>(this Task<Result<TSuccess, TError0>> result,
		Func<TError0, Task> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1) await (action(u.Value1)).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0>> TapSuccess<TSuccess, TError0>(this Result<TSuccess, TError0> result,
		Func<TSuccess, Task> action,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0) await (action(u.Value0)).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0>> TapError0<TSuccess, TError0>(this Result<TSuccess, TError0> result,
		Func<TError0, Task> action,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1) await (action(u.Value1)).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0>> TapSuccess<TSuccess, TError0>(this Task<Result<TSuccess, TError0>> result,
		Action<TSuccess> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0) action(u.Value0);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0>> TapError0<TSuccess, TError0>(this Task<Result<TSuccess, TError0>> result,
		Action<TError0> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1) action(u.Value1);
			return await (result).ConfigureAwait(false);
			
		}}
		