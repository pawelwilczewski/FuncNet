using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result7Tap
{public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> TapSuccess<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Action<TSuccess> action){
		var u = (result).Value;
			;
			if (u.Index == 0) action(u.Value0);
			return result;
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> TapError0<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Action<TError0> action){
		var u = (result).Value;
			;
			if (u.Index == 1) action(u.Value1);
			return result;
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> TapError1<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Action<TError1> action){
		var u = (result).Value;
			;
			if (u.Index == 2) action(u.Value2);
			return result;
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> TapError2<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Action<TError2> action){
		var u = (result).Value;
			;
			if (u.Index == 3) action(u.Value3);
			return result;
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> TapError3<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Action<TError3> action){
		var u = (result).Value;
			;
			if (u.Index == 4) action(u.Value4);
			return result;
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> TapError4<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Action<TError4> action){
		var u = (result).Value;
			;
			if (u.Index == 5) action(u.Value5);
			return result;
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> TapError5<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Action<TError5> action){
		var u = (result).Value;
			;
			if (u.Index == 6) action(u.Value6);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapSuccess<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TSuccess, Task> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0) await (action(u.Value0)).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError0<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError0, Task> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1) await (action(u.Value1)).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError1<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError1, Task> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 2) await (action(u.Value2)).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError2<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError2, Task> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 3) await (action(u.Value3)).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError3<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError3, Task> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 4) await (action(u.Value4)).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError4<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError4, Task> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 5) await (action(u.Value5)).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError5<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Func<TError5, Task> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 6) await (action(u.Value6)).ConfigureAwait(false);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapSuccess<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TSuccess, Task> action,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0) await (action(u.Value0)).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError0<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError0, Task> action,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1) await (action(u.Value1)).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError1<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError1, Task> action,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 2) await (action(u.Value2)).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError2<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError2, Task> action,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 3) await (action(u.Value3)).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError3<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError3, Task> action,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 4) await (action(u.Value4)).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError4<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError4, Task> action,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 5) await (action(u.Value5)).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError5<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result,
		Func<TError5, Task> action,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 6) await (action(u.Value6)).ConfigureAwait(false);
			return result;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapSuccess<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Action<TSuccess> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 0) action(u.Value0);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError0<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Action<TError0> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 1) action(u.Value1);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError1<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Action<TError1> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 2) action(u.Value2);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError2<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Action<TError2> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 3) action(u.Value3);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError3<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Action<TError3> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 4) action(u.Value4);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError4<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Action<TError4> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 5) action(u.Value5);
			return await (result).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> TapError5<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result,
		Action<TError5> action,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			if (u.Index == 6) action(u.Value6);
			return await (result).ConfigureAwait(false);
			
		}}
		