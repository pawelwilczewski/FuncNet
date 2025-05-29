using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

#nullable enable

namespace FuncNet;
		public static class Union3Zip
{public static TResult Zip<TResult, T0, T1, T2>(this IEnumerable<Union<T0, T1, T2>> values,
		Func<IEnumerable<T0>, IEnumerable<T1>, IEnumerable<T2>, TResult> zip){
		var results = (values).ToArray();
			return zip(results.Where(x => x.Index == 0).Select(x => x.Value0), results.Where(x => x.Index == 1).Select(x => x.Value1), results.Where(x => x.Index == 2).Select(x => x.Value2));
			
		}

	public static async Task<TResult> Zip<TResult, T0, T1, T2>(this IEnumerable<Task<Union<T0, T1, T2>>> values,
		Func<IEnumerable<T0>, IEnumerable<T1>, IEnumerable<T2>, Task<TResult>> zip,
		CancellationToken cancellationToken = default){
		var results = (await (Task.WhenAll(values)).ConfigureAwait(false)).ToArray();
			return await (zip(results.Where(x => x.Index == 0).Select(x => x.Value0), results.Where(x => x.Index == 1).Select(x => x.Value1), results.Where(x => x.Index == 2).Select(x => x.Value2))).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Zip<TResult, T0, T1, T2>(this IEnumerable<Union<T0, T1, T2>> values,
		Func<IEnumerable<T0>, IEnumerable<T1>, IEnumerable<T2>, Task<TResult>> zip,
		CancellationToken cancellationToken = default){
		var results = (values).ToArray();
			return await (zip(results.Where(x => x.Index == 0).Select(x => x.Value0), results.Where(x => x.Index == 1).Select(x => x.Value1), results.Where(x => x.Index == 2).Select(x => x.Value2))).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Zip<TResult, T0, T1, T2>(this IEnumerable<Task<Union<T0, T1, T2>>> values,
		Func<IEnumerable<T0>, IEnumerable<T1>, IEnumerable<T2>, TResult> zip,
		CancellationToken cancellationToken = default){
		var results = (await (Task.WhenAll(values)).ConfigureAwait(false)).ToArray();
			return zip(results.Where(x => x.Index == 0).Select(x => x.Value0), results.Where(x => x.Index == 1).Select(x => x.Value1), results.Where(x => x.Index == 2).Select(x => x.Value2));
			
		}}
		