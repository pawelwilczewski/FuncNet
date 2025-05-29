using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Result6Extend
{public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, T6> Extend<TSuccess, TError0, TError1, TError2, TError3, TError4, T6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4> result){
		Result<TSuccess, TError0, TError1, TError2, TError3, TError4, T6> extended = result;
			return extended;
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, T6, T7> Extend<TSuccess, TError0, TError1, TError2, TError3, TError4, T6, T7>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4> result){
		Result<TSuccess, TError0, TError1, TError2, TError3, TError4, T6, T7> extended = result;
			return extended;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, T6>> Extend<TSuccess, TError0, TError1, TError2, TError3, TError4, T6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> result){
		Result<TSuccess, TError0, TError1, TError2, TError3, TError4, T6> extended = await (result).ConfigureAwait(false);
			return extended;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, T6, T7>> Extend<TSuccess, TError0, TError1, TError2, TError3, TError4, T6, T7>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4>> result){
		Result<TSuccess, TError0, TError1, TError2, TError3, TError4, T6, T7> extended = await (result).ConfigureAwait(false);
			return extended;
			
		}}
		