

#nullable enable

namespace FuncNet.Union;


public readonly record struct Union<T0, T1, T2>
{
	internal T0? Value0 { get; init; }
internal T1? Value1 { get; init; }
internal T2? Value2 { get; init; }

	internal int Index { get; init; }
}

