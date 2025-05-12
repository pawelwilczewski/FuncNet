

using System;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;


public static class Union2Match
{
	public static TResult Match<TResult, T0, T1>(
		this Union<T0, T1> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1) => union.Index switch
	{
		0 => t0(union.Value0),
		1 => t1(union.Value1),
		_ => throw new Unreachable()
	};
	
	
}

