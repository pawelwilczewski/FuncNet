
using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;

public static class Union3Map
{
	
	public static Union<T0New, T1, T2> Map0<T0New, T0Old, T1, T2>(
		this Union<T0Old, T1, T2> union,
		Func<T0Old, T0New> mapping)
	{
		var u = union;
		

		return u.Match(
			t0 => Union<T0New, T1, T2>.FromT0(mapping(t0)),
			t1 => Union<T0New, T1, T2>.FromT1(t1),
			t2 => Union<T0New, T1, T2>.FromT2(t2));
	}

	
	public static Union<T0, T1New, T2> Map1<T1New, T0, T1Old, T2>(
		this Union<T0, T1Old, T2> union,
		Func<T1Old, T1New> mapping)
	{
		var u = union;
		

		return u.Match(
			t0 => Union<T0, T1New, T2>.FromT0(t0),
			t1 => Union<T0, T1New, T2>.FromT1(mapping(t1)),
			t2 => Union<T0, T1New, T2>.FromT2(t2));
	}

	
	public static Union<T0, T1, T2New> Map2<T2New, T0, T1, T2Old>(
		this Union<T0, T1, T2Old> union,
		Func<T2Old, T2New> mapping)
	{
		var u = union;
		

		return u.Match(
			t0 => Union<T0, T1, T2New>.FromT0(t0),
			t1 => Union<T0, T1, T2New>.FromT1(t1),
			t2 => Union<T0, T1, T2New>.FromT2(mapping(t2)));
	}

	
	public static async Task<Union<T0New, T1, T2>> Map0<T0New, T0Old, T1, T2>(
		this Task<Union<T0Old, T1, T2>> union,
		Func<T0Old, Task<T0New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Union<T0New, T1, T2>.FromT0(mapping(t0)),
			t1 => Task.FromResult(Union<T0New, T1, T2>.FromT1(t1)),
			t2 => Task.FromResult(Union<T0New, T1, T2>.FromT2(t2)))).ConfigureAwait(continueOnCapturedContext);
	}

	
	public static async Task<Union<T0, T1New, T2>> Map1<T1New, T0, T1Old, T2>(
		this Task<Union<T0, T1Old, T2>> union,
		Func<T1Old, Task<T1New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Task.FromResult(Union<T0, T1New, T2>.FromT0(t0)),
			t1 => Union<T0, T1New, T2>.FromT1(mapping(t1)),
			t2 => Task.FromResult(Union<T0, T1New, T2>.FromT2(t2)))).ConfigureAwait(continueOnCapturedContext);
	}

	
	public static async Task<Union<T0, T1, T2New>> Map2<T2New, T0, T1, T2Old>(
		this Task<Union<T0, T1, T2Old>> union,
		Func<T2Old, Task<T2New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Task.FromResult(Union<T0, T1, T2New>.FromT0(t0)),
			t1 => Task.FromResult(Union<T0, T1, T2New>.FromT1(t1)),
			t2 => Union<T0, T1, T2New>.FromT2(mapping(t2)))).ConfigureAwait(continueOnCapturedContext);
	}

	
	public static async Task<Union<T0New, T1, T2>> Map0<T0New, T0Old, T1, T2>(
		this Union<T0Old, T1, T2> union,
		Func<T0Old, Task<T0New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		var u = union;
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Union<T0New, T1, T2>.FromT0(mapping(t0)),
			t1 => Task.FromResult(Union<T0New, T1, T2>.FromT1(t1)),
			t2 => Task.FromResult(Union<T0New, T1, T2>.FromT2(t2)))).ConfigureAwait(continueOnCapturedContext);
	}

	
	public static async Task<Union<T0, T1New, T2>> Map1<T1New, T0, T1Old, T2>(
		this Union<T0, T1Old, T2> union,
		Func<T1Old, Task<T1New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		var u = union;
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Task.FromResult(Union<T0, T1New, T2>.FromT0(t0)),
			t1 => Union<T0, T1New, T2>.FromT1(mapping(t1)),
			t2 => Task.FromResult(Union<T0, T1New, T2>.FromT2(t2)))).ConfigureAwait(continueOnCapturedContext);
	}

	
	public static async Task<Union<T0, T1, T2New>> Map2<T2New, T0, T1, T2Old>(
		this Union<T0, T1, T2Old> union,
		Func<T2Old, Task<T2New>> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		var u = union;
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Match(
			t0 => Task.FromResult(Union<T0, T1, T2New>.FromT0(t0)),
			t1 => Task.FromResult(Union<T0, T1, T2New>.FromT1(t1)),
			t2 => Union<T0, T1, T2New>.FromT2(mapping(t2)))).ConfigureAwait(continueOnCapturedContext);
	}

	
	public static async Task<Union<T0New, T1, T2>> Map0<T0New, T0Old, T1, T2>(
		this Task<Union<T0Old, T1, T2>> union,
		Func<T0Old, T0New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return u.Match(
			t0 => Union<T0New, T1, T2>.FromT0(mapping(t0)),
			t1 => Union<T0New, T1, T2>.FromT1(t1),
			t2 => Union<T0New, T1, T2>.FromT2(t2));
	}

	
	public static async Task<Union<T0, T1New, T2>> Map1<T1New, T0, T1Old, T2>(
		this Task<Union<T0, T1Old, T2>> union,
		Func<T1Old, T1New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return u.Match(
			t0 => Union<T0, T1New, T2>.FromT0(t0),
			t1 => Union<T0, T1New, T2>.FromT1(mapping(t1)),
			t2 => Union<T0, T1New, T2>.FromT2(t2));
	}

	
	public static async Task<Union<T0, T1, T2New>> Map2<T2New, T0, T1, T2Old>(
		this Task<Union<T0, T1, T2Old>> union,
		Func<T2Old, T2New> mapping,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return u.Match(
			t0 => Union<T0, T1, T2New>.FromT0(t0),
			t1 => Union<T0, T1, T2New>.FromT1(t1),
			t2 => Union<T0, T1, T2New>.FromT2(mapping(t2)));
	}
}
