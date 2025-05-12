
using System;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;

public static class Union5Match
{
	
	public static TResult Match<TResult, T0, T1, T2, T3, T4>(
		this Union<T0, T1, T2, T3, T4> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<T3, TResult> t3,
		Func<T4, TResult> t4)
	{
		var u = union;

		return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			3 => t3(u.Value3),
			_ => t4(u.Value4)
		};
	}

	
	public static TResult Match<TResult, T0, T1, T2, T3, T4>(
		this Union<T0, T1, T2, T3, T4> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<Union<T3, T4>, TResult> other)
	{
		var u = union;

		return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			_ => other(new Union<T3, T4>(u.Value))
		};
	}

	
	public static TResult Match<TResult, T0, T1, T2, T3, T4>(
		this Union<T0, T1, T2, T3, T4> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<Union<T2, T3, T4>, TResult> other)
	{
		var u = union;

		return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			_ => other(new Union<T2, T3, T4>(u.Value))
		};
	}

	
	public static TResult Match<TResult, T0, T1, T2, T3, T4>(
		this Union<T0, T1, T2, T3, T4> union,
		Func<T0, TResult> t0,
		Func<Union<T1, T2, T3, T4>, TResult> other)
	{
		var u = union;

		return u.Index switch
		{
			0 => t0(u.Value0),
			_ => other(new Union<T1, T2, T3, T4>(u.Value))
		};
	}
}
