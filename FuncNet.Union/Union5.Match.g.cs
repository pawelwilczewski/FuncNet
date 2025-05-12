

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
		Func<T4, TResult> t4) => union.Index switch
	{
		0 => t0(union.Value0),
		1 => t1(union.Value1),
		2 => t2(union.Value2),
		3 => t3(union.Value3),
		4 => t4(union.Value4),
		_ => throw new Unreachable()
	};
}

