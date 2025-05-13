using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Union6Map
{public static Union<T0New, T1, T2, T3, T4, T5> Map0<T0New, T0Old, T1, T2, T3, T4, T5>(this Union<T0Old, T1, T2, T3, T4, T5> union,
		Func<T0Old, T0New> mapping){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => mapping(u.Value0),
		1 => u.Value1,
		2 => u.Value2,
		3 => u.Value3,
		4 => u.Value4,
		_ => u.Value5
	};
			
		}

	public static Union<T0, T1New, T2, T3, T4, T5> Map1<T1New, T0, T1Old, T2, T3, T4, T5>(this Union<T0, T1Old, T2, T3, T4, T5> union,
		Func<T1Old, T1New> mapping){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => u.Value0,
		1 => mapping(u.Value1),
		2 => u.Value2,
		3 => u.Value3,
		4 => u.Value4,
		_ => u.Value5
	};
			
		}

	public static Union<T0, T1, T2New, T3, T4, T5> Map2<T2New, T0, T1, T2Old, T3, T4, T5>(this Union<T0, T1, T2Old, T3, T4, T5> union,
		Func<T2Old, T2New> mapping){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => u.Value0,
		1 => u.Value1,
		2 => mapping(u.Value2),
		3 => u.Value3,
		4 => u.Value4,
		_ => u.Value5
	};
			
		}

	public static Union<T0, T1, T2, T3New, T4, T5> Map3<T3New, T0, T1, T2, T3Old, T4, T5>(this Union<T0, T1, T2, T3Old, T4, T5> union,
		Func<T3Old, T3New> mapping){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => u.Value0,
		1 => u.Value1,
		2 => u.Value2,
		3 => mapping(u.Value3),
		4 => u.Value4,
		_ => u.Value5
	};
			
		}

	public static Union<T0, T1, T2, T3, T4New, T5> Map4<T4New, T0, T1, T2, T3, T4Old, T5>(this Union<T0, T1, T2, T3, T4Old, T5> union,
		Func<T4Old, T4New> mapping){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => u.Value0,
		1 => u.Value1,
		2 => u.Value2,
		3 => u.Value3,
		4 => mapping(u.Value4),
		_ => u.Value5
	};
			
		}

	public static Union<T0, T1, T2, T3, T4, T5New> Map5<T5New, T0, T1, T2, T3, T4, T5Old>(this Union<T0, T1, T2, T3, T4, T5Old> union,
		Func<T5Old, T5New> mapping){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => u.Value0,
		1 => u.Value1,
		2 => u.Value2,
		3 => u.Value3,
		4 => u.Value4,
		_ => mapping(u.Value5)
	};
			
		}

	public static async Task<Union<T0New, T1, T2, T3, T4, T5>> Map0<T0New, T0Old, T1, T2, T3, T4, T5>(this Task<Union<T0Old, T1, T2, T3, T4, T5>> union,
		Func<T0Old, Task<T0New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0New, T1, T2, T3, T4, T5>.FromT0(mapping(u.Value0)),
		1 => Union<T0New, T1, T2, T3, T4, T5>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0New, T1, T2, T3, T4, T5>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0New, T1, T2, T3, T4, T5>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0New, T1, T2, T3, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0New, T1, T2, T3, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1New, T2, T3, T4, T5>> Map1<T1New, T0, T1Old, T2, T3, T4, T5>(this Task<Union<T0, T1Old, T2, T3, T4, T5>> union,
		Func<T1Old, Task<T1New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1New, T2, T3, T4, T5>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1New, T2, T3, T4, T5>.FromT1(mapping(u.Value1)),
		2 => Union<T0, T1New, T2, T3, T4, T5>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1New, T2, T3, T4, T5>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1New, T2, T3, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0, T1New, T2, T3, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2New, T3, T4, T5>> Map2<T2New, T0, T1, T2Old, T3, T4, T5>(this Task<Union<T0, T1, T2Old, T3, T4, T5>> union,
		Func<T2Old, Task<T2New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2New, T3, T4, T5>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2New, T3, T4, T5>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2New, T3, T4, T5>.FromT2(mapping(u.Value2)),
		3 => Union<T0, T1, T2New, T3, T4, T5>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1, T2New, T3, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0, T1, T2New, T3, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3New, T4, T5>> Map3<T3New, T0, T1, T2, T3Old, T4, T5>(this Task<Union<T0, T1, T2, T3Old, T4, T5>> union,
		Func<T3Old, Task<T3New>> mapping,
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
		3 => Union<T0, T1, T2, T3New, T4, T5>.FromT3(mapping(u.Value3)),
		4 => Union<T0, T1, T2, T3New, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0, T1, T2, T3New, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4New, T5>> Map4<T4New, T0, T1, T2, T3, T4Old, T5>(this Task<Union<T0, T1, T2, T3, T4Old, T5>> union,
		Func<T4Old, Task<T4New>> mapping,
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
		4 => Union<T0, T1, T2, T3, T4New, T5>.FromT4(mapping(u.Value4)),
		_ => Union<T0, T1, T2, T3, T4New, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5New>> Map5<T5New, T0, T1, T2, T3, T4, T5Old>(this Task<Union<T0, T1, T2, T3, T4, T5Old>> union,
		Func<T5Old, Task<T5New>> mapping,
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
		_ => Union<T0, T1, T2, T3, T4, T5New>.FromT5(mapping(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0New, T1, T2, T3, T4, T5>> Map0<T0New, T0Old, T1, T2, T3, T4, T5>(this Union<T0Old, T1, T2, T3, T4, T5> union,
		Func<T0Old, Task<T0New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0New, T1, T2, T3, T4, T5>.FromT0(mapping(u.Value0)),
		1 => Union<T0New, T1, T2, T3, T4, T5>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0New, T1, T2, T3, T4, T5>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0New, T1, T2, T3, T4, T5>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0New, T1, T2, T3, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0New, T1, T2, T3, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1New, T2, T3, T4, T5>> Map1<T1New, T0, T1Old, T2, T3, T4, T5>(this Union<T0, T1Old, T2, T3, T4, T5> union,
		Func<T1Old, Task<T1New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1New, T2, T3, T4, T5>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1New, T2, T3, T4, T5>.FromT1(mapping(u.Value1)),
		2 => Union<T0, T1New, T2, T3, T4, T5>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1New, T2, T3, T4, T5>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1New, T2, T3, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0, T1New, T2, T3, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2New, T3, T4, T5>> Map2<T2New, T0, T1, T2Old, T3, T4, T5>(this Union<T0, T1, T2Old, T3, T4, T5> union,
		Func<T2Old, Task<T2New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2New, T3, T4, T5>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2New, T3, T4, T5>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2New, T3, T4, T5>.FromT2(mapping(u.Value2)),
		3 => Union<T0, T1, T2New, T3, T4, T5>.FromT3(Task.FromResult(u.Value3)),
		4 => Union<T0, T1, T2New, T3, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0, T1, T2New, T3, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3New, T4, T5>> Map3<T3New, T0, T1, T2, T3Old, T4, T5>(this Union<T0, T1, T2, T3Old, T4, T5> union,
		Func<T3Old, Task<T3New>> mapping,
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
		3 => Union<T0, T1, T2, T3New, T4, T5>.FromT3(mapping(u.Value3)),
		4 => Union<T0, T1, T2, T3New, T4, T5>.FromT4(Task.FromResult(u.Value4)),
		_ => Union<T0, T1, T2, T3New, T4, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4New, T5>> Map4<T4New, T0, T1, T2, T3, T4Old, T5>(this Union<T0, T1, T2, T3, T4Old, T5> union,
		Func<T4Old, Task<T4New>> mapping,
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
		4 => Union<T0, T1, T2, T3, T4New, T5>.FromT4(mapping(u.Value4)),
		_ => Union<T0, T1, T2, T3, T4New, T5>.FromT5(Task.FromResult(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5New>> Map5<T5New, T0, T1, T2, T3, T4, T5Old>(this Union<T0, T1, T2, T3, T4, T5Old> union,
		Func<T5Old, Task<T5New>> mapping,
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
		_ => Union<T0, T1, T2, T3, T4, T5New>.FromT5(mapping(u.Value5))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0New, T1, T2, T3, T4, T5>> Map0<T0New, T0Old, T1, T2, T3, T4, T5>(this Task<Union<T0Old, T1, T2, T3, T4, T5>> union,
		Func<T0Old, T0New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => mapping(u.Value0),
		1 => Union<T0New, T1, T2, T3, T4, T5>.FromT1(u.Value1),
		2 => Union<T0New, T1, T2, T3, T4, T5>.FromT2(u.Value2),
		3 => Union<T0New, T1, T2, T3, T4, T5>.FromT3(u.Value3),
		4 => Union<T0New, T1, T2, T3, T4, T5>.FromT4(u.Value4),
		_ => Union<T0New, T1, T2, T3, T4, T5>.FromT5(u.Value5)
	};
			
		}

	public static async Task<Union<T0, T1New, T2, T3, T4, T5>> Map1<T1New, T0, T1Old, T2, T3, T4, T5>(this Task<Union<T0, T1Old, T2, T3, T4, T5>> union,
		Func<T1Old, T1New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1New, T2, T3, T4, T5>.FromT0(u.Value0),
		1 => mapping(u.Value1),
		2 => Union<T0, T1New, T2, T3, T4, T5>.FromT2(u.Value2),
		3 => Union<T0, T1New, T2, T3, T4, T5>.FromT3(u.Value3),
		4 => Union<T0, T1New, T2, T3, T4, T5>.FromT4(u.Value4),
		_ => Union<T0, T1New, T2, T3, T4, T5>.FromT5(u.Value5)
	};
			
		}

	public static async Task<Union<T0, T1, T2New, T3, T4, T5>> Map2<T2New, T0, T1, T2Old, T3, T4, T5>(this Task<Union<T0, T1, T2Old, T3, T4, T5>> union,
		Func<T2Old, T2New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2New, T3, T4, T5>.FromT0(u.Value0),
		1 => Union<T0, T1, T2New, T3, T4, T5>.FromT1(u.Value1),
		2 => mapping(u.Value2),
		3 => Union<T0, T1, T2New, T3, T4, T5>.FromT3(u.Value3),
		4 => Union<T0, T1, T2New, T3, T4, T5>.FromT4(u.Value4),
		_ => Union<T0, T1, T2New, T3, T4, T5>.FromT5(u.Value5)
	};
			
		}

	public static async Task<Union<T0, T1, T2, T3New, T4, T5>> Map3<T3New, T0, T1, T2, T3Old, T4, T5>(this Task<Union<T0, T1, T2, T3Old, T4, T5>> union,
		Func<T3Old, T3New> mapping,
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
		3 => mapping(u.Value3),
		4 => Union<T0, T1, T2, T3New, T4, T5>.FromT4(u.Value4),
		_ => Union<T0, T1, T2, T3New, T4, T5>.FromT5(u.Value5)
	};
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4New, T5>> Map4<T4New, T0, T1, T2, T3, T4Old, T5>(this Task<Union<T0, T1, T2, T3, T4Old, T5>> union,
		Func<T4Old, T4New> mapping,
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
		4 => mapping(u.Value4),
		_ => Union<T0, T1, T2, T3, T4New, T5>.FromT5(u.Value5)
	};
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5New>> Map5<T5New, T0, T1, T2, T3, T4, T5Old>(this Task<Union<T0, T1, T2, T3, T4, T5Old>> union,
		Func<T5Old, T5New> mapping,
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
		_ => mapping(u.Value5)
	};
			
		}}
		