using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Union4Map
{public static Union<T0New, T1, T2, T3> Map0<T0New, T0Old, T1, T2, T3>(this Union<T0Old, T1, T2, T3> union,
		Func<T0Old, T0New> mapping){
		var u = union;
			;
			return u.Index switch
		{
			0 => Union<T0New, T1, T2, T3>.FromT0(mapping(u.Value0)),
			1 => Union<T0New, T1, T2, T3>.FromT1(u.Value1),
			2 => Union<T0New, T1, T2, T3>.FromT2(u.Value2),
			_ => Union<T0New, T1, T2, T3>.FromT3(u.Value3),
			};
			
		}

	public static Union<T0, T1New, T2, T3> Map1<T1New, T0, T1Old, T2, T3>(this Union<T0, T1Old, T2, T3> union,
		Func<T1Old, T1New> mapping){
		var u = union;
			;
			return u.Index switch
		{
			0 => Union<T0, T1New, T2, T3>.FromT0(u.Value0),
			1 => Union<T0, T1New, T2, T3>.FromT1(mapping(u.Value1)),
			2 => Union<T0, T1New, T2, T3>.FromT2(u.Value2),
			_ => Union<T0, T1New, T2, T3>.FromT3(u.Value3),
			};
			
		}

	public static Union<T0, T1, T2New, T3> Map2<T2New, T0, T1, T2Old, T3>(this Union<T0, T1, T2Old, T3> union,
		Func<T2Old, T2New> mapping){
		var u = union;
			;
			return u.Index switch
		{
			0 => Union<T0, T1, T2New, T3>.FromT0(u.Value0),
			1 => Union<T0, T1, T2New, T3>.FromT1(u.Value1),
			2 => Union<T0, T1, T2New, T3>.FromT2(mapping(u.Value2)),
			_ => Union<T0, T1, T2New, T3>.FromT3(u.Value3),
			};
			
		}

	public static Union<T0, T1, T2, T3New> Map3<T3New, T0, T1, T2, T3Old>(this Union<T0, T1, T2, T3Old> union,
		Func<T3Old, T3New> mapping){
		var u = union;
			;
			return u.Index switch
		{
			0 => Union<T0, T1, T2, T3New>.FromT0(u.Value0),
			1 => Union<T0, T1, T2, T3New>.FromT1(u.Value1),
			2 => Union<T0, T1, T2, T3New>.FromT2(u.Value2),
			_ => Union<T0, T1, T2, T3New>.FromT3(mapping(u.Value3)),
			};
			
		}

	public static async Task<Union<T0New, T1, T2, T3>> Map0<T0New, T0Old, T1, T2, T3>(this Task<Union<T0Old, T1, T2, T3>> union,
		Func<T0Old, Task<T0New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0New, T1, T2, T3>.FromT0(mapping(u.Value0)),
			1 => Union<T0New, T1, T2, T3>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0New, T1, T2, T3>.FromT2(Task.FromResult(u.Value2)),
			_ => Union<T0New, T1, T2, T3>.FromT3(Task.FromResult(u.Value3)),
			}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1New, T2, T3>> Map1<T1New, T0, T1Old, T2, T3>(this Task<Union<T0, T1Old, T2, T3>> union,
		Func<T1Old, Task<T1New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1New, T2, T3>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1New, T2, T3>.FromT1(mapping(u.Value1)),
			2 => Union<T0, T1New, T2, T3>.FromT2(Task.FromResult(u.Value2)),
			_ => Union<T0, T1New, T2, T3>.FromT3(Task.FromResult(u.Value3)),
			}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2New, T3>> Map2<T2New, T0, T1, T2Old, T3>(this Task<Union<T0, T1, T2Old, T3>> union,
		Func<T2Old, Task<T2New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2New, T3>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2New, T3>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2New, T3>.FromT2(mapping(u.Value2)),
			_ => Union<T0, T1, T2New, T3>.FromT3(Task.FromResult(u.Value3)),
			}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3New>> Map3<T3New, T0, T1, T2, T3Old>(this Task<Union<T0, T1, T2, T3Old>> union,
		Func<T3Old, Task<T3New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2, T3New>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2, T3New>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2, T3New>.FromT2(Task.FromResult(u.Value2)),
			_ => Union<T0, T1, T2, T3New>.FromT3(mapping(u.Value3)),
			}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0New, T1, T2, T3>> Map0<T0New, T0Old, T1, T2, T3>(this Union<T0Old, T1, T2, T3> union,
		Func<T0Old, Task<T0New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0New, T1, T2, T3>.FromT0(mapping(u.Value0)),
			1 => Union<T0New, T1, T2, T3>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0New, T1, T2, T3>.FromT2(Task.FromResult(u.Value2)),
			_ => Union<T0New, T1, T2, T3>.FromT3(Task.FromResult(u.Value3)),
			}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1New, T2, T3>> Map1<T1New, T0, T1Old, T2, T3>(this Union<T0, T1Old, T2, T3> union,
		Func<T1Old, Task<T1New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1New, T2, T3>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1New, T2, T3>.FromT1(mapping(u.Value1)),
			2 => Union<T0, T1New, T2, T3>.FromT2(Task.FromResult(u.Value2)),
			_ => Union<T0, T1New, T2, T3>.FromT3(Task.FromResult(u.Value3)),
			}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2New, T3>> Map2<T2New, T0, T1, T2Old, T3>(this Union<T0, T1, T2Old, T3> union,
		Func<T2Old, Task<T2New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2New, T3>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2New, T3>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2New, T3>.FromT2(mapping(u.Value2)),
			_ => Union<T0, T1, T2New, T3>.FromT3(Task.FromResult(u.Value3)),
			}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1, T2, T3New>> Map3<T3New, T0, T1, T2, T3Old>(this Union<T0, T1, T2, T3Old> union,
		Func<T3Old, Task<T3New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2, T3New>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2, T3New>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2, T3New>.FromT2(Task.FromResult(u.Value2)),
			_ => Union<T0, T1, T2, T3New>.FromT3(mapping(u.Value3)),
			}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0New, T1, T2, T3>> Map0<T0New, T0Old, T1, T2, T3>(this Task<Union<T0Old, T1, T2, T3>> union,
		Func<T0Old, T0New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0New, T1, T2, T3>.FromT0(mapping(u.Value0)),
			1 => Union<T0New, T1, T2, T3>.FromT1(u.Value1),
			2 => Union<T0New, T1, T2, T3>.FromT2(u.Value2),
			_ => Union<T0New, T1, T2, T3>.FromT3(u.Value3),
			};
			
		}

	public static async Task<Union<T0, T1New, T2, T3>> Map1<T1New, T0, T1Old, T2, T3>(this Task<Union<T0, T1Old, T2, T3>> union,
		Func<T1Old, T1New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0, T1New, T2, T3>.FromT0(u.Value0),
			1 => Union<T0, T1New, T2, T3>.FromT1(mapping(u.Value1)),
			2 => Union<T0, T1New, T2, T3>.FromT2(u.Value2),
			_ => Union<T0, T1New, T2, T3>.FromT3(u.Value3),
			};
			
		}

	public static async Task<Union<T0, T1, T2New, T3>> Map2<T2New, T0, T1, T2Old, T3>(this Task<Union<T0, T1, T2Old, T3>> union,
		Func<T2Old, T2New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0, T1, T2New, T3>.FromT0(u.Value0),
			1 => Union<T0, T1, T2New, T3>.FromT1(u.Value1),
			2 => Union<T0, T1, T2New, T3>.FromT2(mapping(u.Value2)),
			_ => Union<T0, T1, T2New, T3>.FromT3(u.Value3),
			};
			
		}

	public static async Task<Union<T0, T1, T2, T3New>> Map3<T3New, T0, T1, T2, T3Old>(this Task<Union<T0, T1, T2, T3Old>> union,
		Func<T3Old, T3New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0, T1, T2, T3New>.FromT0(u.Value0),
			1 => Union<T0, T1, T2, T3New>.FromT1(u.Value1),
			2 => Union<T0, T1, T2, T3New>.FromT2(u.Value2),
			_ => Union<T0, T1, T2, T3New>.FromT3(mapping(u.Value3)),
			};
			
		}}
		