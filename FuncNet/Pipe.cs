using System;
using System.Threading.Tasks;

namespace FuncNet;

public static class PipeExtensions
{
	public static TNew Pipe<TOld, TNew>(this TOld value, Func<TOld, TNew> func) => func(value);

	public static async Task<TNew> Pipe<TOld, TNew>(this Task<TOld> value, Func<TOld, TNew> func) =>
		func(await value.ConfigureAwait(false));

	public static async Task<TNew> Pipe<TOld, TNew>(this Task<TOld> value, Func<TOld, Task<TNew>> func) =>
		await func(await value.ConfigureAwait(false)).ConfigureAwait(false);
}