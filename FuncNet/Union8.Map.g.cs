using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Union8Map
{public static Union<T0New, T1, T2, T3, T4, T5, T6, T7> Map0<T0New, T0Old, T1, T2, T3, T4, T5, T6, T7>(this Union<T0Old, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0Old, T0New> mapping){
		var u = union;
			return u.Index switch
		{
			0 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT0(mapping(u.Value0)),
			1 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT1(u.Value1),
			2 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT2(u.Value2),
			3 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT3(u.Value3),
			4 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT4(u.Value4),
			5 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT5(u.Value5),
			6 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT6(u.Value6),
			7 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT7(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static Union<T0, T1New, T2, T3, T4, T5, T6, T7> Map1<T1New, T0, T1Old, T2, T3, T4, T5, T6, T7>(this Union<T0, T1Old, T2, T3, T4, T5, T6, T7> union,
		Func<T1Old, T1New> mapping){
		var u = union;
			return u.Index switch
		{
			0 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT0(u.Value0),
			1 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT1(mapping(u.Value1)),
			2 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT2(u.Value2),
			3 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT3(u.Value3),
			4 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT4(u.Value4),
			5 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT5(u.Value5),
			6 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT6(u.Value6),
			7 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT7(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static Union<T0, T1, T2New, T3, T4, T5, T6, T7> Map2<T2New, T0, T1, T2Old, T3, T4, T5, T6, T7>(this Union<T0, T1, T2Old, T3, T4, T5, T6, T7> union,
		Func<T2Old, T2New> mapping){
		var u = union;
			return u.Index switch
		{
			0 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT0(u.Value0),
			1 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT1(u.Value1),
			2 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT2(mapping(u.Value2)),
			3 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT3(u.Value3),
			4 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT4(u.Value4),
			5 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT5(u.Value5),
			6 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT6(u.Value6),
			7 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT7(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static Union<T0, T1, T2, T3New, T4, T5, T6, T7> Map3<T3New, T0, T1, T2, T3Old, T4, T5, T6, T7>(this Union<T0, T1, T2, T3Old, T4, T5, T6, T7> union,
		Func<T3Old, T3New> mapping){
		var u = union;
			return u.Index switch
		{
			0 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT0(u.Value0),
			1 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT1(u.Value1),
			2 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT2(u.Value2),
			3 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT3(mapping(u.Value3)),
			4 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT4(u.Value4),
			5 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT5(u.Value5),
			6 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT6(u.Value6),
			7 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT7(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static Union<T0, T1, T2, T3, T4New, T5, T6, T7> Map4<T4New, T0, T1, T2, T3, T4Old, T5, T6, T7>(this Union<T0, T1, T2, T3, T4Old, T5, T6, T7> union,
		Func<T4Old, T4New> mapping){
		var u = union;
			return u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT0(u.Value0),
			1 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT1(u.Value1),
			2 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT2(u.Value2),
			3 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT3(u.Value3),
			4 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT4(mapping(u.Value4)),
			5 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT5(u.Value5),
			6 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT6(u.Value6),
			7 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT7(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static Union<T0, T1, T2, T3, T4, T5New, T6, T7> Map5<T5New, T0, T1, T2, T3, T4, T5Old, T6, T7>(this Union<T0, T1, T2, T3, T4, T5Old, T6, T7> union,
		Func<T5Old, T5New> mapping){
		var u = union;
			return u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT0(u.Value0),
			1 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT1(u.Value1),
			2 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT2(u.Value2),
			3 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT3(u.Value3),
			4 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT4(u.Value4),
			5 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT5(mapping(u.Value5)),
			6 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT6(u.Value6),
			7 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT7(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static Union<T0, T1, T2, T3, T4, T5, T6New, T7> Map6<T6New, T0, T1, T2, T3, T4, T5, T6Old, T7>(this Union<T0, T1, T2, T3, T4, T5, T6Old, T7> union,
		Func<T6Old, T6New> mapping){
		var u = union;
			return u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT0(u.Value0),
			1 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT1(u.Value1),
			2 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT2(u.Value2),
			3 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT3(u.Value3),
			4 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT4(u.Value4),
			5 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT5(u.Value5),
			6 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT6(mapping(u.Value6)),
			7 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT7(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static Union<T0, T1, T2, T3, T4, T5, T6, T7New> Map7<T7New, T0, T1, T2, T3, T4, T5, T6, T7Old>(this Union<T0, T1, T2, T3, T4, T5, T6, T7Old> union,
		Func<T7Old, T7New> mapping){
		var u = union;
			return u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT0(u.Value0),
			1 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT1(u.Value1),
			2 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT2(u.Value2),
			3 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT3(u.Value3),
			4 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT4(u.Value4),
			5 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT5(u.Value5),
			6 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT6(u.Value6),
			7 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT7(mapping(u.Value7)),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Union<T0New, T1, T2, T3, T4, T5, T6, T7>> Map0<T0New, T0Old, T1, T2, T3, T4, T5, T6, T7>(this Task<Union<T0Old, T1, T2, T3, T4, T5, T6, T7>> union,
		Func<T0Old, Task<T0New>> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT0(mapping(u.Value0)),
			1 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
			3 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
			4 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
			5 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
			6 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
			7 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1New, T2, T3, T4, T5, T6, T7>> Map1<T1New, T0, T1Old, T2, T3, T4, T5, T6, T7>(this Task<Union<T0, T1Old, T2, T3, T4, T5, T6, T7>> union,
		Func<T1Old, Task<T1New>> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT1(mapping(u.Value1)),
			2 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
			3 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
			4 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
			5 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
			6 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
			7 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2New, T3, T4, T5, T6, T7>> Map2<T2New, T0, T1, T2Old, T3, T4, T5, T6, T7>(this Task<Union<T0, T1, T2Old, T3, T4, T5, T6, T7>> union,
		Func<T2Old, Task<T2New>> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT2(mapping(u.Value2)),
			3 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
			4 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
			5 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
			6 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
			7 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3New, T4, T5, T6, T7>> Map3<T3New, T0, T1, T2, T3Old, T4, T5, T6, T7>(this Task<Union<T0, T1, T2, T3Old, T4, T5, T6, T7>> union,
		Func<T3Old, Task<T3New>> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
			3 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT3(mapping(u.Value3)),
			4 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
			5 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
			6 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
			7 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4New, T5, T6, T7>> Map4<T4New, T0, T1, T2, T3, T4Old, T5, T6, T7>(this Task<Union<T0, T1, T2, T3, T4Old, T5, T6, T7>> union,
		Func<T4Old, Task<T4New>> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
			3 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
			4 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT4(mapping(u.Value4)),
			5 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
			6 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
			7 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT7(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5New, T6, T7>> Map5<T5New, T0, T1, T2, T3, T4, T5Old, T6, T7>(this Task<Union<T0, T1, T2, T3, T4, T5Old, T6, T7>> union,
		Func<T5Old, Task<T5New>> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT2(Task.FromResult(u.Value2)),
			3 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT3(Task.FromResult(u.Value3)),
			4 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT4(Task.FromResult(u.Value4)),
			5 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT5(mapping(u.Value5)),
			6 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT6(Task.FromResult(u.Value6)),
			7 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT7(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6New, T7>> Map6<T6New, T0, T1, T2, T3, T4, T5, T6Old, T7>(this Task<Union<T0, T1, T2, T3, T4, T5, T6Old, T7>> union,
		Func<T6Old, Task<T6New>> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT2(Task.FromResult(u.Value2)),
			3 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT3(Task.FromResult(u.Value3)),
			4 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT4(Task.FromResult(u.Value4)),
			5 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT5(Task.FromResult(u.Value5)),
			6 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT6(mapping(u.Value6)),
			7 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT7(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6, T7New>> Map7<T7New, T0, T1, T2, T3, T4, T5, T6, T7Old>(this Task<Union<T0, T1, T2, T3, T4, T5, T6, T7Old>> union,
		Func<T7Old, Task<T7New>> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT2(Task.FromResult(u.Value2)),
			3 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT3(Task.FromResult(u.Value3)),
			4 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT4(Task.FromResult(u.Value4)),
			5 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT5(Task.FromResult(u.Value5)),
			6 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT6(Task.FromResult(u.Value6)),
			7 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT7(mapping(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0New, T1, T2, T3, T4, T5, T6, T7>> Map0<T0New, T0Old, T1, T2, T3, T4, T5, T6, T7>(this Union<T0Old, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0Old, Task<T0New>> mapping,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT0(mapping(u.Value0)),
			1 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
			3 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
			4 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
			5 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
			6 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
			7 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1New, T2, T3, T4, T5, T6, T7>> Map1<T1New, T0, T1Old, T2, T3, T4, T5, T6, T7>(this Union<T0, T1Old, T2, T3, T4, T5, T6, T7> union,
		Func<T1Old, Task<T1New>> mapping,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT1(mapping(u.Value1)),
			2 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
			3 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
			4 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
			5 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
			6 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
			7 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2New, T3, T4, T5, T6, T7>> Map2<T2New, T0, T1, T2Old, T3, T4, T5, T6, T7>(this Union<T0, T1, T2Old, T3, T4, T5, T6, T7> union,
		Func<T2Old, Task<T2New>> mapping,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT2(mapping(u.Value2)),
			3 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
			4 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
			5 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
			6 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
			7 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3New, T4, T5, T6, T7>> Map3<T3New, T0, T1, T2, T3Old, T4, T5, T6, T7>(this Union<T0, T1, T2, T3Old, T4, T5, T6, T7> union,
		Func<T3Old, Task<T3New>> mapping,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
			3 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT3(mapping(u.Value3)),
			4 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT4(Task.FromResult(u.Value4)),
			5 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
			6 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
			7 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT7(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4New, T5, T6, T7>> Map4<T4New, T0, T1, T2, T3, T4Old, T5, T6, T7>(this Union<T0, T1, T2, T3, T4Old, T5, T6, T7> union,
		Func<T4Old, Task<T4New>> mapping,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT2(Task.FromResult(u.Value2)),
			3 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT3(Task.FromResult(u.Value3)),
			4 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT4(mapping(u.Value4)),
			5 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT5(Task.FromResult(u.Value5)),
			6 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT6(Task.FromResult(u.Value6)),
			7 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT7(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5New, T6, T7>> Map5<T5New, T0, T1, T2, T3, T4, T5Old, T6, T7>(this Union<T0, T1, T2, T3, T4, T5Old, T6, T7> union,
		Func<T5Old, Task<T5New>> mapping,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT2(Task.FromResult(u.Value2)),
			3 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT3(Task.FromResult(u.Value3)),
			4 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT4(Task.FromResult(u.Value4)),
			5 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT5(mapping(u.Value5)),
			6 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT6(Task.FromResult(u.Value6)),
			7 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT7(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6New, T7>> Map6<T6New, T0, T1, T2, T3, T4, T5, T6Old, T7>(this Union<T0, T1, T2, T3, T4, T5, T6Old, T7> union,
		Func<T6Old, Task<T6New>> mapping,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT2(Task.FromResult(u.Value2)),
			3 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT3(Task.FromResult(u.Value3)),
			4 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT4(Task.FromResult(u.Value4)),
			5 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT5(Task.FromResult(u.Value5)),
			6 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT6(mapping(u.Value6)),
			7 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT7(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6, T7New>> Map7<T7New, T0, T1, T2, T3, T4, T5, T6, T7Old>(this Union<T0, T1, T2, T3, T4, T5, T6, T7Old> union,
		Func<T7Old, Task<T7New>> mapping,
		CancellationToken cancellationToken = default){
		var u = union;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT0(Task.FromResult(u.Value0)),
			1 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT1(Task.FromResult(u.Value1)),
			2 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT2(Task.FromResult(u.Value2)),
			3 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT3(Task.FromResult(u.Value3)),
			4 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT4(Task.FromResult(u.Value4)),
			5 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT5(Task.FromResult(u.Value5)),
			6 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT6(Task.FromResult(u.Value6)),
			7 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT7(mapping(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Union<T0New, T1, T2, T3, T4, T5, T6, T7>> Map0<T0New, T0Old, T1, T2, T3, T4, T5, T6, T7>(this Task<Union<T0Old, T1, T2, T3, T4, T5, T6, T7>> union,
		Func<T0Old, T0New> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT0(mapping(u.Value0)),
			1 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT1(u.Value1),
			2 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT2(u.Value2),
			3 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT3(u.Value3),
			4 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT4(u.Value4),
			5 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT5(u.Value5),
			6 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT6(u.Value6),
			7 => Union<T0New, T1, T2, T3, T4, T5, T6, T7>.FromT7(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Union<T0, T1New, T2, T3, T4, T5, T6, T7>> Map1<T1New, T0, T1Old, T2, T3, T4, T5, T6, T7>(this Task<Union<T0, T1Old, T2, T3, T4, T5, T6, T7>> union,
		Func<T1Old, T1New> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT0(u.Value0),
			1 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT1(mapping(u.Value1)),
			2 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT2(u.Value2),
			3 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT3(u.Value3),
			4 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT4(u.Value4),
			5 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT5(u.Value5),
			6 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT6(u.Value6),
			7 => Union<T0, T1New, T2, T3, T4, T5, T6, T7>.FromT7(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Union<T0, T1, T2New, T3, T4, T5, T6, T7>> Map2<T2New, T0, T1, T2Old, T3, T4, T5, T6, T7>(this Task<Union<T0, T1, T2Old, T3, T4, T5, T6, T7>> union,
		Func<T2Old, T2New> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT0(u.Value0),
			1 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT1(u.Value1),
			2 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT2(mapping(u.Value2)),
			3 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT3(u.Value3),
			4 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT4(u.Value4),
			5 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT5(u.Value5),
			6 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT6(u.Value6),
			7 => Union<T0, T1, T2New, T3, T4, T5, T6, T7>.FromT7(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Union<T0, T1, T2, T3New, T4, T5, T6, T7>> Map3<T3New, T0, T1, T2, T3Old, T4, T5, T6, T7>(this Task<Union<T0, T1, T2, T3Old, T4, T5, T6, T7>> union,
		Func<T3Old, T3New> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT0(u.Value0),
			1 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT1(u.Value1),
			2 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT2(u.Value2),
			3 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT3(mapping(u.Value3)),
			4 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT4(u.Value4),
			5 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT5(u.Value5),
			6 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT6(u.Value6),
			7 => Union<T0, T1, T2, T3New, T4, T5, T6, T7>.FromT7(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4New, T5, T6, T7>> Map4<T4New, T0, T1, T2, T3, T4Old, T5, T6, T7>(this Task<Union<T0, T1, T2, T3, T4Old, T5, T6, T7>> union,
		Func<T4Old, T4New> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT0(u.Value0),
			1 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT1(u.Value1),
			2 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT2(u.Value2),
			3 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT3(u.Value3),
			4 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT4(mapping(u.Value4)),
			5 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT5(u.Value5),
			6 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT6(u.Value6),
			7 => Union<T0, T1, T2, T3, T4New, T5, T6, T7>.FromT7(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5New, T6, T7>> Map5<T5New, T0, T1, T2, T3, T4, T5Old, T6, T7>(this Task<Union<T0, T1, T2, T3, T4, T5Old, T6, T7>> union,
		Func<T5Old, T5New> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT0(u.Value0),
			1 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT1(u.Value1),
			2 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT2(u.Value2),
			3 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT3(u.Value3),
			4 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT4(u.Value4),
			5 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT5(mapping(u.Value5)),
			6 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT6(u.Value6),
			7 => Union<T0, T1, T2, T3, T4, T5New, T6, T7>.FromT7(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6New, T7>> Map6<T6New, T0, T1, T2, T3, T4, T5, T6Old, T7>(this Task<Union<T0, T1, T2, T3, T4, T5, T6Old, T7>> union,
		Func<T6Old, T6New> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT0(u.Value0),
			1 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT1(u.Value1),
			2 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT2(u.Value2),
			3 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT3(u.Value3),
			4 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT4(u.Value4),
			5 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT5(u.Value5),
			6 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT6(mapping(u.Value6)),
			7 => Union<T0, T1, T2, T3, T4, T5, T6New, T7>.FromT7(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6, T7New>> Map7<T7New, T0, T1, T2, T3, T4, T5, T6, T7Old>(this Task<Union<T0, T1, T2, T3, T4, T5, T6, T7Old>> union,
		Func<T7Old, T7New> mapping,
		CancellationToken cancellationToken = default){
		var u = await (union).ConfigureAwait(false);
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT0(u.Value0),
			1 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT1(u.Value1),
			2 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT2(u.Value2),
			3 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT3(u.Value3),
			4 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT4(u.Value4),
			5 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT5(u.Value5),
			6 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT6(u.Value6),
			7 => Union<T0, T1, T2, T3, T4, T5, T6, T7New>.FromT7(mapping(u.Value7)),
			_ => throw new Unreachable(),
			};
			
		}}
		