
using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;

public static class Union5Map
{
	
		
	public static Union<T0New, T1, T2, T3, T4> Map0<T0New, T0Old, T1, T2, T3, T4>(
		this Union<T0Old, T1, T2, T3, T4> union,
		Func<T0Old, T0New> mapping)
	{
		
		var u = union;
		

		return u.Match(
			t0 => Union<T0New, T1, T2, T3, T4>.FromT0(mapping(t0)),
			t1 => Union<T0New, T1, T2, T3, T4>.FromT1(t1),
			t2 => Union<T0New, T1, T2, T3, T4>.FromT2(t2),
			t3 => Union<T0New, T1, T2, T3, T4>.FromT3(t3),
			t4 => Union<T0New, T1, T2, T3, T4>.FromT4(t4));

	}

	
		
	public static Union<T0, T1New, T2, T3, T4> Map1<T1New, T0, T1Old, T2, T3, T4>(
		this Union<T0, T1Old, T2, T3, T4> union,
		Func<T1Old, T1New> mapping)
	{
		
		var u = union;
		

		return u.Match(
			t0 => Union<T0, T1New, T2, T3, T4>.FromT0(t0),
			t1 => Union<T0, T1New, T2, T3, T4>.FromT1(mapping(t1)),
			t2 => Union<T0, T1New, T2, T3, T4>.FromT2(t2),
			t3 => Union<T0, T1New, T2, T3, T4>.FromT3(t3),
			t4 => Union<T0, T1New, T2, T3, T4>.FromT4(t4));

	}

	
		
	public static Union<T0, T1, T2New, T3, T4> Map2<T2New, T0, T1, T2Old, T3, T4>(
		this Union<T0, T1, T2Old, T3, T4> union,
		Func<T2Old, T2New> mapping)
	{
		
		var u = union;
		

		return u.Match(
			t0 => Union<T0, T1, T2New, T3, T4>.FromT0(t0),
			t1 => Union<T0, T1, T2New, T3, T4>.FromT1(t1),
			t2 => Union<T0, T1, T2New, T3, T4>.FromT2(mapping(t2)),
			t3 => Union<T0, T1, T2New, T3, T4>.FromT3(t3),
			t4 => Union<T0, T1, T2New, T3, T4>.FromT4(t4));

	}

	
		
	public static Union<T0, T1, T2, T3New, T4> Map3<T3New, T0, T1, T2, T3Old, T4>(
		this Union<T0, T1, T2, T3Old, T4> union,
		Func<T3Old, T3New> mapping)
	{
		
		var u = union;
		

		return u.Match(
			t0 => Union<T0, T1, T2, T3New, T4>.FromT0(t0),
			t1 => Union<T0, T1, T2, T3New, T4>.FromT1(t1),
			t2 => Union<T0, T1, T2, T3New, T4>.FromT2(t2),
			t3 => Union<T0, T1, T2, T3New, T4>.FromT3(mapping(t3)),
			t4 => Union<T0, T1, T2, T3New, T4>.FromT4(t4));

	}

	
		
	public static Union<T0, T1, T2, T3, T4New> Map4<T4New, T0, T1, T2, T3, T4Old>(
		this Union<T0, T1, T2, T3, T4Old> union,
		Func<T4Old, T4New> mapping)
	{
		
		var u = union;
		

		return u.Match(
			t0 => Union<T0, T1, T2, T3, T4New>.FromT0(t0),
			t1 => Union<T0, T1, T2, T3, T4New>.FromT1(t1),
			t2 => Union<T0, T1, T2, T3, T4New>.FromT2(t2),
			t3 => Union<T0, T1, T2, T3, T4New>.FromT3(t3),
			t4 => Union<T0, T1, T2, T3, T4New>.FromT4(mapping(t4)));

	}

	
		
	public static async Task<Union<T0New, T1, T2, T3, T4>> Map0<T0New, T0Old, T1, T2, T3, T4>(
		this Task<Union<T0Old, T1, T2, T3, T4>> union,
		Func<T0Old, Task<T0New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Union<T0New, T1, T2, T3, T4>.FromT0(mapping(t0)),
			t1 => Task.FromResult(Union<T0New, T1, T2, T3, T4>.FromT1(t1)),
			t2 => Task.FromResult(Union<T0New, T1, T2, T3, T4>.FromT2(t2)),
			t3 => Task.FromResult(Union<T0New, T1, T2, T3, T4>.FromT3(t3)),
			t4 => Task.FromResult(Union<T0New, T1, T2, T3, T4>.FromT4(t4)))).ConfigureAwait(continueOnCapturedContext);

	}

	
		
	public static async Task<Union<T0, T1New, T2, T3, T4>> Map1<T1New, T0, T1Old, T2, T3, T4>(
		this Task<Union<T0, T1Old, T2, T3, T4>> union,
		Func<T1Old, Task<T1New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Task.FromResult(Union<T0, T1New, T2, T3, T4>.FromT0(t0)),
			t1 => Union<T0, T1New, T2, T3, T4>.FromT1(mapping(t1)),
			t2 => Task.FromResult(Union<T0, T1New, T2, T3, T4>.FromT2(t2)),
			t3 => Task.FromResult(Union<T0, T1New, T2, T3, T4>.FromT3(t3)),
			t4 => Task.FromResult(Union<T0, T1New, T2, T3, T4>.FromT4(t4)))).ConfigureAwait(continueOnCapturedContext);

	}

	
		
	public static async Task<Union<T0, T1, T2New, T3, T4>> Map2<T2New, T0, T1, T2Old, T3, T4>(
		this Task<Union<T0, T1, T2Old, T3, T4>> union,
		Func<T2Old, Task<T2New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Task.FromResult(Union<T0, T1, T2New, T3, T4>.FromT0(t0)),
			t1 => Task.FromResult(Union<T0, T1, T2New, T3, T4>.FromT1(t1)),
			t2 => Union<T0, T1, T2New, T3, T4>.FromT2(mapping(t2)),
			t3 => Task.FromResult(Union<T0, T1, T2New, T3, T4>.FromT3(t3)),
			t4 => Task.FromResult(Union<T0, T1, T2New, T3, T4>.FromT4(t4)))).ConfigureAwait(continueOnCapturedContext);

	}

	
		
	public static async Task<Union<T0, T1, T2, T3New, T4>> Map3<T3New, T0, T1, T2, T3Old, T4>(
		this Task<Union<T0, T1, T2, T3Old, T4>> union,
		Func<T3Old, Task<T3New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Task.FromResult(Union<T0, T1, T2, T3New, T4>.FromT0(t0)),
			t1 => Task.FromResult(Union<T0, T1, T2, T3New, T4>.FromT1(t1)),
			t2 => Task.FromResult(Union<T0, T1, T2, T3New, T4>.FromT2(t2)),
			t3 => Union<T0, T1, T2, T3New, T4>.FromT3(mapping(t3)),
			t4 => Task.FromResult(Union<T0, T1, T2, T3New, T4>.FromT4(t4)))).ConfigureAwait(continueOnCapturedContext);

	}

	
		
	public static async Task<Union<T0, T1, T2, T3, T4New>> Map4<T4New, T0, T1, T2, T3, T4Old>(
		this Task<Union<T0, T1, T2, T3, T4Old>> union,
		Func<T4Old, Task<T4New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Task.FromResult(Union<T0, T1, T2, T3, T4New>.FromT0(t0)),
			t1 => Task.FromResult(Union<T0, T1, T2, T3, T4New>.FromT1(t1)),
			t2 => Task.FromResult(Union<T0, T1, T2, T3, T4New>.FromT2(t2)),
			t3 => Task.FromResult(Union<T0, T1, T2, T3, T4New>.FromT3(t3)),
			t4 => Union<T0, T1, T2, T3, T4New>.FromT4(mapping(t4)))).ConfigureAwait(continueOnCapturedContext);

	}

	
		
	public static async Task<Union<T0New, T1, T2, T3, T4>> Map0<T0New, T0Old, T1, T2, T3, T4>(
		this Union<T0Old, T1, T2, T3, T4> union,
		Func<T0Old, Task<T0New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		
		var u = union;
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Union<T0New, T1, T2, T3, T4>.FromT0(mapping(t0)),
			t1 => Task.FromResult(Union<T0New, T1, T2, T3, T4>.FromT1(t1)),
			t2 => Task.FromResult(Union<T0New, T1, T2, T3, T4>.FromT2(t2)),
			t3 => Task.FromResult(Union<T0New, T1, T2, T3, T4>.FromT3(t3)),
			t4 => Task.FromResult(Union<T0New, T1, T2, T3, T4>.FromT4(t4)))).ConfigureAwait(continueOnCapturedContext);

	}

	
		
	public static async Task<Union<T0, T1New, T2, T3, T4>> Map1<T1New, T0, T1Old, T2, T3, T4>(
		this Union<T0, T1Old, T2, T3, T4> union,
		Func<T1Old, Task<T1New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		
		var u = union;
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Task.FromResult(Union<T0, T1New, T2, T3, T4>.FromT0(t0)),
			t1 => Union<T0, T1New, T2, T3, T4>.FromT1(mapping(t1)),
			t2 => Task.FromResult(Union<T0, T1New, T2, T3, T4>.FromT2(t2)),
			t3 => Task.FromResult(Union<T0, T1New, T2, T3, T4>.FromT3(t3)),
			t4 => Task.FromResult(Union<T0, T1New, T2, T3, T4>.FromT4(t4)))).ConfigureAwait(continueOnCapturedContext);

	}

	
		
	public static async Task<Union<T0, T1, T2New, T3, T4>> Map2<T2New, T0, T1, T2Old, T3, T4>(
		this Union<T0, T1, T2Old, T3, T4> union,
		Func<T2Old, Task<T2New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		
		var u = union;
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Task.FromResult(Union<T0, T1, T2New, T3, T4>.FromT0(t0)),
			t1 => Task.FromResult(Union<T0, T1, T2New, T3, T4>.FromT1(t1)),
			t2 => Union<T0, T1, T2New, T3, T4>.FromT2(mapping(t2)),
			t3 => Task.FromResult(Union<T0, T1, T2New, T3, T4>.FromT3(t3)),
			t4 => Task.FromResult(Union<T0, T1, T2New, T3, T4>.FromT4(t4)))).ConfigureAwait(continueOnCapturedContext);

	}

	
		
	public static async Task<Union<T0, T1, T2, T3New, T4>> Map3<T3New, T0, T1, T2, T3Old, T4>(
		this Union<T0, T1, T2, T3Old, T4> union,
		Func<T3Old, Task<T3New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		
		var u = union;
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Task.FromResult(Union<T0, T1, T2, T3New, T4>.FromT0(t0)),
			t1 => Task.FromResult(Union<T0, T1, T2, T3New, T4>.FromT1(t1)),
			t2 => Task.FromResult(Union<T0, T1, T2, T3New, T4>.FromT2(t2)),
			t3 => Union<T0, T1, T2, T3New, T4>.FromT3(mapping(t3)),
			t4 => Task.FromResult(Union<T0, T1, T2, T3New, T4>.FromT4(t4)))).ConfigureAwait(continueOnCapturedContext);

	}

	
		
	public static async Task<Union<T0, T1, T2, T3, T4New>> Map4<T4New, T0, T1, T2, T3, T4Old>(
		this Union<T0, T1, T2, T3, T4Old> union,
		Func<T4Old, Task<T4New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		
		var u = union;
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Task.FromResult(Union<T0, T1, T2, T3, T4New>.FromT0(t0)),
			t1 => Task.FromResult(Union<T0, T1, T2, T3, T4New>.FromT1(t1)),
			t2 => Task.FromResult(Union<T0, T1, T2, T3, T4New>.FromT2(t2)),
			t3 => Task.FromResult(Union<T0, T1, T2, T3, T4New>.FromT3(t3)),
			t4 => Union<T0, T1, T2, T3, T4New>.FromT4(mapping(t4)))).ConfigureAwait(continueOnCapturedContext);

	}

	
		
	public static async Task<Union<T0New, T1, T2, T3, T4>> Map0<T0New, T0Old, T1, T2, T3, T4>(
		this Task<Union<T0Old, T1, T2, T3, T4>> union,
		Func<T0Old, T0New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return u.Match(
			t0 => Union<T0New, T1, T2, T3, T4>.FromT0(mapping(t0)),
			t1 => Union<T0New, T1, T2, T3, T4>.FromT1(t1),
			t2 => Union<T0New, T1, T2, T3, T4>.FromT2(t2),
			t3 => Union<T0New, T1, T2, T3, T4>.FromT3(t3),
			t4 => Union<T0New, T1, T2, T3, T4>.FromT4(t4));

	}

	
		
	public static async Task<Union<T0, T1New, T2, T3, T4>> Map1<T1New, T0, T1Old, T2, T3, T4>(
		this Task<Union<T0, T1Old, T2, T3, T4>> union,
		Func<T1Old, T1New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return u.Match(
			t0 => Union<T0, T1New, T2, T3, T4>.FromT0(t0),
			t1 => Union<T0, T1New, T2, T3, T4>.FromT1(mapping(t1)),
			t2 => Union<T0, T1New, T2, T3, T4>.FromT2(t2),
			t3 => Union<T0, T1New, T2, T3, T4>.FromT3(t3),
			t4 => Union<T0, T1New, T2, T3, T4>.FromT4(t4));

	}

	
		
	public static async Task<Union<T0, T1, T2New, T3, T4>> Map2<T2New, T0, T1, T2Old, T3, T4>(
		this Task<Union<T0, T1, T2Old, T3, T4>> union,
		Func<T2Old, T2New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return u.Match(
			t0 => Union<T0, T1, T2New, T3, T4>.FromT0(t0),
			t1 => Union<T0, T1, T2New, T3, T4>.FromT1(t1),
			t2 => Union<T0, T1, T2New, T3, T4>.FromT2(mapping(t2)),
			t3 => Union<T0, T1, T2New, T3, T4>.FromT3(t3),
			t4 => Union<T0, T1, T2New, T3, T4>.FromT4(t4));

	}

	
		
	public static async Task<Union<T0, T1, T2, T3New, T4>> Map3<T3New, T0, T1, T2, T3Old, T4>(
		this Task<Union<T0, T1, T2, T3Old, T4>> union,
		Func<T3Old, T3New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return u.Match(
			t0 => Union<T0, T1, T2, T3New, T4>.FromT0(t0),
			t1 => Union<T0, T1, T2, T3New, T4>.FromT1(t1),
			t2 => Union<T0, T1, T2, T3New, T4>.FromT2(t2),
			t3 => Union<T0, T1, T2, T3New, T4>.FromT3(mapping(t3)),
			t4 => Union<T0, T1, T2, T3New, T4>.FromT4(t4));

	}

	
		
	public static async Task<Union<T0, T1, T2, T3, T4New>> Map4<T4New, T0, T1, T2, T3, T4Old>(
		this Task<Union<T0, T1, T2, T3, T4Old>> union,
		Func<T4Old, T4New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return u.Match(
			t0 => Union<T0, T1, T2, T3, T4New>.FromT0(t0),
			t1 => Union<T0, T1, T2, T3, T4New>.FromT1(t1),
			t2 => Union<T0, T1, T2, T3, T4New>.FromT2(t2),
			t3 => Union<T0, T1, T2, T3, T4New>.FromT3(t3),
			t4 => Union<T0, T1, T2, T3, T4New>.FromT4(mapping(t4)));

	}
}
