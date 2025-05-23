using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Result8ToUnion
{public static Union<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> ToUnion<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result){
		return (result).Value;;
			
		}

	public static async Task<Union<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> ToUnion<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result){
		return (await (result).ConfigureAwait(false)).Value;;
			
		}}
		