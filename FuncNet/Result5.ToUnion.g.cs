using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Result5ToUnion
{public static Union<TSuccess, TError0, TError1, TError2, TError3> ToUnion<TSuccess, TError0, TError1, TError2, TError3>(this Result<TSuccess, TError0, TError1, TError2, TError3> result){
		return (result).Value;;
			
		}

	public static async Task<Union<TSuccess, TError0, TError1, TError2, TError3>> ToUnion<TSuccess, TError0, TError1, TError2, TError3>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3>> result){
		return (await (result).ConfigureAwait(false)).Value;;
			
		}}
		