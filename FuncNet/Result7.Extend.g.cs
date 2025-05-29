using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Result7Extend
{public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, T7> Extend<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, T7>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result){
		Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, T7> extended = result;
			return extended;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, T7>> Extend<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, T7>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result){
		Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, T7> extended = await (result).ConfigureAwait(false);
			return extended;
			
		}}
		