
using System;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;

public readonly record struct Union<T0>
{
	internal T0 Value0 { get; init; }

	internal int Index { get; init; }

	public bool Is0 => Index == 0;

	internal object? Value => Index switch
	{
		0 => Value0,
		_ => throw new Unreachable()
	};

	public Union() => throw new InvalidOperationException();

	private Union(int index, T0? value0 = default)
	{
		Index = index;
		Value0 = value0!;
	}

	internal Union(object? value) : this(-1)
	{
		switch (value)
		{
			case T0 matchedValue: Value0 = matchedValue; Index = 0; break;
			default: throw new Unreachable();
		}
	}

	public static implicit operator Union<T0>(T0 value) =>
		new Union<T0>(0, value0: value);

	

	public static Union<T0> FromT0(T0 value) => value;

	public static async Task<Union<T0>> FromT0(Task<T0> value) => await value;
}
