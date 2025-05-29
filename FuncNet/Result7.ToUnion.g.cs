using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Result7ToUnion
{public static Union<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> ToUnion<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5> result){
		return (result).Value;;
			
		}

	public static async Task<Union<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> ToUnion<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5>> result){
		return (await (result).ConfigureAwait(false)).Value;;
			
		}}
		