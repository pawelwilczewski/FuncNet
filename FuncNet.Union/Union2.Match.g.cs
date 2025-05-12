
using System;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;

public static class Union2Match
{
	
	public static TResult Match<TResult, T0, T1>(
		this Union<T0, T1> union,
		Func<T0, TResult> t0,
		Func<T1, TResult> t1)
	{
		var u = union;

		return u.Index switch
		{
			0 => t0(u.Value0),
			_ => t1(u.Value1)
		};
	}
}
