

using System;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;


public readonly record struct Union<T0, T1, T2, T3, T4>
{
	internal T0 Value0 { get; init; }
	internal T1 Value1 { get; init; }
	internal T2 Value2 { get; init; }
	internal T3 Value3 { get; init; }
	internal T4 Value4 { get; init; }

	internal int Index { get; init; }

	public bool Is0 => Index == 0;
	public bool Is1 => Index == 1;
	public bool Is2 => Index == 2;
	public bool Is3 => Index == 3;
	public bool Is4 => Index == 4;

	public Union() => throw new InvalidOperationException();

	private Union(int index, T0? value0 = default, T1? value1 = default, T2? value2 = default, T3? value3 = default, T4? value4 = default)
	{
		Index = index;
		Value0 = value0!;
		Value1 = value1!;
		Value2 = value2!;
		Value3 = value3!;
		Value4 = value4!;
	}

	public static implicit operator Union<T0, T1, T2, T3, T4>(T0 value) =>
		new Union<T0, T1, T2, T3, T4>(0, value0: value);
	public static implicit operator Union<T0, T1, T2, T3, T4>(T1 value) =>
		new Union<T0, T1, T2, T3, T4>(1, value1: value);
	public static implicit operator Union<T0, T1, T2, T3, T4>(T2 value) =>
		new Union<T0, T1, T2, T3, T4>(2, value2: value);
	public static implicit operator Union<T0, T1, T2, T3, T4>(T3 value) =>
		new Union<T0, T1, T2, T3, T4>(3, value3: value);
	public static implicit operator Union<T0, T1, T2, T3, T4>(T4 value) =>
		new Union<T0, T1, T2, T3, T4>(4, value4: value);

	public static implicit operator Union<T0, T1, T2, T3, T4>(Union<T0> other) =>
		new Union<T0, T1, T2, T3, T4>(other.Index, other.Value0);
	public static implicit operator Union<T0, T1, T2, T3, T4>(Union<T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4>(other.Index, other.Value0, other.Value1);
	public static implicit operator Union<T0, T1, T2, T3, T4>(Union<T0, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4>(other.Index, other.Value0, other.Value1, other.Value2);
	public static implicit operator Union<T0, T1, T2, T3, T4>(Union<T0, T1, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4>(other.Index, other.Value0, other.Value1, other.Value2, other.Value3);

	public static Union<T0, T1, T2, T3, T4> FromT0(T0 value) => value;
	public static Union<T0, T1, T2, T3, T4> FromT1(T1 value) => value;
	public static Union<T0, T1, T2, T3, T4> FromT2(T2 value) => value;
	public static Union<T0, T1, T2, T3, T4> FromT3(T3 value) => value;
	public static Union<T0, T1, T2, T3, T4> FromT4(T4 value) => value;

	public static async Task<Union<T0, T1, T2, T3, T4>> FromT0(Task<T0> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4>> FromT1(Task<T1> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4>> FromT2(Task<T2> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4>> FromT3(Task<T3> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4>> FromT4(Task<T4> value) => await value;
}

