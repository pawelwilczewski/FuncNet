using System;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;

public readonly partial record struct Union<T0, T1, T2, T3, T4, T5, T6, T7>
{
	internal T0 Value0 { get; init; }
	internal T1 Value1 { get; init; }
	internal T2 Value2 { get; init; }
	internal T3 Value3 { get; init; }
	internal T4 Value4 { get; init; }
	internal T5 Value5 { get; init; }
	internal T6 Value6 { get; init; }
	internal T7 Value7 { get; init; }

	internal int Index { get; init; }

	public bool Is0 => Index == 0;
	public bool Is1 => Index == 1;
	public bool Is2 => Index == 2;
	public bool Is3 => Index == 3;
	public bool Is4 => Index == 4;
	public bool Is5 => Index == 5;
	public bool Is6 => Index == 6;
	public bool Is7 => Index == 7;

	internal object? Value => Index switch
	{
		0 => Value0,
		1 => Value1,
		2 => Value2,
		3 => Value3,
		4 => Value4,
		5 => Value5,
		6 => Value6,
		7 => Value7,
		_ => throw new ArgumentOutOfRangeException(nameof(Index))
	};

	public Union() => throw new InvalidOperationException();

	private Union(int index, T0? value0 = default, T1? value1 = default, T2? value2 = default, T3? value3 = default, T4? value4 = default, T5? value5 = default, T6? value6 = default, T7? value7 = default)
	{
		Index = index;
		Value0 = value0!;
		Value1 = value1!;
		Value2 = value2!;
		Value3 = value3!;
		Value4 = value4!;
		Value5 = value5!;
		Value6 = value6!;
		Value7 = value7!;
	}

	internal Union(object? value) : this(-1)
	{
		switch (value)
		{
			case T0 matchedValue: Value0 = matchedValue; Index = 0; break;
			case T1 matchedValue: Value1 = matchedValue; Index = 1; break;
			case T2 matchedValue: Value2 = matchedValue; Index = 2; break;
			case T3 matchedValue: Value3 = matchedValue; Index = 3; break;
			case T4 matchedValue: Value4 = matchedValue; Index = 4; break;
			case T5 matchedValue: Value5 = matchedValue; Index = 5; break;
			case T6 matchedValue: Value6 = matchedValue; Index = 6; break;
			case T7 matchedValue: Value7 = matchedValue; Index = 7; break;
			default: throw new ArgumentOutOfRangeException(nameof(value));
		}
	}

	public static Union<T0, T1, T2, T3, T4, T5, T6, T7> FromT0(T0 value) => value;
	public static Union<T0, T1, T2, T3, T4, T5, T6, T7> FromT1(T1 value) => value;
	public static Union<T0, T1, T2, T3, T4, T5, T6, T7> FromT2(T2 value) => value;
	public static Union<T0, T1, T2, T3, T4, T5, T6, T7> FromT3(T3 value) => value;
	public static Union<T0, T1, T2, T3, T4, T5, T6, T7> FromT4(T4 value) => value;
	public static Union<T0, T1, T2, T3, T4, T5, T6, T7> FromT5(T5 value) => value;
	public static Union<T0, T1, T2, T3, T4, T5, T6, T7> FromT6(T6 value) => value;
	public static Union<T0, T1, T2, T3, T4, T5, T6, T7> FromT7(T7 value) => value;

	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6, T7>> FromT0(Task<T0> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6, T7>> FromT1(Task<T1> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6, T7>> FromT2(Task<T2> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6, T7>> FromT3(Task<T3> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6, T7>> FromT4(Task<T4> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6, T7>> FromT5(Task<T5> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6, T7>> FromT6(Task<T6> value) => await value;
	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6, T7>> FromT7(Task<T7> value) => await value;

	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(T0 value) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(0, value0: value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(T1 value) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(1, value1: value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(T2 value) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(2, value2: value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(T3 value) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(3, value3: value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(T4 value) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(4, value4: value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(T5 value) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(5, value5: value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(T6 value) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(6, value6: value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(T7 value) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(7, value7: value);

	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T2, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T3, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T4, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T5, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T6, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T7, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T0, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T2, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T3, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T4, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T5, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T6, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T1, T7, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T0, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T1, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T3, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T4, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T5, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T6, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T2, T7, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T0, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T1, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T2, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T4, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T5, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T6, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T3, T7, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T0, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T1, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T2, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T3, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T5, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T6, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T4, T7, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T0, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T1, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T2, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T3, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T6, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T4, T7, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T6, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T5, T7, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T0, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T1, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T2, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T3, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T5, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T4, T7, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T0, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T1, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T2, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T3, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T4, T7> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T7, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T7, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T7, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T7, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T5, T7, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T6, T7, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T0, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T1, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T2, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T3, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T4, T6, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T0, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T1, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T2, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T3, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T4, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T6, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T6, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T6, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T6, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T5, T6, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T0, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T0, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T0, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T0, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T0, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T1, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T1, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T1, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T1, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T1, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T2, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T2, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T2, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T2, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T2, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T3, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T3, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T3, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T3, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T4, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T4, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T4, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T4, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T5, T0> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T5, T1> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T5, T2> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T5, T3> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T7, T6, T5, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T2, T3, T4> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T2, T3, T4, T5> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
	public static implicit operator Union<T0, T1, T2, T3, T4, T5, T6, T7>(Union<T0, T1, T2, T3, T4, T5, T6> other) =>
		new Union<T0, T1, T2, T3, T4, T5, T6, T7>(other.Value);
}