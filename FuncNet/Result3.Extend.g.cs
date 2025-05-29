using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Result3Extend
{public static Result<TSuccess, TError0, TError1, T3> Extend<TSuccess, TError0, TError1, T3>(this Result<TSuccess, TError0, TError1> result){
		Result<TSuccess, TError0, TError1, T3> extended = result;
			return extended;
			
		}

	public static Result<TSuccess, TError0, TError1, T3, T4> Extend<TSuccess, TError0, TError1, T3, T4>(this Result<TSuccess, TError0, TError1> result){
		Result<TSuccess, TError0, TError1, T3, T4> extended = result;
			return extended;
			
		}

	public static Result<TSuccess, TError0, TError1, T3, T4, T5> Extend<TSuccess, TError0, TError1, T3, T4, T5>(this Result<TSuccess, TError0, TError1> result){
		Result<TSuccess, TError0, TError1, T3, T4, T5> extended = result;
			return extended;
			
		}

	public static Result<TSuccess, TError0, TError1, T3, T4, T5, T6> Extend<TSuccess, TError0, TError1, T3, T4, T5, T6>(this Result<TSuccess, TError0, TError1> result){
		Result<TSuccess, TError0, TError1, T3, T4, T5, T6> extended = result;
			return extended;
			
		}

	public static Result<TSuccess, TError0, TError1, T3, T4, T5, T6, T7> Extend<TSuccess, TError0, TError1, T3, T4, T5, T6, T7>(this Result<TSuccess, TError0, TError1> result){
		Result<TSuccess, TError0, TError1, T3, T4, T5, T6, T7> extended = result;
			return extended;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, T3>> Extend<TSuccess, TError0, TError1, T3>(this Task<Result<TSuccess, TError0, TError1>> result){
		Result<TSuccess, TError0, TError1, T3> extended = await (result).ConfigureAwait(false);
			return extended;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, T3, T4>> Extend<TSuccess, TError0, TError1, T3, T4>(this Task<Result<TSuccess, TError0, TError1>> result){
		Result<TSuccess, TError0, TError1, T3, T4> extended = await (result).ConfigureAwait(false);
			return extended;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, T3, T4, T5>> Extend<TSuccess, TError0, TError1, T3, T4, T5>(this Task<Result<TSuccess, TError0, TError1>> result){
		Result<TSuccess, TError0, TError1, T3, T4, T5> extended = await (result).ConfigureAwait(false);
			return extended;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, T3, T4, T5, T6>> Extend<TSuccess, TError0, TError1, T3, T4, T5, T6>(this Task<Result<TSuccess, TError0, TError1>> result){
		Result<TSuccess, TError0, TError1, T3, T4, T5, T6> extended = await (result).ConfigureAwait(false);
			return extended;
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, T3, T4, T5, T6, T7>> Extend<TSuccess, TError0, TError1, T3, T4, T5, T6, T7>(this Task<Result<TSuccess, TError0, TError1>> result){
		Result<TSuccess, TError0, TError1, T3, T4, T5, T6, T7> extended = await (result).ConfigureAwait(false);
			return extended;
			
		}}
		