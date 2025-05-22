#nullable enable

using System;
using System.Threading;
using System.Threading.Tasks;

namespace FuncNet.Union;

public static class OptionBind
{
	public static Option<TValueNew> Bind<TValueNew, TValueOld>(
		this Option<TValueOld> option,
		Func<TValueOld, Option<TValueNew>> binding)
	{
		var u = option;
		return u.Index switch
		{
			0 => binding(u.Value0!),
			_ => Option<TValueNew>.None
		};
	}

	public static async Task<Option<TValueNew>> Bind<TValueNew, TValueOld>(
		this Task<Option<TValueOld>> option,
		Func<TValueOld, Task<Option<TValueNew>>> binding,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		return await (u.Index switch
		{
			0 => binding(u.Value0!),
			_ => Task.FromResult(Option<TValueNew>.None)
		}).ConfigureAwait(false);
	}

	public static async Task<Option<TValueNew>> Bind<TValueNew, TValueOld>(
		this Option<TValueOld> option,
		Func<TValueOld, Task<Option<TValueNew>>> binding,
		CancellationToken cancellationToken = default)
	{
		var u = option;
		cancellationToken.ThrowIfCancellationRequested();
		return await (u.Index switch
		{
			0 => binding(u.Value0!),
			_ => Task.FromResult(Option<TValueNew>.None)
		}).ConfigureAwait(false);
	}

	public static async Task<Option<TValueNew>> Bind<TValueNew, TValueOld>(
		this Task<Option<TValueOld>> option,
		Func<TValueOld, Option<TValueNew>> binding,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		return u.Index switch
		{
			0 => binding(u.Value0!),
			_ => Option<TValueNew>.None
		};
	}
}