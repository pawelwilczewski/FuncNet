
using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;

public static class Union3Match
{
	
	public static TResult Match<TResult, T0, T1, T2>(
		this Union<T0, T1, T2> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2)
	{
		var u = union;
		

		return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			_ => t2(u.Value2)
		};
	}

	
	public static TResult Match<TResult, T0, T1, T2>(
		this Union<T0, T1, T2> union,
		Func<T0, TResult> t0,
		Func<Union<T1, T2>, TResult> other)
	{
		var u = union;
		

		return u.Index switch
		{
			0 => t0(u.Value0),
			_ => other(new Union<T1, T2>(u.Value))
		};
	}

	
	public static async Task<TResult> Match<TResult, T0, T1, T2>(
		this Task<Union<T0, T1, T2>> union,
		Func<T0, Task<TResult>> t0,
		Func<T1, Task<TResult>> t1,
		Func<T2, Task<TResult>> t2,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			_ => t2(u.Value2)
		}).ConfigureAwait(continueOnCapturedContext);
	}

	
	public static async Task<TResult> Match<TResult, T0, T1, T2>(
		this Task<Union<T0, T1, T2>> union,
		Func<T0, Task<TResult>> t0,
		Func<Union<T1, T2>, Task<TResult>> other,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Index switch
		{
			0 => t0(u.Value0),
			_ => other(new Union<T1, T2>(u.Value))
		}).ConfigureAwait(continueOnCapturedContext);
	}

	
	public static async Task<TResult> Match<TResult, T0, T1, T2>(
		this Union<T0, T1, T2> union,
		Func<T0, Task<TResult>> t0,
		Func<T1, Task<TResult>> t1,
		Func<T2, Task<TResult>> t2,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		var u = union;
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			_ => t2(u.Value2)
		}).ConfigureAwait(continueOnCapturedContext);
	}

	
	public static async Task<TResult> Match<TResult, T0, T1, T2>(
		this Union<T0, T1, T2> union,
		Func<T0, Task<TResult>> t0,
		Func<Union<T1, T2>, Task<TResult>> other,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		var u = union;
		cancellationToken.ThrowIfCancellationRequested();

		return await (u.Index switch
		{
			0 => t0(u.Value0),
			_ => other(new Union<T1, T2>(u.Value))
		}).ConfigureAwait(continueOnCapturedContext);
	}

	
	public static async Task<TResult> Match<TResult, T0, T1, T2>(
		this Task<Union<T0, T1, T2>> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			_ => t2(u.Value2)
		};
	}

	
	public static async Task<TResult> Match<TResult, T0, T1, T2>(
		this Task<Union<T0, T1, T2>> union,
		Func<T0, TResult> t0,
		Func<Union<T1, T2>, TResult> other,
		CancellationToken cancellationToken = default,
		bool continueOnCapturedContext = true)
	{
		var u = await (union).ConfigureAwait(continueOnCapturedContext);
		cancellationToken.ThrowIfCancellationRequested();

		return u.Index switch
		{
			0 => t0(u.Value0),
			_ => other(new Union<T1, T2>(u.Value))
		};
	}
}
