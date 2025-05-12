

using System;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;


public readonly record struct Union<T0, T1>
{
	internal T0 Value0 { get; init; }
	internal T1 Value1 { get; init; }

	internal int Index { get; init; }

	public bool Is0 => Index == 0;
	public bool Is1 => Index == 1;

	public Union() => throw new InvalidOperationException();

	private Union(int index, T0? value0 = default, T1? value1 = default)
	{
		Index = index;
		Value0 = value0!;
		Value1 = value1!;
	}

	public static implicit operator Union<T0, T1>(T0 value) =>
		new Union<T0, T1>(0, value0: value);
	public static implicit operator Union<T0, T1>(T1 value) =>
		new Union<T0, T1>(1, value1: value);

	public static implicit operator Union<T0, T1>(Union<T0> other) =>
		new Union<T0, T1>(other.Index, other.Value0);

	public static Union<T0, T1> FromT0(T0 value) => value;
	public static Union<T0, T1> FromT1(T1 value) => value;

	public static async Task<Union<T0, T1>> FromT0(Task<T0> value) => await value;
	public static async Task<Union<T0, T1>> FromT1(Task<T1> value) => await value;
}

