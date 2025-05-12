
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
		Func<T7, TResult> t7) => union.Index switch
	{
		0 => t0(union.Value0),
		1 => t1(union.Value1),
		2 => t2(union.Value2),
		3 => t3(union.Value3),
		4 => t4(union.Value4),
		5 => t5(union.Value5),
		6 => t6(union.Value6),
		_ => t7(union.Value7)
	};

	
	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5, T6, T7>(
		this Union<T0, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<T3, TResult> t3,
		Func<T4, TResult> t4,
		Func<T5, TResult> t5,
		Func<Union<T6, T7>, TResult> other) => union.Index switch
	{
		0 => t0(union.Value0),
		1 => t1(union.Value1),
		2 => t2(union.Value2),
		3 => t3(union.Value3),
		4 => t4(union.Value4),
		5 => t5(union.Value5),
		_ => other(new Union<T6, T7>(union.Value))
	};

	
	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5, T6, T7>(
		this Union<T0, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<T3, TResult> t3,
		Func<T4, TResult> t4,
		Func<Union<T5, T6, T7>, TResult> other) => union.Index switch
	{
		0 => t0(union.Value0),
		1 => t1(union.Value1),
		2 => t2(union.Value2),
		3 => t3(union.Value3),
		4 => t4(union.Value4),
		_ => other(new Union<T5, T6, T7>(union.Value))
	};

	
	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5, T6, T7>(
		this Union<T0, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<T3, TResult> t3,
		Func<Union<T4, T5, T6, T7>, TResult> other) => union.Index switch
	{
		0 => t0(union.Value0),
		1 => t1(union.Value1),
		2 => t2(union.Value2),
		3 => t3(union.Value3),
		_ => other(new Union<T4, T5, T6, T7>(union.Value))
	};

	
	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5, T6, T7>(
		this Union<T0, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<Union<T3, T4, T5, T6, T7>, TResult> other) => union.Index switch
	{
		0 => t0(union.Value0),
		1 => t1(union.Value1),
		2 => t2(union.Value2),
		_ => other(new Union<T3, T4, T5, T6, T7>(union.Value))
	};

	
	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5, T6, T7>(
		this Union<T0, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<Union<T2, T3, T4, T5, T6, T7>, TResult> other) => union.Index switch
	{
		0 => t0(union.Value0),
		1 => t1(union.Value1),
		_ => other(new Union<T2, T3, T4, T5, T6, T7>(union.Value))
	};

	
	public static TResult Match<TResult, T0, T1, T2, T3, T4, T5, T6, T7>(
		this Union<T0, T1, T2, T3, T4, T5, T6, T7> union,
		Func<T0, TResult> t0,
		Func<Union<T1, T2, T3, T4, T5, T6, T7>, TResult> other) => union.Index switch
	{
		0 => t0(union.Value0),
		_ => other(new Union<T1, T2, T3, T4, T5, T6, T7>(union.Value))
	};
}
