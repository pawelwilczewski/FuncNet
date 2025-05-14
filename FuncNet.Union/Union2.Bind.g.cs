using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Union2Bind
{public static Union<T0New, T1> Bind0<T0New, T0Old, T1>(this Union<T0Old, T1> union,
		Func<T0Old, Union<T0New, T1>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => binding(u.Value0),
		_ => Union<T0New, T1>.FromT1(u.Value1)
	};
			
		}

	public static Union<T0, T1New> Bind1<T1New, T0, T1Old>(this Union<T0, T1Old> union,
		Func<T1Old, Union<T0, T1New>> binding){
		var u = union;
			;
			return 
	u.Index switch
	{
		0 => Union<T0, T1New>.FromT0(u.Value0),
		_ => binding(u.Value1)
	};
			
		}

	public static async Task<Union<T0New, T1>> Bind0<T0New, T0Old, T1>(this Task<Union<T0Old, T1>> union,
		Func<T0Old, Task<Union<T0New, T1>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => binding(u.Value0),
		_ => Union<T0New, T1>.FromT1(Task.FromResult(u.Value1))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1New>> Bind1<T1New, T0, T1Old>(this Task<Union<T0, T1Old>> union,
		Func<T1Old, Task<Union<T0, T1New>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1New>.FromT0(Task.FromResult(u.Value0)),
		_ => binding(u.Value1)
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0New, T1>> Bind0<T0New, T0Old, T1>(this Union<T0Old, T1> union,
		Func<T0Old, Task<Union<T0New, T1>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => binding(u.Value0),
		_ => Union<T0New, T1>.FromT1(Task.FromResult(u.Value1))
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0, T1New>> Bind1<T1New, T0, T1Old>(this Union<T0, T1Old> union,
		Func<T1Old, Task<Union<T0, T1New>>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (
	u.Index switch
	{
		0 => Union<T0, T1New>.FromT0(Task.FromResult(u.Value0)),
		_ => binding(u.Value1)
	}).ConfigureAwait(continueOnCapturedContext);
			
		}

	public static async Task<Union<T0New, T1>> Bind0<T0New, T0Old, T1>(this Task<Union<T0Old, T1>> union,
		Func<T0Old, Union<T0New, T1>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => binding(u.Value0),
		_ => Union<T0New, T1>.FromT1(u.Value1)
	};
			
		}

	public static async Task<Union<T0, T1New>> Bind1<T1New, T0, T1Old>(this Task<Union<T0, T1Old>> union,
		Func<T1Old, Union<T0, T1New>> binding,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true){
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
			cancellationToken.ThrowIfCancellationRequested();
			return 
	u.Index switch
	{
		0 => Union<T0, T1New>.FromT0(u.Value0),
		_ => binding(u.Value1)
	};
			
		}}
		