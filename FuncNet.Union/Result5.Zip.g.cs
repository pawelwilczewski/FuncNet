using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

#nullable enable

namespace FuncNet.Union;
		public static class Result5Zip
{public static TResult Zip<TResult, TSuccess, TError0, TError1, TError2, TError3>(this IEnumerable<Result<TSuccess, TError0, TError1, TError2, TError3>> values,
		Func<IEnumerable<TSuccess>, IEnumerable<TError0>, IEnumerable<TError1>, IEnumerable<TError2>, IEnumerable<TError3>, TResult> zip){
		var results = (values).ToArray();
			return zip(results.Where(x => (x).Value.Index == 0).Select(x => (x).Value.Value0), results.Where(x => (x).Value.Index == 1).Select(x => (x).Value.Value1), results.Where(x => (x).Value.Index == 2).Select(x => (x).Value.Value2), results.Where(x => (x).Value.Index == 3).Select(x => (x).Value.Value3), results.Where(x => (x).Value.Index == 4).Select(x => (x).Value.Value4));
			
		}

	public static async Task<TResult> Zip<TResult, TSuccess, TError0, TError1, TError2, TError3>(this IEnumerable<Task<Result<TSuccess, TError0, TError1, TError2, TError3>>> values,
		Func<IEnumerable<TSuccess>, IEnumerable<TError0>, IEnumerable<TError1>, IEnumerable<TError2>, IEnumerable<TError3>, Task<TResult>> zip,
		CancellationToken cancellationToken = default){
		var results = (await (Task.WhenAll(values)).ConfigureAwait(false)).ToArray();
			return await (zip(results.Where(x => (x).Value.Index == 0).Select(x => (x).Value.Value0), results.Where(x => (x).Value.Index == 1).Select(x => (x).Value.Value1), results.Where(x => (x).Value.Index == 2).Select(x => (x).Value.Value2), results.Where(x => (x).Value.Index == 3).Select(x => (x).Value.Value3), results.Where(x => (x).Value.Index == 4).Select(x => (x).Value.Value4))).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Zip<TResult, TSuccess, TError0, TError1, TError2, TError3>(this IEnumerable<Result<TSuccess, TError0, TError1, TError2, TError3>> values,
		Func<IEnumerable<TSuccess>, IEnumerable<TError0>, IEnumerable<TError1>, IEnumerable<TError2>, IEnumerable<TError3>, Task<TResult>> zip,
		CancellationToken cancellationToken = default){
		var results = (values).ToArray();
			return await (zip(results.Where(x => (x).Value.Index == 0).Select(x => (x).Value.Value0), results.Where(x => (x).Value.Index == 1).Select(x => (x).Value.Value1), results.Where(x => (x).Value.Index == 2).Select(x => (x).Value.Value2), results.Where(x => (x).Value.Index == 3).Select(x => (x).Value.Value3), results.Where(x => (x).Value.Index == 4).Select(x => (x).Value.Value4))).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Zip<TResult, TSuccess, TError0, TError1, TError2, TError3>(this IEnumerable<Task<Result<TSuccess, TError0, TError1, TError2, TError3>>> values,
		Func<IEnumerable<TSuccess>, IEnumerable<TError0>, IEnumerable<TError1>, IEnumerable<TError2>, IEnumerable<TError3>, TResult> zip,
		CancellationToken cancellationToken = default){
		var results = (await (Task.WhenAll(values)).ConfigureAwait(false)).ToArray();
			return zip(results.Where(x => (x).Value.Index == 0).Select(x => (x).Value.Value0), results.Where(x => (x).Value.Index == 1).Select(x => (x).Value.Value1), results.Where(x => (x).Value.Index == 2).Select(x => (x).Value.Value2), results.Where(x => (x).Value.Index == 3).Select(x => (x).Value.Value3), results.Where(x => (x).Value.Index == 4).Select(x => (x).Value.Value4));
			
		}}
		