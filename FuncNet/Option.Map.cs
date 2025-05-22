#nullable enable

using System;
using System.Threading;
using System.Threading.Tasks;

namespace FuncNet;

public static class OptionMap
{
	public static Option<TValueNew> Map<TValueNew, TValueOld>(
		this Option<TValueOld> option,
		Func<TValueOld, TValueNew> mapping)
	{
		var u = option;
		return u.Index switch
		{
			0 => Option<TValueNew>.Some(mapping(u.Value0!)),
			_ => Option<TValueNew>.None
		};
	}

	public static async Task<Option<TValueNew>> Map<TValueNew, TValueOld>(
		this Task<Option<TValueOld>> option,
		Func<TValueOld, Task<TValueNew>> mapping,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		return await (u.Index switch
		{
			0 => Option<TValueNew>.Some(mapping(u.Value0!)),
			_ => Task.FromResult(Option<TValueNew>.None)
		}).ConfigureAwait(false);
	}

	public static async Task<Option<TValueNew>> Map<TValueNew, TValueOld>(
		this Option<TValueOld> option,
		Func<TValueOld, Task<TValueNew>> mapping,
		CancellationToken cancellationToken = default)
	{
		var u = option;
		cancellationToken.ThrowIfCancellationRequested();
		return await (u.Index switch
		{
			0 => Option<TValueNew>.Some(mapping(u.Value0!)),
			_ => Task.FromResult(Option<TValueNew>.None)
		}).ConfigureAwait(false);
	}

	public static async Task<Option<TValueNew>> Map<TValueNew, TValueOld>(
		this Task<Option<TValueOld>> option,
		Func<TValueOld, TValueNew> mapping,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		return u.Index switch
		{
			0 => Option<TValueNew>.Some(mapping(u.Value0!)),
			_ => Option<TValueNew>.None
		};
	}
}