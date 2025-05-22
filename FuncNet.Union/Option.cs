#nullable enable

using System.Collections.Generic;
using System.Threading.Tasks;

namespace FuncNet.Union;

public readonly record struct Option<TValue>
{
	public static Option<TValue> None { get; } = new(default, false);

	internal TValue? Value0 { get; init; }
	private bool HasValue { get; }
	internal int Index => HasValue ? 0 : 1;

	private Option(TValue? value, bool hasValue)
	{
		Value0 = value;
		HasValue = hasValue;
	}

	public static Option<TValue> Some(TValue value) => new(value, true);
	public static async Task<Option<TValue>> Some(Task<TValue> value) => new(await value.ConfigureAwait(false), true);

	public static Option<TValue> FromNullable(TValue? value) => new(value, value is not null);

	public static async Task<Option<TValue>> FromNullable(Task<TValue?> value)
	{
		var v = await value.ConfigureAwait(false);
		return new Option<TValue>(v, v is not null);
	}

	public IEnumerable<TValue> ToEnumerable() => HasValue ? [Value0!] : [];
}