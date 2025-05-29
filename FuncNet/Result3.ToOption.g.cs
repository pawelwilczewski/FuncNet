using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Result3ToOption
{public static Option<TSuccess> ToOption<TSuccess, TError0, TError1>(this Result<TSuccess, TError0, TError1> result){
		var r = result;
			return r.IsSuccess ? Option<TSuccess>.Some(r.Value.Value0) : Option<TSuccess>.None;;
			
		}

	public static async Task<Option<TSuccess>> ToOption<TSuccess, TError0, TError1>(this Task<Result<TSuccess, TError0, TError1>> result){
		var r = await (result).ConfigureAwait(false);
			return r.IsSuccess ? Option<TSuccess>.Some(r.Value.Value0) : Option<TSuccess>.None;;
			
		}}
		