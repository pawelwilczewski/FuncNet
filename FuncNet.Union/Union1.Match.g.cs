

using System;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;


public static class Union1Match
{
	public static TResult Match<TResult, T0>(
		this Union<T0> union,
		Func<T0, TResult> t0) => union.Index switch
	{
		0 => t0(union.Value0),
		_ => throw new Unreachable()
	};
	
	
}

