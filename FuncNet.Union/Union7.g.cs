

using System;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;


public readonly record struct Union<T0, T1, T2, T3, T4, T5, T6>
{
	internal T0 Value0 { get; init; }
	internal T1 Value1 { get; init; }
	internal T2 Value2 { get; init; }
	internal T3 Value3 { get; init; }
	internal T4 Value4 { get; init; }
	internal T5 Value5 { get; init; }
	internal T6 Value6 { get; init; }

	internal int Index { get; init; }

	public bool Is0 => Index == 0;
	public bool Is1 => Index == 1;
	public bool Is2 => Index == 2;
	public bool Is3 => Index == 3;
	public bool Is4 => Index == 4;
	public bool Is5 => Index == 5;
	public bool Is6 => Index == 6;

	public Union() => throw new InvalidOperationException();

	private Union(int index, T0? value0 = default, T1? value1 = default, T2? value2 = default, T3? value3 = default, T4? value4 = default, T5? value5 = default, T6? value6 = default)
	{
		Index = index;
		Value0 = value0!;
		Value1 = value1!;
		Value2 = value2!;
		Value3 = value3!;
		Value4 = value4!;
		Value5 = value5!;
		Value6 = value6!;
	}

	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6>(T0 value) =>
		new Union<T0, T1, T2, T3, T4, T5, T6>(0, value0: value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6>(T1 value) =>
		new Union<T0, T1, T2, T3, T4, T5, T6>(1, value1: value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6>(T2 value) =>
		new Union<T0, T1, T2, T3, T4, T5, T6>(2, value2: value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6>(T3 value) =>
		new Union<T0, T1, T2, T3, T4, T5, T6>(3, value3: value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6>(T4 value) =>
		new Union<T0, T1, T2, T3, T4, T5, T6>(4, value4: value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6>(T5 value) =>
		new Union<T0, T1, T2, T3, T4, T5, T6>(5, value5: value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6>(T6 value) =>
		new Union<T0, T1, T2, T3, T4, T5, T6>(6, value6: value);

	public static Union<T0, T1, T2, T3, T4, T5, T6> FromT0(T0 value) => value;
	public static Union<T0, T1, T2, T3, T4, T5, T6> FromT1(T1 value) => value;
	public static Union<T0, T1, T2, T3, T4, T5, T6> FromT2(T2 value) => value;
	public static Union<T0, T1, T2, T3, T4, T5, T6> FromT3(T3 value) => value;
	public static Union<T0, T1, T2, T3, T4, T5, T6> FromT4(T4 value) => value;
	public static Union<T0, T1, T2, T3, T4, T5, T6> FromT5(T5 value) => value;
	public static Union<T0, T1, T2, T3, T4, T5, T6> FromT6(T6 value) => value;
	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6>> FromT0(Task<T0> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6>> FromT1(Task<T1> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6>> FromT2(Task<T2> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6>> FromT3(Task<T3> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6>> FromT4(Task<T4> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6>> FromT5(Task<T5> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6>> FromT6(Task<T6> value) => await value;
}

