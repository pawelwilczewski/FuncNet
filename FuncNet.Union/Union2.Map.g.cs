using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Union2Map
{public static Union<T0New, T1> Map0<T0New, T0Old, T1>(this Union<T0Old, T1> union,
		Func<T0Old, T0New> mapping){
		var u = union;
			return u.Index switch
		{
			0 => Union<T0New, T1>.FromT0(mapping(u.Value0)),
			_ => Union<T0New, T1>.FromT1(u.Value1),
			};
			
		}

	public static Union<T0, T1New> Map1<T1New, T0, T1Old>(this Union<T0, T1Old> union,
		Func<T1Old, T1New> mapping){
		var u = union;
			return u.Index switch
		{
			0 => Union<T0, T1New>.FromT0(u.Value0),
			_ => Union<T0, T1New>.FromT1(mapping(u.Value1)),
			};
			
		}

	public static async Task<Union<T0New, T1>> Map0<T0New, T0Old, T1>(this Task<Union<T0Old, T1>> union,
		Func<T0Old, Task<T0New>> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0New, T1>.FromT0(mapping(u.Value0)),
			_ => Union<T0New, T1>.FromT1(Task.FromResult(u.Value1)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1New>> Map1<T1New, T0, T1Old>(this Task<Union<T0, T1Old>> union,
		Func<T1Old, Task<T1New>> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1New>.FromT0(Task.FromResult(u.Value0)),
			_ => Union<T0, T1New>.FromT1(mapping(u.Value1)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0New, T1>> Map0<T0New, T0Old, T1>(this Union<T0Old, T1> union,
		Func<T0Old, Task<T0New>> mapping,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0New, T1>.FromT0(mapping(u.Value0)),
			_ => Union<T0New, T1>.FromT1(Task.FromResult(u.Value1)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1New>> Map1<T1New, T0, T1Old>(this Union<T0, T1Old> union,
		Func<T1Old, Task<T1New>> mapping,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1New>.FromT0(Task.FromResult(u.Value0)),
			_ => Union<T0, T1New>.FromT1(mapping(u.Value1)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0New, T1>> Map0<T0New, T0Old, T1>(this Task<Union<T0Old, T1>> union,
		Func<T0Old, T0New> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0New, T1>.FromT0(mapping(u.Value0)),
			_ => Union<T0New, T1>.FromT1(u.Value1),
			};
			
		}

	public static async Task<Union<T0, T1New>> Map1<T1New, T0, T1Old>(this Task<Union<T0, T1Old>> union,
		Func<T1Old, T1New> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0, T1New>.FromT0(u.Value0),
			_ => Union<T0, T1New>.FromT1(mapping(u.Value1)),
			};
			
		}}
		