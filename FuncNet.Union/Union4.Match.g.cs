
using System;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;

public static class Union4Match
{
	
	public static TResult Match<TResult, T0, T1, T2, T3>(
		this Union<T0, T1, T2, T3> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<T2, TResult> t2,
		Func<T3, TResult> t3) => union.Index switch
	{
		0 => t0(union.Value0),
		1 => t1(union.Value1),
		2 => t2(union.Value2),
		_ => t3(union.Value3)
	};

	
	public static TResult Match<TResult, T0, T1, T2, T3>(
		this Union<T0, T1, T2, T3> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1,
		Func<Union<T2, T3>, TResult> other) => union.Index switch
	{
		0 => t0(union.Value0),
		1 => t1(union.Value1),
		_ => other(new Union<T2, T3>(union.Value))
	};

	
	public static TResult Match<TResult, T0, T1, T2, T3>(
		this Union<T0, T1, T2, T3> union,
		Func<T0, TResult> t0,
		Func<Union<T1, T2, T3>, TResult> other) => union.Index switch
	{
		0 => t0(union.Value0),
		_ => other(new Union<T1, T2, T3>(union.Value))
	};
}
