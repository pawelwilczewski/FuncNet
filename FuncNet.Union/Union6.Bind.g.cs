using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Union6Bind
{public static Union<T0New, T1, T2, T3, T4, T5> Bind0<T0New, T0Old, T1, T2, T3, T4, T5>(this Union<T0Old, T1, T2, T3, T4, T5> union,
		Func<T0Old, Union<T0New, T1, T2, T3, T4, T5>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => binding(u.Value0),
		1 => Union<T0New, T1, T2, T3, T4, T5>.FromT1(u.Value1),
		2 => Union<T0New, T1, T2, T3, T4, T5>.FromT2(u.Value2),
		3 => Union<T0New, T1, T2, T3, T4, T5>.FromT3(u.Value3),
		4 => Union<T0New, T1, T2, T3, T4, T5>.FromT4(u.Value4),
		_ => Union<T0New, T1, T2, T3, T4, T5>.FromT5(u.Value5)
	};
			
		}

	public static Union<T0, T1New, T2, T3, T4, T5> Bind1<T1New, T0, T1Old, T2, T3, T4, T5>(this Union<T0, T1Old, T2, T3, T4, T5> union,
		Func<T1Old, Union<T0, T1New, T2, T3, T4, T5>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => Union<T0, T1New, T2, T3, T4, T5>.FromT0(u.Value0),
		1 => binding(u.Value1),
		2 => Union<T0, T1New, T2, T3, T4, T5>.FromT2(u.Value2),
		3 => Union<T0, T1New, T2, T3, T4, T5>.FromT3(u.Value3),
		4 => Union<T0, T1New, T2, T3, T4, T5>.FromT4(u.Value4),
		_ => Union<T0, T1New, T2, T3, T4, T5>.FromT5(u.Value5)
	};
			
		}

	public static Union<T0, T1, T2New, T3, T4, T5> Bind2<T2New, T0, T1, T2Old, T3, T4, T5>(this Union<T0, T1, T2Old, T3, T4, T5> union,
		Func<T2Old, Union<T0, T1, T2New, T3, T4, T5>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2New, T3, T4, T5>.FromT0(u.Value0),
		1 => Union<T0, T1, T2New, T3, T4, T5>.FromT1(u.Value1),
		2 => binding(u.Value2),
		3 => Union<T0, T1, T2New, T3, T4, T5>.FromT3(u.Value3),
		4 => Union<T0, T1, T2New, T3, T4, T5>.FromT4(u.Value4),
		_ => Union<T0, T1, T2New, T3, T4, T5>.FromT5(u.Value5)
	};
			
		}

	public static Union<T0, T1, T2, T3New, T4, T5> Bind3<T3New, T0, T1, T2, T3Old, T4, T5>(this Union<T0, T1, T2, T3Old, T4, T5> union,
		Func<T3Old, Union<T0, T1, T2, T3New, T4, T5>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3New, T4, T5>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3New, T4, T5>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3New, T4, T5>.FromT2(u.Value2),
		3 => binding(u.Value3),
		4 => Union<T0, T1, T2, T3New, T4, T5>.FromT4(u.Value4),
		_ => Union<T0, T1, T2, T3New, T4, T5>.FromT5(u.Value5)
	};
			
		}

	public static Union<T0, T1, T2, T3, T4New, T5> Bind4<T4New, T0, T1, T2, T3, T4Old, T5>(this Union<T0, T1, T2, T3, T4Old, T5> union,
		Func<T4Old, Union<T0, T1, T2, T3, T4New, T5>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4New, T5>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3, T4New, T5>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3, T4New, T5>.FromT2(u.Value2),
		3 => Union<T0, T1, T2, T3, T4New, T5>.FromT3(u.Value3),
		4 => binding(u.Value4),
		_ => Union<T0, T1, T2, T3, T4New, T5>.FromT5(u.Value5)
	};
			
		}

	public static Union<T0, T1, T2, T3, T4, T5New> Bind5<T5New, T0, T1, T2, T3, T4, T5Old>(this Union<T0, T1, T2, T3, T4, T5Old> union,
		Func<T5Old, Union<T0, T1, T2, T3, T4, T5New>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5New>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3, T4, T5New>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3, T4, T5New>.FromT2(u.Value2),
		3 => Union<T0, T1, T2, T3, T4, T5New>.FromT3(u.Value3),
		4 => Union<T0, T1, T2, T3, T4, T5New>.FromT4(u.Value4),
		_ => binding(u.Value5)
	};
			
		}

	public static async Task<Union<T0New, T1, T2, T3, T4, T5>> Bind0<T0New, T0Old, T1, T2, T3, T4, T5>(this Task<Union<T0Old, T1, T2, T3, T4, T5>> union,
		Func<T0Old, Task<Union<T0New, T1, T2, T3, T4, T5>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => binding(u.Value0),
		1 => Union<T0New, T1, T2, T3, T4, T5>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0New, T1, T2, T3, T4, T5>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0New, T1, T2, T3, T4, T5>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0New, T1, T2, T3, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0New, T1, T2, T3, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1New, T2, T3, T4, T5>> Bind1<T1New, T0, T1Old, T2, T3, T4, T5>(this Task<Union<T0, T1Old, T2, T3, T4, T5>> union,
		Func<T1Old, Task<Union<T0, T1New, T2, T3, T4, T5>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1New, T2, T3, T4, T5>.FromT0(Task.FromResult(u.Value0)),
		1 => binding(u.Value1),
		2 => Union<T0, T1New, T2, T3, T4, T5>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1New, T2, T3, T4, T5>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1New, T2, T3, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0, T1New, T2, T3, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2New, T3, T4, T5>> Bind2<T2New, T0, T1, T2Old, T3, T4, T5>(this Task<Union<T0, T1, T2Old, T3, T4, T5>> union,
		Func<T2Old, Task<Union<T0, T1, T2New, T3, T4, T5>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2New, T3, T4, T5>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2New, T3, T4, T5>.FromT1(Task.FromResult(u.Value1)),
		2 => binding(u.Value2),
		3 => Union<T0, T1, T2New, T3, T4, T5>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1, T2New, T3, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0, T1, T2New, T3, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3New, T4, T5>> Bind3<T3New, T0, T1, T2, T3Old, T4, T5>(this Task<Union<T0, T1, T2, T3Old, T4, T5>> union,
		Func<T3Old, Task<Union<T0, T1, T2, T3New, T4, T5>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3New, T4, T5>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3New, T4, T5>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3New, T4, T5>.FromT2(Task.FromResult(u.Value2)),
		3 => binding(u.Value3),
		4 => Union<T0, T1, T2, T3New, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0, T1, T2, T3New, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4New, T5>> Bind4<T4New, T0, T1, T2, T3, T4Old, T5>(this Task<Union<T0, T1, T2, T3, T4Old, T5>> union,
		Func<T4Old, Task<Union<T0, T1, T2, T3, T4New, T5>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4New, T5>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3, T4New, T5>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3, T4New, T5>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3, T4New, T5>.FromT3(Task.FromResult(u.Value3)),
		4 => binding(u.Value4),
		_ => Union<T0, T1, T2, T3, T4New, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5New>> Bind5<T5New, T0, T1, T2, T3, T4, T5Old>(this Task<Union<T0, T1, T2, T3, T4, T5Old>> union,
		Func<T5Old, Task<Union<T0, T1, T2, T3, T4, T5New>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5New>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3, T4, T5New>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3, T4, T5New>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3, T4, T5New>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1, T2, T3, T4, T5New>.FromT4(Task.FromResult(u.Value4)),
		_ => binding(u.Value5)
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0New, T1, T2, T3, T4, T5>> Bind0<T0New, T0Old, T1, T2, T3, T4, T5>(this Union<T0Old, T1, T2, T3, T4, T5> union,
		Func<T0Old, Task<Union<T0New, T1, T2, T3, T4, T5>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => binding(u.Value0),
		1 => Union<T0New, T1, T2, T3, T4, T5>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0New, T1, T2, T3, T4, T5>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0New, T1, T2, T3, T4, T5>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0New, T1, T2, T3, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0New, T1, T2, T3, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1New, T2, T3, T4, T5>> Bind1<T1New, T0, T1Old, T2, T3, T4, T5>(this Union<T0, T1Old, T2, T3, T4, T5> union,
		Func<T1Old, Task<Union<T0, T1New, T2, T3, T4, T5>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1New, T2, T3, T4, T5>.FromT0(Task.FromResult(u.Value0)),
		1 => binding(u.Value1),
		2 => Union<T0, T1New, T2, T3, T4, T5>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1New, T2, T3, T4, T5>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1New, T2, T3, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0, T1New, T2, T3, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2New, T3, T4, T5>> Bind2<T2New, T0, T1, T2Old, T3, T4, T5>(this Union<T0, T1, T2Old, T3, T4, T5> union,
		Func<T2Old, Task<Union<T0, T1, T2New, T3, T4, T5>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2New, T3, T4, T5>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2New, T3, T4, T5>.FromT1(Task.FromResult(u.Value1)),
		2 => binding(u.Value2),
		3 => Union<T0, T1, T2New, T3, T4, T5>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1, T2New, T3, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0, T1, T2New, T3, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3New, T4, T5>> Bind3<T3New, T0, T1, T2, T3Old, T4, T5>(this Union<T0, T1, T2, T3Old, T4, T5> union,
		Func<T3Old, Task<Union<T0, T1, T2, T3New, T4, T5>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3New, T4, T5>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3New, T4, T5>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3New, T4, T5>.FromT2(Task.FromResult(u.Value2)),
		3 => binding(u.Value3),
		4 => Union<T0, T1, T2, T3New, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0, T1, T2, T3New, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4New, T5>> Bind4<T4New, T0, T1, T2, T3, T4Old, T5>(this Union<T0, T1, T2, T3, T4Old, T5> union,
		Func<T4Old, Task<Union<T0, T1, T2, T3, T4New, T5>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4New, T5>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3, T4New, T5>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3, T4New, T5>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3, T4New, T5>.FromT3(Task.FromResult(u.Value3)),
		4 => binding(u.Value4),
		_ => Union<T0, T1, T2, T3, T4New, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5New>> Bind5<T5New, T0, T1, T2, T3, T4, T5Old>(this Union<T0, T1, T2, T3, T4, T5Old> union,
		Func<T5Old, Task<Union<T0, T1, T2, T3, T4, T5New>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5New>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3, T4, T5New>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3, T4, T5New>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3, T4, T5New>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1, T2, T3, T4, T5New>.FromT4(Task.FromResult(u.Value4)),
		_ => binding(u.Value5)
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0New, T1, T2, T3, T4, T5>> Bind0<T0New, T0Old, T1, T2, T3, T4, T5>(this Task<Union<T0Old, T1, T2, T3, T4, T5>> union,
		Func<T0Old, Union<T0New, T1, T2, T3, T4, T5>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => binding(u.Value0),
		1 => Union<T0New, T1, T2, T3, T4, T5>.FromT1(u.Value1),
		2 => Union<T0New, T1, T2, T3, T4, T5>.FromT2(u.Value2),
		3 => Union<T0New, T1, T2, T3, T4, T5>.FromT3(u.Value3),
		4 => Union<T0New, T1, T2, T3, T4, T5>.FromT4(u.Value4),
		_ => Union<T0New, T1, T2, T3, T4, T5>.FromT5(u.Value5)
	};
			
		}

	public static async Task<Union<T0, T1New, T2, T3, T4, T5>> Bind1<T1New, T0, T1Old, T2, T3, T4, T5>(this Task<Union<T0, T1Old, T2, T3, T4, T5>> union,
		Func<T1Old, Union<T0, T1New, T2, T3, T4, T5>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1New, T2, T3, T4, T5>.FromT0(u.Value0),
		1 => binding(u.Value1),
		2 => Union<T0, T1New, T2, T3, T4, T5>.FromT2(u.Value2),
		3 => Union<T0, T1New, T2, T3, T4, T5>.FromT3(u.Value3),
		4 => Union<T0, T1New, T2, T3, T4, T5>.FromT4(u.Value4),
		_ => Union<T0, T1New, T2, T3, T4, T5>.FromT5(u.Value5)
	};
			
		}

	public static async Task<Union<T0, T1, T2New, T3, T4, T5>> Bind2<T2New, T0, T1, T2Old, T3, T4, T5>(this Task<Union<T0, T1, T2Old, T3, T4, T5>> union,
		Func<T2Old, Union<T0, T1, T2New, T3, T4, T5>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2New, T3, T4, T5>.FromT0(u.Value0),
		1 => Union<T0, T1, T2New, T3, T4, T5>.FromT1(u.Value1),
		2 => binding(u.Value2),
		3 => Union<T0, T1, T2New, T3, T4, T5>.FromT3(u.Value3),
		4 => Union<T0, T1, T2New, T3, T4, T5>.FromT4(u.Value4),
		_ => Union<T0, T1, T2New, T3, T4, T5>.FromT5(u.Value5)
	};
			
		}

	public static async Task<Union<T0, T1, T2, T3New, T4, T5>> Bind3<T3New, T0, T1, T2, T3Old, T4, T5>(this Task<Union<T0, T1, T2, T3Old, T4, T5>> union,
		Func<T3Old, Union<T0, T1, T2, T3New, T4, T5>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3New, T4, T5>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3New, T4, T5>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3New, T4, T5>.FromT2(u.Value2),
		3 => binding(u.Value3),
		4 => Union<T0, T1, T2, T3New, T4, T5>.FromT4(u.Value4),
		_ => Union<T0, T1, T2, T3New, T4, T5>.FromT5(u.Value5)
	};
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4New, T5>> Bind4<T4New, T0, T1, T2, T3, T4Old, T5>(this Task<Union<T0, T1, T2, T3, T4Old, T5>> union,
		Func<T4Old, Union<T0, T1, T2, T3, T4New, T5>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4New, T5>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3, T4New, T5>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3, T4New, T5>.FromT2(u.Value2),
		3 => Union<T0, T1, T2, T3, T4New, T5>.FromT3(u.Value3),
		4 => binding(u.Value4),
		_ => Union<T0, T1, T2, T3, T4New, T5>.FromT5(u.Value5)
	};
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5New>> Bind5<T5New, T0, T1, T2, T3, T4, T5Old>(this Task<Union<T0, T1, T2, T3, T4, T5Old>> union,
		Func<T5Old, Union<T0, T1, T2, T3, T4, T5New>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5New>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3, T4, T5New>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3, T4, T5New>.FromT2(u.Value2),
		3 => Union<T0, T1, T2, T3, T4, T5New>.FromT3(u.Value3),
		4 => Union<T0, T1, T2, T3, T4, T5New>.FromT4(u.Value4),
		_ => binding(u.Value5)
	};
			
		}}
		