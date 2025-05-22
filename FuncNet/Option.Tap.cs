#nullable enable

using System;
using System.Threading;
using System.Threading.Tasks;

namespace FuncNet;

public static class OptionTap
{
	public static Option<TValue> TapValue<TValue>(
		this Option<TValue> option,
		Action<TValue> action)
	{
		var u = option;
		if (u.Index == 0) action(u.Value0!);
		return option;
	}

	public static async Task<Option<TValue>> TapValue<TValue>(
		this Task<Option<TValue>> option,
		Func<TValue, Task> action,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		if (u.Index == 0) await action(u.Value0!).ConfigureAwait(false);
		return await option.ConfigureAwait(false);
	}

	public static async Task<Option<TValue>> TapValue<TValue>(
		this Option<TValue> option,
		Func<TValue, Task> action,
		CancellationToken cancellationToken = default)
	{
		var u = option;
		cancellationToken.ThrowIfCancellationRequested();
		if (u.Index == 0) await action(u.Value0!).ConfigureAwait(false);
		return option;
	}

	public static async Task<Option<TValue>> TapValue<TValue>(
		this Task<Option<TValue>> option,
		Action<TValue> action,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		if (u.Index == 0) action(u.Value0!);
		return await option.ConfigureAwait(false);
	}
}