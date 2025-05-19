using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

#nullable enable

namespace FuncNet.Union;
		public static class Result2Zip
{public static TResult Zip<TResult, TSuccess, TError0>(this IEnumerable<Result<TSuccess, TError0>> values,
		Func<IEnumerable<TSuccess>, IEnumerable<TError0>, TResult> zip){
		var results = (values).ToArray();
			return zip(results.Where(x => (x).Value.Index == 0).Select(x => (x).Value.Value0), results.Where(x => (x).Value.Index == 1).Select(x => (x).Value.Value1));
			
		}

	public static async Task<TResult> Zip<TResult, TSuccess, TError0>(this IEnumerable<Task<Result<TSuccess, TError0>>> values,
		Func<IEnumerable<TSuccess>, IEnumerable<TError0>, Task<TResult>> zip,
		CancellationToken cancellationToken = default){
		var results = (await (Task.WhenAll(values)).ConfigureAwait(false)).ToArray();
			return await (zip(results.Where(x => (x).Value.Index == 0).Select(x => (x).Value.Value0), results.Where(x => (x).Value.Index == 1).Select(x => (x).Value.Value1))).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Zip<TResult, TSuccess, TError0>(this IEnumerable<Result<TSuccess, TError0>> values,
		Func<IEnumerable<TSuccess>, IEnumerable<TError0>, Task<TResult>> zip,
		CancellationToken cancellationToken = default){
		var results = (values).ToArray();
			return await (zip(results.Where(x => (x).Value.Index == 0).Select(x => (x).Value.Value0), results.Where(x => (x).Value.Index == 1).Select(x => (x).Value.Value1))).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Zip<TResult, TSuccess, TError0>(this IEnumerable<Task<Result<TSuccess, TError0>>> values,
		Func<IEnumerable<TSuccess>, IEnumerable<TError0>, TResult> zip,
		CancellationToken cancellationToken = default){
		var results = (await (Task.WhenAll(values)).ConfigureAwait(false)).ToArray();
			return zip(results.Where(x => (x).Value.Index == 0).Select(x => (x).Value.Value0), results.Where(x => (x).Value.Index == 1).Select(x => (x).Value.Value1));
			
		}}
		