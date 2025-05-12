
using System;
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
}
