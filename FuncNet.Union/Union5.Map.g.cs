using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Union5Map
{public static Union<T0New, T1, T2, T3, T4> Map0<T0New, T0Old, T1, T2, T3, T4>(this Union<T0Old, T1, T2, T3, T4> union,
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
		_ => u.Value4
	};
			
		}

	public static Union<T0, T1New, T2, T3, T4> Map1<T1New, T0, T1Old, T2, T3, T4>(this Union<T0, T1Old, T2, T3, T4> union,
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
		_ => u.Value4
	};
			
		}

	public static Union<T0, T1, T2New, T3, T4> Map2<T2New, T0, T1, T2Old, T3, T4>(this Union<T0, T1, T2Old, T3, T4> union,
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
		_ => u.Value4
	};
			
		}

	public static Union<T0, T1, T2, T3New, T4> Map3<T3New, T0, T1, T2, T3Old, T4>(this Union<T0, T1, T2, T3Old, T4> union,
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
		_ => u.Value4
	};
			
		}

	public static Union<T0, T1, T2, T3, T4New> Map4<T4New, T0, T1, T2, T3, T4Old>(this Union<T0, T1, T2, T3, T4Old> union,
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
		_ => mapping(u.Value4)
	};
			
		}

	public static async Task<Union<T0New, T1, T2, T3, T4>> Map0<T0New, T0Old, T1, T2, T3, T4>(this Task<Union<T0Old, T1, T2, T3, T4>> union,
		Func<T0Old, Task<T0New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0New, T1, T2, T3, T4>.FromT0(mapping(u.Value0)),
		1 => Union<T0New, T1, T2, T3, T4>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0New, T1, T2, T3, T4>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0New, T1, T2, T3, T4>.FromT3(Task.FromResult(u.Value3)),
		_ => Union<T0New, T1, T2, T3, T4>.FromT4(Task.FromResult(u.Value4))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1New, T2, T3, T4>> Map1<T1New, T0, T1Old, T2, T3, T4>(this Task<Union<T0, T1Old, T2, T3, T4>> union,
		Func<T1Old, Task<T1New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1New, T2, T3, T4>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1New, T2, T3, T4>.FromT1(mapping(u.Value1)),
		2 => Union<T0, T1New, T2, T3, T4>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1New, T2, T3, T4>.FromT3(Task.FromResult(u.Value3)),
		_ => Union<T0, T1New, T2, T3, T4>.FromT4(Task.FromResult(u.Value4))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2New, T3, T4>> Map2<T2New, T0, T1, T2Old, T3, T4>(this Task<Union<T0, T1, T2Old, T3, T4>> union,
		Func<T2Old, Task<T2New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2New, T3, T4>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2New, T3, T4>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2New, T3, T4>.FromT2(mapping(u.Value2)),
		3 => Union<T0, T1, T2New, T3, T4>.FromT3(Task.FromResult(u.Value3)),
		_ => Union<T0, T1, T2New, T3, T4>.FromT4(Task.FromResult(u.Value4))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3New, T4>> Map3<T3New, T0, T1, T2, T3Old, T4>(this Task<Union<T0, T1, T2, T3Old, T4>> union,
		Func<T3Old, Task<T3New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3New, T4>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3New, T4>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3New, T4>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3New, T4>.FromT3(mapping(u.Value3)),
		_ => Union<T0, T1, T2, T3New, T4>.FromT4(Task.FromResult(u.Value4))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4New>> Map4<T4New, T0, T1, T2, T3, T4Old>(this Task<Union<T0, T1, T2, T3, T4Old>> union,
		Func<T4Old, Task<T4New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4New>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3, T4New>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3, T4New>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3, T4New>.FromT3(Task.FromResult(u.Value3)),
		_ => Union<T0, T1, T2, T3, T4New>.FromT4(mapping(u.Value4))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0New, T1, T2, T3, T4>> Map0<T0New, T0Old, T1, T2, T3, T4>(this Union<T0Old, T1, T2, T3, T4> union,
		Func<T0Old, Task<T0New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0New, T1, T2, T3, T4>.FromT0(mapping(u.Value0)),
		1 => Union<T0New, T1, T2, T3, T4>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0New, T1, T2, T3, T4>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0New, T1, T2, T3, T4>.FromT3(Task.FromResult(u.Value3)),
		_ => Union<T0New, T1, T2, T3, T4>.FromT4(Task.FromResult(u.Value4))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1New, T2, T3, T4>> Map1<T1New, T0, T1Old, T2, T3, T4>(this Union<T0, T1Old, T2, T3, T4> union,
		Func<T1Old, Task<T1New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1New, T2, T3, T4>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1New, T2, T3, T4>.FromT1(mapping(u.Value1)),
		2 => Union<T0, T1New, T2, T3, T4>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1New, T2, T3, T4>.FromT3(Task.FromResult(u.Value3)),
		_ => Union<T0, T1New, T2, T3, T4>.FromT4(Task.FromResult(u.Value4))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2New, T3, T4>> Map2<T2New, T0, T1, T2Old, T3, T4>(this Union<T0, T1, T2Old, T3, T4> union,
		Func<T2Old, Task<T2New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2New, T3, T4>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2New, T3, T4>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2New, T3, T4>.FromT2(mapping(u.Value2)),
		3 => Union<T0, T1, T2New, T3, T4>.FromT3(Task.FromResult(u.Value3)),
		_ => Union<T0, T1, T2New, T3, T4>.FromT4(Task.FromResult(u.Value4))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3New, T4>> Map3<T3New, T0, T1, T2, T3Old, T4>(this Union<T0, T1, T2, T3Old, T4> union,
		Func<T3Old, Task<T3New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3New, T4>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3New, T4>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3New, T4>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3New, T4>.FromT3(mapping(u.Value3)),
		_ => Union<T0, T1, T2, T3New, T4>.FromT4(Task.FromResult(u.Value4))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4New>> Map4<T4New, T0, T1, T2, T3, T4Old>(this Union<T0, T1, T2, T3, T4Old> union,
		Func<T4Old, Task<T4New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4New>.FromT0(Task.FromResult(u.Value0)),
		1 => Union<T0, T1, T2, T3, T4New>.FromT1(Task.FromResult(u.Value1)),
		2 => Union<T0, T1, T2, T3, T4New>.FromT2(Task.FromResult(u.Value2)),
		3 => Union<T0, T1, T2, T3, T4New>.FromT3(Task.FromResult(u.Value3)),
		_ => Union<T0, T1, T2, T3, T4New>.FromT4(mapping(u.Value4))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0New, T1, T2, T3, T4>> Map0<T0New, T0Old, T1, T2, T3, T4>(this Task<Union<T0Old, T1, T2, T3, T4>> union,
		Func<T0Old, T0New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => mapping(u.Value0),
		1 => Union<T0New, T1, T2, T3, T4>.FromT1(u.Value1),
		2 => Union<T0New, T1, T2, T3, T4>.FromT2(u.Value2),
		3 => Union<T0New, T1, T2, T3, T4>.FromT3(u.Value3),
		_ => Union<T0New, T1, T2, T3, T4>.FromT4(u.Value4)
	};
			
		}

	public static async Task<Union<T0, T1New, T2, T3, T4>> Map1<T1New, T0, T1Old, T2, T3, T4>(this Task<Union<T0, T1Old, T2, T3, T4>> union,
		Func<T1Old, T1New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1New, T2, T3, T4>.FromT0(u.Value0),
		1 => mapping(u.Value1),
		2 => Union<T0, T1New, T2, T3, T4>.FromT2(u.Value2),
		3 => Union<T0, T1New, T2, T3, T4>.FromT3(u.Value3),
		_ => Union<T0, T1New, T2, T3, T4>.FromT4(u.Value4)
	};
			
		}

	public static async Task<Union<T0, T1, T2New, T3, T4>> Map2<T2New, T0, T1, T2Old, T3, T4>(this Task<Union<T0, T1, T2Old, T3, T4>> union,
		Func<T2Old, T2New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2New, T3, T4>.FromT0(u.Value0),
		1 => Union<T0, T1, T2New, T3, T4>.FromT1(u.Value1),
		2 => mapping(u.Value2),
		3 => Union<T0, T1, T2New, T3, T4>.FromT3(u.Value3),
		_ => Union<T0, T1, T2New, T3, T4>.FromT4(u.Value4)
	};
			
		}

	public static async Task<Union<T0, T1, T2, T3New, T4>> Map3<T3New, T0, T1, T2, T3Old, T4>(this Task<Union<T0, T1, T2, T3Old, T4>> union,
		Func<T3Old, T3New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3New, T4>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3New, T4>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3New, T4>.FromT2(u.Value2),
		3 => mapping(u.Value3),
		_ => Union<T0, T1, T2, T3New, T4>.FromT4(u.Value4)
	};
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4New>> Map4<T4New, T0, T1, T2, T3, T4Old>(this Task<Union<T0, T1, T2, T3, T4Old>> union,
		Func<T4Old, T4New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1, T2, T3, T4New>.FromT0(u.Value0),
		1 => Union<T0, T1, T2, T3, T4New>.FromT1(u.Value1),
		2 => Union<T0, T1, T2, T3, T4New>.FromT2(u.Value2),
		3 => Union<T0, T1, T2, T3, T4New>.FromT3(u.Value3),
		_ => mapping(u.Value4)
	};
			
		}}
		