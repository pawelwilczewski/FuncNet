using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Union3Bind
{public static Union<T0New, T1, T2> Bind0<T0New, T0Old, T1, T2>(this Union<T0Old, T1, T2> union,
		Func<T0Old, Union<T0New, T1, T2>> binding){
		var u = union;
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Union<T0New, T1, T2>.FromT1(u.Value1),
			2 => Union<T0New, T1, T2>.FromT2(u.Value2),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static Union<T0, T1New, T2> Bind1<T1New, T0, T1Old, T2>(this Union<T0, T1Old, T2> union,
		Func<T1Old, Union<T0, T1New, T2>> binding){
		var u = union;
			return u.Index switch
		{
			0 => Union<T0, T1New, T2>.FromT0(u.Value0),
			1 => binding(u.Value1),
			2 => Union<T0, T1New, T2>.FromT2(u.Value2),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static Union<T0, T1, T2New> Bind2<T2New, T0, T1, T2Old>(this Union<T0, T1, T2Old> union,
		Func<T2Old, Union<T0, T1, T2New>> binding){
		var u = union;
			return u.Index switch
		{
			0 => Union<T0, T1, T2New>.FromT0(u.Value0),
			1 => Union<T0, T1, T2New>.FromT1(u.Value1),
			2 => binding(u.Value2),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static async Task<Union<T0New, T1, T2>> Bind0<T0New, T0Old, T1, T2>(this Task<Union<T0Old, T1, T2>> union,
		Func<T0Old, Task<Union<T0New, T1, T2>>> binding,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Union<T0New, T1, T2>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0New, T1, T2>.FromT2(Task.FromResult(u.Value2)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1New, T2>> Bind1<T1New, T0, T1Old, T2>(this Task<Union<T0, T1Old, T2>> union,
		Func<T1Old, Task<Union<T0, T1New, T2>>> binding,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1New, T2>.FromT0(Task.FromResult(u.Value0)),
			1 => binding(u.Value1),
			2 => Union<T0, T1New, T2>.FromT2(Task.FromResult(u.Value2)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2New>> Bind2<T2New, T0, T1, T2Old>(this Task<Union<T0, T1, T2Old>> union,
		Func<T2Old, Task<Union<T0, T1, T2New>>> binding,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2New>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2New>.FromT1(Task.FromResult(u.Value1)),
			2 => binding(u.Value2),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0New, T1, T2>> Bind0<T0New, T0Old, T1, T2>(this Union<T0Old, T1, T2> union,
		Func<T0Old, Task<Union<T0New, T1, T2>>> binding,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => binding(u.Value0),
			1 => Union<T0New, T1, T2>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0New, T1, T2>.FromT2(Task.FromResult(u.Value2)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1New, T2>> Bind1<T1New, T0, T1Old, T2>(this Union<T0, T1Old, T2> union,
		Func<T1Old, Task<Union<T0, T1New, T2>>> binding,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1New, T2>.FromT0(Task.FromResult(u.Value0)),
			1 => binding(u.Value1),
			2 => Union<T0, T1New, T2>.FromT2(Task.FromResult(u.Value2)),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2New>> Bind2<T2New, T0, T1, T2Old>(this Union<T0, T1, T2Old> union,
		Func<T2Old, Task<Union<T0, T1, T2New>>> binding,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2New>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2New>.FromT1(Task.FromResult(u.Value1)),
			2 => binding(u.Value2),
			_ => throw new ArgumentOutOfRangeException(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0New, T1, T2>> Bind0<T0New, T0Old, T1, T2>(this Task<Union<T0Old, T1, T2>> union,
		Func<T0Old, Union<T0New, T1, T2>> binding,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => binding(u.Value0),
			1 => Union<T0New, T1, T2>.FromT1(u.Value1),
			2 => Union<T0New, T1, T2>.FromT2(u.Value2),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static async Task<Union<T0, T1New, T2>> Bind1<T1New, T0, T1Old, T2>(this Task<Union<T0, T1Old, T2>> union,
		Func<T1Old, Union<T0, T1New, T2>> binding,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0, T1New, T2>.FromT0(u.Value0),
			1 => binding(u.Value1),
			2 => Union<T0, T1New, T2>.FromT2(u.Value2),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}

	public static async Task<Union<T0, T1, T2New>> Bind2<T2New, T0, T1, T2Old>(this Task<Union<T0, T1, T2Old>> union,
		Func<T2Old, Union<T0, T1, T2New>> binding,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0, T1, T2New>.FromT0(u.Value0),
			1 => Union<T0, T1, T2New>.FromT1(u.Value1),
			2 => binding(u.Value2),
			_ => throw new ArgumentOutOfRangeException(),
			};
			
		}}
		