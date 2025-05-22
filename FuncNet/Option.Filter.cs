#nullable enable

using System;
using System.Threading;
using System.Threading.Tasks;

namespace FuncNet;

public static class OptionFilter
{
	public static Option<TValue> Filter<TValue>(
		this Option<TValue> option,
		Func<TValue, bool> predicate)
	{
		var u = option;
		if (u.Index == 0 && !predicate(u.Value0!)) return Option<TValue>.None;

		return option;
	}

	public static async Task<Option<TValue>> Filter<TValue>(
		this Task<Option<TValue>> option,
		Func<TValue, Task<bool>> predicate,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		if (u.Index == 0 && !await predicate(u.Value0!).ConfigureAwait(false)) return Option<TValue>.None;

		return await option.ConfigureAwait(false);
	}

	public static async Task<Option<TValue>> Filter<TValue>(
		this Option<TValue> option,
		Func<TValue, Task<bool>> predicate,
		CancellationToken cancellationToken = default)
	{
		var u = option;
		cancellationToken.ThrowIfCancellationRequested();
		if (u.Index == 0 && !await predicate(u.Value0!).ConfigureAwait(false)) return Option<TValue>.None;

		return option;
	}

	public static async Task<Option<TValue>> Filter<TValue>(
		this Task<Option<TValue>> option,
		Func<TValue, bool> predicate,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		if (u.Index == 0 && !predicate(u.Value0!)) return Option<TValue>.None;

		return await option.ConfigureAwait(false);
	}
}