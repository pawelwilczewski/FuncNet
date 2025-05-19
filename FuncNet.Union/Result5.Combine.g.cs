using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

#nullable enable

namespace FuncNet.Union;
		public readonly partial record struct Result
{public static TResult Combine<TResult, TSuccess0, TSuccess1, TError0, TError1, TError2, TError3>(Result<TSuccess0, TError0, TError1, TError2, TError3> result0,
		Result<TSuccess1, TError0, TError1, TError2, TError3> result1,
		Func<TSuccess0, TSuccess1, TResult> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, TResult> combineErrors){
		var r0 = result0;
			var r1 = result1;
			if (r0.IsSuccess
			&& r1.IsSuccess){
		return combineSuccess(r0.Value.Value0, r1.Value.Value0);
			
		};
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
			return combineErrors(errors0, errors1, errors2, errors3);
			
		}

	public static TResult Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TError0, TError1, TError2, TError3>(Result<TSuccess0, TError0, TError1, TError2, TError3> result0,
		Result<TSuccess1, TError0, TError1, TError2, TError3> result1,
		Result<TSuccess2, TError0, TError1, TError2, TError3> result2,
		Func<TSuccess0, TSuccess1, TSuccess2, TResult> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, TResult> combineErrors){
		var r0 = result0;
			var r1 = result1;
			var r2 = result2;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess){
		return combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0);
			
		};
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
			return combineErrors(errors0, errors1, errors2, errors3);
			
		}

	public static TResult Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TSuccess3, TError0, TError1, TError2, TError3>(Result<TSuccess0, TError0, TError1, TError2, TError3> result0,
		Result<TSuccess1, TError0, TError1, TError2, TError3> result1,
		Result<TSuccess2, TError0, TError1, TError2, TError3> result2,
		Result<TSuccess3, TError0, TError1, TError2, TError3> result3,
		Func<TSuccess0, TSuccess1, TSuccess2, TSuccess3, TResult> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, TResult> combineErrors){
		var r0 = result0;
			var r1 = result1;
			var r2 = result2;
			var r3 = result3;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess
			&& r3.IsSuccess){
		return combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0, r3.Value.Value0);
			
		};
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
		if (r3.Value.Index == 1) errors0.Add(r3.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
		if (r3.Value.Index == 2) errors1.Add(r3.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
		if (r3.Value.Index == 3) errors2.Add(r3.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
		if (r3.Value.Index == 4) errors3.Add(r3.Value.Value4);
			return combineErrors(errors0, errors1, errors2, errors3);
			
		}

	public static TResult Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, TError0, TError1, TError2, TError3>(Result<TSuccess0, TError0, TError1, TError2, TError3> result0,
		Result<TSuccess1, TError0, TError1, TError2, TError3> result1,
		Result<TSuccess2, TError0, TError1, TError2, TError3> result2,
		Result<TSuccess3, TError0, TError1, TError2, TError3> result3,
		Result<TSuccess4, TError0, TError1, TError2, TError3> result4,
		Func<TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, TResult> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, TResult> combineErrors){
		var r0 = result0;
			var r1 = result1;
			var r2 = result2;
			var r3 = result3;
			var r4 = result4;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess
			&& r3.IsSuccess
			&& r4.IsSuccess){
		return combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0, r3.Value.Value0, r4.Value.Value0);
			
		};
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
		if (r3.Value.Index == 1) errors0.Add(r3.Value.Value1);
		if (r4.Value.Index == 1) errors0.Add(r4.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
		if (r3.Value.Index == 2) errors1.Add(r3.Value.Value2);
		if (r4.Value.Index == 2) errors1.Add(r4.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
		if (r3.Value.Index == 3) errors2.Add(r3.Value.Value3);
		if (r4.Value.Index == 3) errors2.Add(r4.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
		if (r3.Value.Index == 4) errors3.Add(r3.Value.Value4);
		if (r4.Value.Index == 4) errors3.Add(r4.Value.Value4);
			return combineErrors(errors0, errors1, errors2, errors3);
			
		}

	public static TResult Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TError0, TError1, TError2, TError3>(Result<TSuccess0, TError0, TError1, TError2, TError3> result0,
		Result<TSuccess1, TError0, TError1, TError2, TError3> result1,
		Result<TSuccess2, TError0, TError1, TError2, TError3> result2,
		Result<TSuccess3, TError0, TError1, TError2, TError3> result3,
		Result<TSuccess4, TError0, TError1, TError2, TError3> result4,
		Result<TSuccess5, TError0, TError1, TError2, TError3> result5,
		Func<TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TResult> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, TResult> combineErrors){
		var r0 = result0;
			var r1 = result1;
			var r2 = result2;
			var r3 = result3;
			var r4 = result4;
			var r5 = result5;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess
			&& r3.IsSuccess
			&& r4.IsSuccess
			&& r5.IsSuccess){
		return combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0, r3.Value.Value0, r4.Value.Value0, r5.Value.Value0);
			
		};
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
		if (r3.Value.Index == 1) errors0.Add(r3.Value.Value1);
		if (r4.Value.Index == 1) errors0.Add(r4.Value.Value1);
		if (r5.Value.Index == 1) errors0.Add(r5.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
		if (r3.Value.Index == 2) errors1.Add(r3.Value.Value2);
		if (r4.Value.Index == 2) errors1.Add(r4.Value.Value2);
		if (r5.Value.Index == 2) errors1.Add(r5.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
		if (r3.Value.Index == 3) errors2.Add(r3.Value.Value3);
		if (r4.Value.Index == 3) errors2.Add(r4.Value.Value3);
		if (r5.Value.Index == 3) errors2.Add(r5.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
		if (r3.Value.Index == 4) errors3.Add(r3.Value.Value4);
		if (r4.Value.Index == 4) errors3.Add(r4.Value.Value4);
		if (r5.Value.Index == 4) errors3.Add(r5.Value.Value4);
			return combineErrors(errors0, errors1, errors2, errors3);
			
		}

	public static async Task<TResult> Combine<TResult, TSuccess0, TSuccess1, TError0, TError1, TError2, TError3>(Task<Result<TSuccess0, TError0, TError1, TError2, TError3>> result0,
		Task<Result<TSuccess1, TError0, TError1, TError2, TError3>> result1,
		Func<TSuccess0, TSuccess1, Task<TResult>> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, Task<TResult>> combineErrors,
		CancellationToken cancellationToken = default){
		await (Task.WhenAll(result0, result1)).ConfigureAwait(false);
			var r0 = (result0).Result;
			var r1 = (result1).Result;
			if (r0.IsSuccess
			&& r1.IsSuccess){
		return await (combineSuccess(r0.Value.Value0, r1.Value.Value0)).ConfigureAwait(false);
			
		};
			cancellationToken.ThrowIfCancellationRequested();
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
			return await (combineErrors(errors0, errors1, errors2, errors3)).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TError0, TError1, TError2, TError3>(Task<Result<TSuccess0, TError0, TError1, TError2, TError3>> result0,
		Task<Result<TSuccess1, TError0, TError1, TError2, TError3>> result1,
		Task<Result<TSuccess2, TError0, TError1, TError2, TError3>> result2,
		Func<TSuccess0, TSuccess1, TSuccess2, Task<TResult>> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, Task<TResult>> combineErrors,
		CancellationToken cancellationToken = default){
		await (Task.WhenAll(result0, result1, result2)).ConfigureAwait(false);
			var r0 = (result0).Result;
			var r1 = (result1).Result;
			var r2 = (result2).Result;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess){
		return await (combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0)).ConfigureAwait(false);
			
		};
			cancellationToken.ThrowIfCancellationRequested();
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
			return await (combineErrors(errors0, errors1, errors2, errors3)).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TSuccess3, TError0, TError1, TError2, TError3>(Task<Result<TSuccess0, TError0, TError1, TError2, TError3>> result0,
		Task<Result<TSuccess1, TError0, TError1, TError2, TError3>> result1,
		Task<Result<TSuccess2, TError0, TError1, TError2, TError3>> result2,
		Task<Result<TSuccess3, TError0, TError1, TError2, TError3>> result3,
		Func<TSuccess0, TSuccess1, TSuccess2, TSuccess3, Task<TResult>> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, Task<TResult>> combineErrors,
		CancellationToken cancellationToken = default){
		await (Task.WhenAll(result0, result1, result2, result3)).ConfigureAwait(false);
			var r0 = (result0).Result;
			var r1 = (result1).Result;
			var r2 = (result2).Result;
			var r3 = (result3).Result;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess
			&& r3.IsSuccess){
		return await (combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0, r3.Value.Value0)).ConfigureAwait(false);
			
		};
			cancellationToken.ThrowIfCancellationRequested();
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
		if (r3.Value.Index == 1) errors0.Add(r3.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
		if (r3.Value.Index == 2) errors1.Add(r3.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
		if (r3.Value.Index == 3) errors2.Add(r3.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
		if (r3.Value.Index == 4) errors3.Add(r3.Value.Value4);
			return await (combineErrors(errors0, errors1, errors2, errors3)).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, TError0, TError1, TError2, TError3>(Task<Result<TSuccess0, TError0, TError1, TError2, TError3>> result0,
		Task<Result<TSuccess1, TError0, TError1, TError2, TError3>> result1,
		Task<Result<TSuccess2, TError0, TError1, TError2, TError3>> result2,
		Task<Result<TSuccess3, TError0, TError1, TError2, TError3>> result3,
		Task<Result<TSuccess4, TError0, TError1, TError2, TError3>> result4,
		Func<TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, Task<TResult>> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, Task<TResult>> combineErrors,
		CancellationToken cancellationToken = default){
		await (Task.WhenAll(result0, result1, result2, result3, result4)).ConfigureAwait(false);
			var r0 = (result0).Result;
			var r1 = (result1).Result;
			var r2 = (result2).Result;
			var r3 = (result3).Result;
			var r4 = (result4).Result;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess
			&& r3.IsSuccess
			&& r4.IsSuccess){
		return await (combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0, r3.Value.Value0, r4.Value.Value0)).ConfigureAwait(false);
			
		};
			cancellationToken.ThrowIfCancellationRequested();
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
		if (r3.Value.Index == 1) errors0.Add(r3.Value.Value1);
		if (r4.Value.Index == 1) errors0.Add(r4.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
		if (r3.Value.Index == 2) errors1.Add(r3.Value.Value2);
		if (r4.Value.Index == 2) errors1.Add(r4.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
		if (r3.Value.Index == 3) errors2.Add(r3.Value.Value3);
		if (r4.Value.Index == 3) errors2.Add(r4.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
		if (r3.Value.Index == 4) errors3.Add(r3.Value.Value4);
		if (r4.Value.Index == 4) errors3.Add(r4.Value.Value4);
			return await (combineErrors(errors0, errors1, errors2, errors3)).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TError0, TError1, TError2, TError3>(Task<Result<TSuccess0, TError0, TError1, TError2, TError3>> result0,
		Task<Result<TSuccess1, TError0, TError1, TError2, TError3>> result1,
		Task<Result<TSuccess2, TError0, TError1, TError2, TError3>> result2,
		Task<Result<TSuccess3, TError0, TError1, TError2, TError3>> result3,
		Task<Result<TSuccess4, TError0, TError1, TError2, TError3>> result4,
		Task<Result<TSuccess5, TError0, TError1, TError2, TError3>> result5,
		Func<TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, Task<TResult>> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, Task<TResult>> combineErrors,
		CancellationToken cancellationToken = default){
		await (Task.WhenAll(result0, result1, result2, result3, result4, result5)).ConfigureAwait(false);
			var r0 = (result0).Result;
			var r1 = (result1).Result;
			var r2 = (result2).Result;
			var r3 = (result3).Result;
			var r4 = (result4).Result;
			var r5 = (result5).Result;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess
			&& r3.IsSuccess
			&& r4.IsSuccess
			&& r5.IsSuccess){
		return await (combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0, r3.Value.Value0, r4.Value.Value0, r5.Value.Value0)).ConfigureAwait(false);
			
		};
			cancellationToken.ThrowIfCancellationRequested();
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
		if (r3.Value.Index == 1) errors0.Add(r3.Value.Value1);
		if (r4.Value.Index == 1) errors0.Add(r4.Value.Value1);
		if (r5.Value.Index == 1) errors0.Add(r5.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
		if (r3.Value.Index == 2) errors1.Add(r3.Value.Value2);
		if (r4.Value.Index == 2) errors1.Add(r4.Value.Value2);
		if (r5.Value.Index == 2) errors1.Add(r5.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
		if (r3.Value.Index == 3) errors2.Add(r3.Value.Value3);
		if (r4.Value.Index == 3) errors2.Add(r4.Value.Value3);
		if (r5.Value.Index == 3) errors2.Add(r5.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
		if (r3.Value.Index == 4) errors3.Add(r3.Value.Value4);
		if (r4.Value.Index == 4) errors3.Add(r4.Value.Value4);
		if (r5.Value.Index == 4) errors3.Add(r5.Value.Value4);
			return await (combineErrors(errors0, errors1, errors2, errors3)).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Combine<TResult, TSuccess0, TSuccess1, TError0, TError1, TError2, TError3>(Result<TSuccess0, TError0, TError1, TError2, TError3> result0,
		Result<TSuccess1, TError0, TError1, TError2, TError3> result1,
		Func<TSuccess0, TSuccess1, Task<TResult>> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, Task<TResult>> combineErrors,
		CancellationToken cancellationToken = default){
		var r0 = result0;
			var r1 = result1;
			if (r0.IsSuccess
			&& r1.IsSuccess){
		return await (combineSuccess(r0.Value.Value0, r1.Value.Value0)).ConfigureAwait(false);
			
		};
			cancellationToken.ThrowIfCancellationRequested();
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
			return await (combineErrors(errors0, errors1, errors2, errors3)).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TError0, TError1, TError2, TError3>(Result<TSuccess0, TError0, TError1, TError2, TError3> result0,
		Result<TSuccess1, TError0, TError1, TError2, TError3> result1,
		Result<TSuccess2, TError0, TError1, TError2, TError3> result2,
		Func<TSuccess0, TSuccess1, TSuccess2, Task<TResult>> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, Task<TResult>> combineErrors,
		CancellationToken cancellationToken = default){
		var r0 = result0;
			var r1 = result1;
			var r2 = result2;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess){
		return await (combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0)).ConfigureAwait(false);
			
		};
			cancellationToken.ThrowIfCancellationRequested();
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
			return await (combineErrors(errors0, errors1, errors2, errors3)).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TSuccess3, TError0, TError1, TError2, TError3>(Result<TSuccess0, TError0, TError1, TError2, TError3> result0,
		Result<TSuccess1, TError0, TError1, TError2, TError3> result1,
		Result<TSuccess2, TError0, TError1, TError2, TError3> result2,
		Result<TSuccess3, TError0, TError1, TError2, TError3> result3,
		Func<TSuccess0, TSuccess1, TSuccess2, TSuccess3, Task<TResult>> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, Task<TResult>> combineErrors,
		CancellationToken cancellationToken = default){
		var r0 = result0;
			var r1 = result1;
			var r2 = result2;
			var r3 = result3;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess
			&& r3.IsSuccess){
		return await (combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0, r3.Value.Value0)).ConfigureAwait(false);
			
		};
			cancellationToken.ThrowIfCancellationRequested();
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
		if (r3.Value.Index == 1) errors0.Add(r3.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
		if (r3.Value.Index == 2) errors1.Add(r3.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
		if (r3.Value.Index == 3) errors2.Add(r3.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
		if (r3.Value.Index == 4) errors3.Add(r3.Value.Value4);
			return await (combineErrors(errors0, errors1, errors2, errors3)).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, TError0, TError1, TError2, TError3>(Result<TSuccess0, TError0, TError1, TError2, TError3> result0,
		Result<TSuccess1, TError0, TError1, TError2, TError3> result1,
		Result<TSuccess2, TError0, TError1, TError2, TError3> result2,
		Result<TSuccess3, TError0, TError1, TError2, TError3> result3,
		Result<TSuccess4, TError0, TError1, TError2, TError3> result4,
		Func<TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, Task<TResult>> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, Task<TResult>> combineErrors,
		CancellationToken cancellationToken = default){
		var r0 = result0;
			var r1 = result1;
			var r2 = result2;
			var r3 = result3;
			var r4 = result4;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess
			&& r3.IsSuccess
			&& r4.IsSuccess){
		return await (combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0, r3.Value.Value0, r4.Value.Value0)).ConfigureAwait(false);
			
		};
			cancellationToken.ThrowIfCancellationRequested();
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
		if (r3.Value.Index == 1) errors0.Add(r3.Value.Value1);
		if (r4.Value.Index == 1) errors0.Add(r4.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
		if (r3.Value.Index == 2) errors1.Add(r3.Value.Value2);
		if (r4.Value.Index == 2) errors1.Add(r4.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
		if (r3.Value.Index == 3) errors2.Add(r3.Value.Value3);
		if (r4.Value.Index == 3) errors2.Add(r4.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
		if (r3.Value.Index == 4) errors3.Add(r3.Value.Value4);
		if (r4.Value.Index == 4) errors3.Add(r4.Value.Value4);
			return await (combineErrors(errors0, errors1, errors2, errors3)).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TError0, TError1, TError2, TError3>(Result<TSuccess0, TError0, TError1, TError2, TError3> result0,
		Result<TSuccess1, TError0, TError1, TError2, TError3> result1,
		Result<TSuccess2, TError0, TError1, TError2, TError3> result2,
		Result<TSuccess3, TError0, TError1, TError2, TError3> result3,
		Result<TSuccess4, TError0, TError1, TError2, TError3> result4,
		Result<TSuccess5, TError0, TError1, TError2, TError3> result5,
		Func<TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, Task<TResult>> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, Task<TResult>> combineErrors,
		CancellationToken cancellationToken = default){
		var r0 = result0;
			var r1 = result1;
			var r2 = result2;
			var r3 = result3;
			var r4 = result4;
			var r5 = result5;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess
			&& r3.IsSuccess
			&& r4.IsSuccess
			&& r5.IsSuccess){
		return await (combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0, r3.Value.Value0, r4.Value.Value0, r5.Value.Value0)).ConfigureAwait(false);
			
		};
			cancellationToken.ThrowIfCancellationRequested();
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
		if (r3.Value.Index == 1) errors0.Add(r3.Value.Value1);
		if (r4.Value.Index == 1) errors0.Add(r4.Value.Value1);
		if (r5.Value.Index == 1) errors0.Add(r5.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
		if (r3.Value.Index == 2) errors1.Add(r3.Value.Value2);
		if (r4.Value.Index == 2) errors1.Add(r4.Value.Value2);
		if (r5.Value.Index == 2) errors1.Add(r5.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
		if (r3.Value.Index == 3) errors2.Add(r3.Value.Value3);
		if (r4.Value.Index == 3) errors2.Add(r4.Value.Value3);
		if (r5.Value.Index == 3) errors2.Add(r5.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
		if (r3.Value.Index == 4) errors3.Add(r3.Value.Value4);
		if (r4.Value.Index == 4) errors3.Add(r4.Value.Value4);
		if (r5.Value.Index == 4) errors3.Add(r5.Value.Value4);
			return await (combineErrors(errors0, errors1, errors2, errors3)).ConfigureAwait(false);
			
		}

	public static async Task<TResult> Combine<TResult, TSuccess0, TSuccess1, TError0, TError1, TError2, TError3>(Task<Result<TSuccess0, TError0, TError1, TError2, TError3>> result0,
		Task<Result<TSuccess1, TError0, TError1, TError2, TError3>> result1,
		Func<TSuccess0, TSuccess1, TResult> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, TResult> combineErrors,
		CancellationToken cancellationToken = default){
		await (Task.WhenAll(result0, result1)).ConfigureAwait(false);
			var r0 = (result0).Result;
			var r1 = (result1).Result;
			if (r0.IsSuccess
			&& r1.IsSuccess){
		return combineSuccess(r0.Value.Value0, r1.Value.Value0);
			
		};
			cancellationToken.ThrowIfCancellationRequested();
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
			return combineErrors(errors0, errors1, errors2, errors3);
			
		}

	public static async Task<TResult> Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TError0, TError1, TError2, TError3>(Task<Result<TSuccess0, TError0, TError1, TError2, TError3>> result0,
		Task<Result<TSuccess1, TError0, TError1, TError2, TError3>> result1,
		Task<Result<TSuccess2, TError0, TError1, TError2, TError3>> result2,
		Func<TSuccess0, TSuccess1, TSuccess2, TResult> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, TResult> combineErrors,
		CancellationToken cancellationToken = default){
		await (Task.WhenAll(result0, result1, result2)).ConfigureAwait(false);
			var r0 = (result0).Result;
			var r1 = (result1).Result;
			var r2 = (result2).Result;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess){
		return combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0);
			
		};
			cancellationToken.ThrowIfCancellationRequested();
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
			return combineErrors(errors0, errors1, errors2, errors3);
			
		}

	public static async Task<TResult> Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TSuccess3, TError0, TError1, TError2, TError3>(Task<Result<TSuccess0, TError0, TError1, TError2, TError3>> result0,
		Task<Result<TSuccess1, TError0, TError1, TError2, TError3>> result1,
		Task<Result<TSuccess2, TError0, TError1, TError2, TError3>> result2,
		Task<Result<TSuccess3, TError0, TError1, TError2, TError3>> result3,
		Func<TSuccess0, TSuccess1, TSuccess2, TSuccess3, TResult> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, TResult> combineErrors,
		CancellationToken cancellationToken = default){
		await (Task.WhenAll(result0, result1, result2, result3)).ConfigureAwait(false);
			var r0 = (result0).Result;
			var r1 = (result1).Result;
			var r2 = (result2).Result;
			var r3 = (result3).Result;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess
			&& r3.IsSuccess){
		return combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0, r3.Value.Value0);
			
		};
			cancellationToken.ThrowIfCancellationRequested();
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
		if (r3.Value.Index == 1) errors0.Add(r3.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
		if (r3.Value.Index == 2) errors1.Add(r3.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
		if (r3.Value.Index == 3) errors2.Add(r3.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
		if (r3.Value.Index == 4) errors3.Add(r3.Value.Value4);
			return combineErrors(errors0, errors1, errors2, errors3);
			
		}

	public static async Task<TResult> Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, TError0, TError1, TError2, TError3>(Task<Result<TSuccess0, TError0, TError1, TError2, TError3>> result0,
		Task<Result<TSuccess1, TError0, TError1, TError2, TError3>> result1,
		Task<Result<TSuccess2, TError0, TError1, TError2, TError3>> result2,
		Task<Result<TSuccess3, TError0, TError1, TError2, TError3>> result3,
		Task<Result<TSuccess4, TError0, TError1, TError2, TError3>> result4,
		Func<TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, TResult> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, TResult> combineErrors,
		CancellationToken cancellationToken = default){
		await (Task.WhenAll(result0, result1, result2, result3, result4)).ConfigureAwait(false);
			var r0 = (result0).Result;
			var r1 = (result1).Result;
			var r2 = (result2).Result;
			var r3 = (result3).Result;
			var r4 = (result4).Result;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess
			&& r3.IsSuccess
			&& r4.IsSuccess){
		return combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0, r3.Value.Value0, r4.Value.Value0);
			
		};
			cancellationToken.ThrowIfCancellationRequested();
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
		if (r3.Value.Index == 1) errors0.Add(r3.Value.Value1);
		if (r4.Value.Index == 1) errors0.Add(r4.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
		if (r3.Value.Index == 2) errors1.Add(r3.Value.Value2);
		if (r4.Value.Index == 2) errors1.Add(r4.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
		if (r3.Value.Index == 3) errors2.Add(r3.Value.Value3);
		if (r4.Value.Index == 3) errors2.Add(r4.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
		if (r3.Value.Index == 4) errors3.Add(r3.Value.Value4);
		if (r4.Value.Index == 4) errors3.Add(r4.Value.Value4);
			return combineErrors(errors0, errors1, errors2, errors3);
			
		}

	public static async Task<TResult> Combine<TResult, TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TError0, TError1, TError2, TError3>(Task<Result<TSuccess0, TError0, TError1, TError2, TError3>> result0,
		Task<Result<TSuccess1, TError0, TError1, TError2, TError3>> result1,
		Task<Result<TSuccess2, TError0, TError1, TError2, TError3>> result2,
		Task<Result<TSuccess3, TError0, TError1, TError2, TError3>> result3,
		Task<Result<TSuccess4, TError0, TError1, TError2, TError3>> result4,
		Task<Result<TSuccess5, TError0, TError1, TError2, TError3>> result5,
		Func<TSuccess0, TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TResult> combineSuccess,
		Func<IReadOnlyList<TError0>, IReadOnlyList<TError1>, IReadOnlyList<TError2>, IReadOnlyList<TError3>, TResult> combineErrors,
		CancellationToken cancellationToken = default){
		await (Task.WhenAll(result0, result1, result2, result3, result4, result5)).ConfigureAwait(false);
			var r0 = (result0).Result;
			var r1 = (result1).Result;
			var r2 = (result2).Result;
			var r3 = (result3).Result;
			var r4 = (result4).Result;
			var r5 = (result5).Result;
			if (r0.IsSuccess
			&& r1.IsSuccess
			&& r2.IsSuccess
			&& r3.IsSuccess
			&& r4.IsSuccess
			&& r5.IsSuccess){
		return combineSuccess(r0.Value.Value0, r1.Value.Value0, r2.Value.Value0, r3.Value.Value0, r4.Value.Value0, r5.Value.Value0);
			
		};
			cancellationToken.ThrowIfCancellationRequested();
			var errors0 = new List<TError0>();
		if (r0.Value.Index == 1) errors0.Add(r0.Value.Value1);
		if (r1.Value.Index == 1) errors0.Add(r1.Value.Value1);
		if (r2.Value.Index == 1) errors0.Add(r2.Value.Value1);
		if (r3.Value.Index == 1) errors0.Add(r3.Value.Value1);
		if (r4.Value.Index == 1) errors0.Add(r4.Value.Value1);
		if (r5.Value.Index == 1) errors0.Add(r5.Value.Value1);
			var errors1 = new List<TError1>();
		if (r0.Value.Index == 2) errors1.Add(r0.Value.Value2);
		if (r1.Value.Index == 2) errors1.Add(r1.Value.Value2);
		if (r2.Value.Index == 2) errors1.Add(r2.Value.Value2);
		if (r3.Value.Index == 2) errors1.Add(r3.Value.Value2);
		if (r4.Value.Index == 2) errors1.Add(r4.Value.Value2);
		if (r5.Value.Index == 2) errors1.Add(r5.Value.Value2);
			var errors2 = new List<TError2>();
		if (r0.Value.Index == 3) errors2.Add(r0.Value.Value3);
		if (r1.Value.Index == 3) errors2.Add(r1.Value.Value3);
		if (r2.Value.Index == 3) errors2.Add(r2.Value.Value3);
		if (r3.Value.Index == 3) errors2.Add(r3.Value.Value3);
		if (r4.Value.Index == 3) errors2.Add(r4.Value.Value3);
		if (r5.Value.Index == 3) errors2.Add(r5.Value.Value3);
			var errors3 = new List<TError3>();
		if (r0.Value.Index == 4) errors3.Add(r0.Value.Value4);
		if (r1.Value.Index == 4) errors3.Add(r1.Value.Value4);
		if (r2.Value.Index == 4) errors3.Add(r2.Value.Value4);
		if (r3.Value.Index == 4) errors3.Add(r3.Value.Value4);
		if (r4.Value.Index == 4) errors3.Add(r4.Value.Value4);
		if (r5.Value.Index == 4) errors3.Add(r5.Value.Value4);
			return combineErrors(errors0, errors1, errors2, errors3);
			
		}}
		