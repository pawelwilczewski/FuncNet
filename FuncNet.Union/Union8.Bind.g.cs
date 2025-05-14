using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Union8Bind
{public static Union<T0New, T1, T2, T3, T4, T5, T6, T7> Bind0<T0New, T0Old, T1, T2, T3, T4, T5, T6, T7>(this Union<T0Old, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0Old, Union<T0New, T1, T2, T3, T4, T5, T6, T7>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => binding(u.Value0),
		1 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT1(u.Value1),
		2 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT2(u.Value2),
		3 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT3(u.Value3),
		4 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT4(u.Value4),
		5 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT5(u.Value5),
		6 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT6(u.Value6),
		_ => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT7(u.Value7)
	};
			
		}

	public static Union<T0, T1New, T2, T3, T4, T5, T6, T7> Bind1<T1New, T0, T1Old, T2, T3, T4, T5, T6, T7>(this Union<T0, T1Old, T2, T3, T4, T5, T6, T7> union,
		Func<T1Old, Union<T0, T1New, T2, T3, T4, T5, T6, T7>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT0(u.Value0),
		1 => binding(u.Value1),
		2 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT2(u.Value2),
		3 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT3(u.Value3),
		4 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT4(u.Value4),
		5 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT5(u.Value5),
		6 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT6(u.Value6),
		_ => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT7(u.Value7)
	};
			
		}

	public static Union<T0, T1, T2New, T3, T4, T5, T6, T7> Bind2<T2New, T0, T1, T2Old, T3, T4, T5, T6, T7>(this Union<T0, T1, T2Old, T3, T4, T5, T6, T7> union,
		Func<T2Old, Union<T0, T1, T2New, T3, T4, T5, T6, T7>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT0(u.Value0),
		1 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT1(u.Value1),
		2 => binding(u.Value2),
		3 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT3(u.Value3),
		4 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT4(u.Value4),
		5 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT5(u.Value5),
		6 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT6(u.Value6),
		_ => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT7(u.Value7)
	};
			
		}

	public static Union<T0, T1, T2, T3New, T4, T5, T6, T7> Bind3<T3New, T0, T1, T2, T3Old, T4, T5, T6, T7>(this Union<T0, T1, T2, T3Old, T4, T5, T6, T7> union,
		Func<T3Old, Union<T0, T1, T2, T3New, T4, T5, T6, T7>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT2(u.Value2),
		3 => binding(u.Value3),
		4 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT4(u.Value4),
		5 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT5(u.Value5),
		6 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT6(u.Value6),
		_ => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT7(u.Value7)
	};
			
		}

	public static Union<T0, T1, T2, T3, T4New, T5, T6, T7> Bind4<T4New, T0, T1, T2, T3, T4Old, T5, T6, T7>(this Union<T0, T1, T2, T3, T4Old, T5, T6, T7> union,
		Func<T4Old, Union<T0, T1, T2, T3, T4New, T5, T6, T7>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT2(u.Value2),
		3 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT3(u.Value3),
		4 => binding(u.Value4),
		5 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT5(u.Value5),
		6 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT6(u.Value6),
		_ => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT7(u.Value7)
	};
			
		}

	public static Union<T0, T1, T2, T3, T4, T5New, T6, T7> Bind5<T5New, T0, T1, T2, T3, T4, T5Old, T6, T7>(this Union<T0, T1, T2, T3, T4, T5Old, T6, T7> union,
		Func<T5Old, Union<T0, T1, T2, T3, T4, T5New, T6, T7>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT2(u.Value2),
		3 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT3(u.Value3),
		4 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT4(u.Value4),
		5 => binding(u.Value5),
		6 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT6(u.Value6),
		_ => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT7(u.Value7)
	};
			
		}

	public static Union<T0, T1, T2, T3, T4, T5, T6New, T7> Bind6<T6New, T0, T1, T2, T3, T4, T5, T6Old, T7>(this Union<T0, T1, T2, T3, T4, T5, T6Old, T7> union,
		Func<T6Old, Union<T0, T1, T2, T3, T4, T5, T6New, T7>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT2(u.Value2),
		3 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT3(u.Value3),
		4 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT4(u.Value4),
		5 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT5(u.Value5),
		6 => binding(u.Value6),
		_ => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT7(u.Value7)
	};
			
		}

	public static Union<T0, T1, T2, T3, T4, T5, T6, T7New> Bind7<T7New, T0, T1, T2, T3, T4, T5, T6, T7Old>(this Union<T0, T1, T2, T3, T4, T5, T6, T7Old> union,
		Func<T7Old, Union<T0, T1, T2, T3, T4, T5, T6, T7New>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT2(u.Value2),
		3 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT3(u.Value3),
		4 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT4(u.Value4),
		5 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT5(u.Value5),
		6 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT6(u.Value6),
		_ => binding(u.Value7)
	};
			
		}

	public static async Task<Union<T0New, T1, T2, T3, T4, T5, T6, T7>> Bind0<T0New, T0Old, T1, T2, T3, T4, T5, T6, T7>(this Task<Union<T0Old, T1, T2, T3, T4, T5, T6, T7>> union,
		Func<T0Old, Task<Union<T0New, T1, T2, T3, T4, T5, T6, T7>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => binding(u.Value0),
		1 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
		5 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
		6 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
		_ => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1New, T2, T3, T4, T5, T6, T7>> Bind1<T1New, T0, T1Old, T2, T3, T4, T5, T6, T7>(this Task<Union<T0, T1Old, T2, T3, T4, T5, T6, T7>> union,
		Func<T1Old, Task<Union<T0, T1New, T2, T3, T4, T5, T6, T7>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
		1 => binding(u.Value1),
		2 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
		5 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
		6 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
		_ => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2New, T3, T4, T5, T6, T7>> Bind2<T2New, T0, T1, T2Old, T3, T4, T5, T6, T7>(this Task<Union<T0, T1, T2Old, T3, T4, T5, T6, T7>> union,
		Func<T2Old, Task<Union<T0, T1, T2New, T3, T4, T5, T6, T7>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
		2 => binding(u.Value2),
		3 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
		5 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
		6 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
		_ => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3New, T4, T5, T6, T7>> Bind3<T3New, T0, T1, T2, T3Old, T4, T5, T6, T7>(this Task<Union<T0, T1, T2, T3Old, T4, T5, T6, T7>> union,
		Func<T3Old, Task<Union<T0, T1, T2, T3New, T4, T5, T6, T7>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
		3 => binding(u.Value3),
		4 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
		5 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
		6 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
		_ => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4New, T5, T6, T7>> Bind4<T4New, T0, T1, T2, T3, T4Old, T5, T6, T7>(this Task<Union<T0, T1, T2, T3, T4Old, T5, T6, T7>> union,
		Func<T4Old, Task<Union<T0, T1, T2, T3, T4New, T5, T6, T7>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
		4 => binding(u.Value4),
		5 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
		6 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
		_ => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT7(Task.FromResult(u.Value7))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5New, T6, T7>> Bind5<T5New, T0, T1, T2, T3, T4, T5Old, T6, T7>(this Task<Union<T0, T1, T2, T3, T4, T5Old, T6, T7>> union,
		Func<T5Old, Task<Union<T0, T1, T2, T3, T4, T5New, T6, T7>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT4(Task.FromResult(u.Value4)),
		5 => binding(u.Value5),
		6 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT6(Task.FromResult(u.Value6)),
		_ => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT7(Task.FromResult(u.Value7))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6New, T7>> Bind6<T6New, T0, T1, T2, T3, T4, T5, T6Old, T7>(this Task<Union<T0, T1, T2, T3, T4, T5, T6Old, T7>> union,
		Func<T6Old, Task<Union<T0, T1, T2, T3, T4, T5, T6New, T7>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT4(Task.FromResult(u.Value4)),
		5 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT5(Task.FromResult(u.Value5)),
		6 => binding(u.Value6),
		_ => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT7(Task.FromResult(u.Value7))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6, T7New>> Bind7<T7New, T0, T1, T2, T3, T4, T5, T6, T7Old>(this Task<Union<T0, T1, T2, T3, T4, T5, T6, T7Old>> union,
		Func<T7Old, Task<Union<T0, T1, T2, T3, T4, T5, T6, T7New>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT4(Task.FromResult(u.Value4)),
		5 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT5(Task.FromResult(u.Value5)),
		6 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT6(Task.FromResult(u.Value6)),
		_ => binding(u.Value7)
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0New, T1, T2, T3, T4, T5, T6, T7>> Bind0<T0New, T0Old, T1, T2, T3, T4, T5, T6, T7>(this Union<T0Old, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0Old, Task<Union<T0New, T1, T2, T3, T4, T5, T6, T7>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => binding(u.Value0),
		1 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
		5 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
		6 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
		_ => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1New, T2, T3, T4, T5, T6, T7>> Bind1<T1New, T0, T1Old, T2, T3, T4, T5, T6, T7>(this Union<T0, T1Old, T2, T3, T4, T5, T6, T7> union,
		Func<T1Old, Task<Union<T0, T1New, T2, T3, T4, T5, T6, T7>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
		1 => binding(u.Value1),
		2 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
		5 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
		6 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
		_ => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2New, T3, T4, T5, T6, T7>> Bind2<T2New, T0, T1, T2Old, T3, T4, T5, T6, T7>(this Union<T0, T1, T2Old, T3, T4, T5, T6, T7> union,
		Func<T2Old, Task<Union<T0, T1, T2New, T3, T4, T5, T6, T7>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
		2 => binding(u.Value2),
		3 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
		5 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
		6 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
		_ => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3New, T4, T5, T6, T7>> Bind3<T3New, T0, T1, T2, T3Old, T4, T5, T6, T7>(this Union<T0, T1, T2, T3Old, T4, T5, T6, T7> union,
		Func<T3Old, Task<Union<T0, T1, T2, T3New, T4, T5, T6, T7>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
		3 => binding(u.Value3),
		4 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
		5 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
		6 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
		_ => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4New, T5, T6, T7>> Bind4<T4New, T0, T1, T2, T3, T4Old, T5, T6, T7>(this Union<T0, T1, T2, T3, T4Old, T5, T6, T7> union,
		Func<T4Old, Task<Union<T0, T1, T2, T3, T4New, T5, T6, T7>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
		4 => binding(u.Value4),
		5 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
		6 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
		_ => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT7(Task.FromResult(u.Value7))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5New, T6, T7>> Bind5<T5New, T0, T1, T2, T3, T4, T5Old, T6, T7>(this Union<T0, T1, T2, T3, T4, T5Old, T6, T7> union,
		Func<T5Old, Task<Union<T0, T1, T2, T3, T4, T5New, T6, T7>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT4(Task.FromResult(u.Value4)),
		5 => binding(u.Value5),
		6 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT6(Task.FromResult(u.Value6)),
		_ => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT7(Task.FromResult(u.Value7))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6New, T7>> Bind6<T6New, T0, T1, T2, T3, T4, T5, T6Old, T7>(this Union<T0, T1, T2, T3, T4, T5, T6Old, T7> union,
		Func<T6Old, Task<Union<T0, T1, T2, T3, T4, T5, T6New, T7>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT4(Task.FromResult(u.Value4)),
		5 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT5(Task.FromResult(u.Value5)),
		6 => binding(u.Value6),
		_ => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT7(Task.FromResult(u.Value7))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6, T7New>> Bind7<T7New, T0, T1, T2, T3, T4, T5, T6, T7Old>(this Union<T0, T1, T2, T3, T4, T5, T6, T7Old> union,
		Func<T7Old, Task<Union<T0, T1, T2, T3, T4, T5, T6, T7New>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT4(Task.FromResult(u.Value4)),
		5 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT5(Task.FromResult(u.Value5)),
		6 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT6(Task.FromResult(u.Value6)),
		_ => binding(u.Value7)
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0New, T1, T2, T3, T4, T5, T6, T7>> Bind0<T0New, T0Old, T1, T2, T3, T4, T5, T6, T7>(this Task<Union<T0Old, T1, T2, T3, T4, T5, T6, T7>> union,
		Func<T0Old, Union<T0New, T1, T2, T3, T4, T5, T6, T7>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => binding(u.Value0),
		1 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT1(u.Value1),
		2 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT2(u.Value2),
		3 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT3(u.Value3),
		4 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT4(u.Value4),
		5 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT5(u.Value5),
		6 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT6(u.Value6),
		_ => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT7(u.Value7)
	};
			
		}

	public static async Task<Union<T0, T1New, T2, T3, T4, T5, T6, T7>> Bind1<T1New, T0, T1Old, T2, T3, T4, T5, T6, T7>(this Task<Union<T0, T1Old, T2, T3, T4, T5, T6, T7>> union,
		Func<T1Old, Union<T0, T1New, T2, T3, T4, T5, T6, T7>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT0(u.Value0),
		1 => binding(u.Value1),
		2 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT2(u.Value2),
		3 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT3(u.Value3),
		4 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT4(u.Value4),
		5 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT5(u.Value5),
		6 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT6(u.Value6),
		_ => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT7(u.Value7)
	};
			
		}

	public static async Task<Union<T0, T1, T2New, T3, T4, T5, T6, T7>> Bind2<T2New, T0, T1, T2Old, T3, T4, T5, T6, T7>(this Task<Union<T0, T1, T2Old, T3, T4, T5, T6, T7>> union,
		Func<T2Old, Union<T0, T1, T2New, T3, T4, T5, T6, T7>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT0(u.Value0),
		1 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT1(u.Value1),
		2 => binding(u.Value2),
		3 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT3(u.Value3),
		4 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT4(u.Value4),
		5 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT5(u.Value5),
		6 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT6(u.Value6),
		_ => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT7(u.Value7)
	};
			
		}

	public static async Task<Union<T0, T1, T2, T3New, T4, T5, T6, T7>> Bind3<T3New, T0, T1, T2, T3Old, T4, T5, T6, T7>(this Task<Union<T0, T1, T2, T3Old, T4, T5, T6, T7>> union,
		Func<T3Old, Union<T0, T1, T2, T3New, T4, T5, T6, T7>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT2(u.Value2),
		3 => binding(u.Value3),
		4 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT4(u.Value4),
		5 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT5(u.Value5),
		6 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT6(u.Value6),
		_ => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT7(u.Value7)
	};
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4New, T5, T6, T7>> Bind4<T4New, T0, T1, T2, T3, T4Old, T5, T6, T7>(this Task<Union<T0, T1, T2, T3, T4Old, T5, T6, T7>> union,
		Func<T4Old, Union<T0, T1, T2, T3, T4New, T5, T6, T7>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT2(u.Value2),
		3 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT3(u.Value3),
		4 => binding(u.Value4),
		5 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT5(u.Value5),
		6 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT6(u.Value6),
		_ => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT7(u.Value7)
	};
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5New, T6, T7>> Bind5<T5New, T0, T1, T2, T3, T4, T5Old, T6, T7>(this Task<Union<T0, T1, T2, T3, T4, T5Old, T6, T7>> union,
		Func<T5Old, Union<T0, T1, T2, T3, T4, T5New, T6, T7>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT2(u.Value2),
		3 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT3(u.Value3),
		4 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT4(u.Value4),
		5 => binding(u.Value5),
		6 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT6(u.Value6),
		_ => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT7(u.Value7)
	};
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6New, T7>> Bind6<T6New, T0, T1, T2, T3, T4, T5, T6Old, T7>(this Task<Union<T0, T1, T2, T3, T4, T5, T6Old, T7>> union,
		Func<T6Old, Union<T0, T1, T2, T3, T4, T5, T6New, T7>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT2(u.Value2),
		3 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT3(u.Value3),
		4 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT4(u.Value4),
		5 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT5(u.Value5),
		6 => binding(u.Value6),
		_ => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT7(u.Value7)
	};
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6, T7New>> Bind7<T7New, T0, T1, T2, T3, T4, T5, T6, T7Old>(this Task<Union<T0, T1, T2, T3, T4, T5, T6, T7Old>> union,
		Func<T7Old, Union<T0, T1, T2, T3, T4, T5, T6, T7New>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT2(u.Value2),
		3 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT3(u.Value3),
		4 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT4(u.Value4),
		5 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT5(u.Value5),
		6 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT6(u.Value6),
		_ => binding(u.Value7)
	};
			
		}}
		