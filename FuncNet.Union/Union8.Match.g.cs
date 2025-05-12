
using System;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;

public static class Union8Match
{
	
	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5, T6, T7>(
		this Union<T0, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<T3, TResult> t3,
		Func<T4, TResult> t4,
		Func<T5, TResult> t5,
		Func<T6, TResult> t6,
		Func<T7, TResult> t7)
	{
		var u = union;

		return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			3 => t3(u.Value3),
			4 => t4(u.Value4),
			5 => t5(u.Value5),
			6 => t6(u.Value6),
			_ => t7(u.Value7)
		};
	}

	
	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5, T6, T7>(
		this Union<T0, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<T3, TResult> t3,
		Func<T4, TResult> t4,
		Func<T5, TResult> t5,
		Func<Union<T6, T7>, TResult> other)
	{
		var u = union;

		return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			3 => t3(u.Value3),
			4 => t4(u.Value4),
			5 => t5(u.Value5),
			_ => other(new Union<T6, T7>(u.Value))
		};
	}

	
	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5, T6, T7>(
		this Union<T0, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<T3, TResult> t3,
		Func<T4, TResult> t4,
		Func<Union<T5, T6, T7>, TResult> other)
	{
		var u = union;

		return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			3 => t3(u.Value3),
			4 => t4(u.Value4),
			_ => other(new Union<T5, T6, T7>(u.Value))
		};
	}

	
	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5, T6, T7>(
		this Union<T0, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<T3, TResult> t3,
		Func<Union<T4, T5, T6, T7>, TResult> other)
	{
		var u = union;

		return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			3 => t3(u.Value3),
			_ => other(new Union<T4, T5, T6, T7>(u.Value))
		};
	}

	
	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5, T6, T7>(
		this Union<T0, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<Union<T3, T4, T5, T6, T7>, TResult> other)
	{
		var u = union;

		return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			2 => t2(u.Value2),
			_ => other(new Union<T3, T4, T5, T6, T7>(u.Value))
		};
	}

	
	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5, T6, T7>(
		this Union<T0, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<Union<T2, T3, T4, T5, T6, T7>, TResult> other)
	{
		var u = union;

		return u.Index switch
		{
			0 => t0(u.Value0),
			1 => t1(u.Value1),
			_ => other(new Union<T2, T3, T4, T5, T6, T7>(u.Value))
		};
	}

	
	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5, T6, T7>(
		this Union<T0, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0, TResult> t0,
		Func<Union<T1, T2, T3, T4, T5, T6, T7>, TResult> other)
	{
		var u = union;

		return u.Index switch
		{
			0 => t0(u.Value0),
			_ => other(new Union<T1, T2, T3, T4, T5, T6, T7>(u.Value))
		};
	}
}
