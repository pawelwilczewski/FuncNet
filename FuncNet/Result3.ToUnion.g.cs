using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Result3ToUnion
{public static Union<TSuccess, TError0, TError1> ToUnion<TSuccess, TError0, TError1>(this Result<TSuccess, TError0, TError1> result){
		return (result).Value;;
			
		}

	public static async Task<Union<TSuccess, TError0, TError1>> ToUnion<TSuccess, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result){
		return (await (result).ConfigureAwait(false)).Value;;
			
		}}
		