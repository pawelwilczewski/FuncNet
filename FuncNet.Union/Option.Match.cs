#nullable enable

using System;
using System.Threading;
using System.Threading.Tasks;

namespace FuncNet.Union;

public static class OptionMatch
{
	public static TResult Match<TResult, TValue>(
		this Option<TValue> option,
		Func<TValue, TResult> some,
		Func<TResult> none)
	{
		var u = option;
		return u.Index switch
		{
			0 => some(u.Value0!),
			_ => none()
		};
	}

	public static async Task<TResult> Match<TResult, TValue>(
		this Task<Option<TValue>> option,
		Func<TValue, Task<TResult>> some,
		Func<Task<TResult>> none,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		return await (u.Index switch
		{
			0 => some(u.Value0!),
			_ => none()
		}).ConfigureAwait(false);
	}

	public static async Task<TResult> Match<TResult, TValue>(
		this Option<TValue> option,
		Func<TValue, Task<TResult>> some,
		Func<Task<TResult>> none,
		CancellationToken cancellationToken = default)
	{
		var u = option;
		cancellationToken.ThrowIfCancellationRequested();
		return await (u.Index switch
		{
			0 => some(u.Value0!),
			_ => none()
		}).ConfigureAwait(false);
	}

	public static async Task<TResult> Match<TResult, TValue>(
		this Task<Option<TValue>> option,
		Func<TValue, TResult> some,
		Func<TResult> none,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		return u.Index switch
		{
			0 => some(u.Value0!),
			_ => none()
		};
	}
}