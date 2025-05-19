using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet.Union;
		public static class Result5Map
{public static Result<TSuccessNew, TError0, TError1, TError2, TError3> MapSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3>(this Result<TSuccessOld, TError0, TError1, TError2, TError3> result,
		Func<TSuccessOld, TSuccessNew> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value2),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value3),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value4),
			};
			
		}

	public static Result<TSuccess, TError0New, TError1, TError2, TError3> MapError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3>(this Result<TSuccess, TError0Old, TError1, TError2, TError3> result,
		Func<TError0Old, TError0New> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(u.Value2),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(u.Value3),
			_ => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(u.Value4),
			};
			
		}

	public static Result<TSuccess, TError0, TError1New, TError2, TError3> MapError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3>(this Result<TSuccess, TError0, TError1Old, TError2, TError3> result,
		Func<TError1Old, TError1New> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(mapping(u.Value2)),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(u.Value3),
			_ => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(u.Value4),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2New, TError3> MapError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3>(this Result<TSuccess, TError0, TError1, TError2Old, TError3> result,
		Func<TError2Old, TError2New> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(mapping(u.Value3)),
			_ => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(u.Value4),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3New> MapError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old>(this Result<TSuccess, TError0, TError1, TError2, TError3Old> result,
		Func<TError3Old, TError3New> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(u.Value3),
			_ => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(mapping(u.Value4)),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3>> MapSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3>(this Task<Result<TSuccessOld, TError0, TError1, TError2, TError3>> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(Task.FromResult(u.Value3)),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(Task.FromResult(u.Value4)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1, TError2, TError3>> MapError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3>(this Task<Result<TSuccess, TError0Old, TError1, TError2, TError3>> result,
		Func<TError0Old, Task<TError0New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(Task.FromResult(u.Value3)),
			_ => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(Task.FromResult(u.Value4)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New, TError2, TError3>> MapError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3>(this Task<Result<TSuccess, TError0, TError1Old, TError2, TError3>> result,
		Func<TError1Old, Task<TError1New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(mapping(u.Value2)),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(Task.FromResult(u.Value3)),
			_ => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(Task.FromResult(u.Value4)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2New, TError3>> MapError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3>(this Task<Result<TSuccess, TError0, TError1, TError2Old, TError3>> result,
		Func<TError2Old, Task<TError2New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(mapping(u.Value3)),
			_ => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(Task.FromResult(u.Value4)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3New>> MapError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3Old>> result,
		Func<TError3Old, Task<TError3New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(Task.FromResult(u.Value3)),
			_ => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(mapping(u.Value4)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3>> MapSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3>(this Result<TSuccessOld, TError0, TError1, TError2, TError3> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(Task.FromResult(u.Value3)),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(Task.FromResult(u.Value4)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1, TError2, TError3>> MapError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3>(this Result<TSuccess, TError0Old, TError1, TError2, TError3> result,
		Func<TError0Old, Task<TError0New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(Task.FromResult(u.Value3)),
			_ => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(Task.FromResult(u.Value4)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New, TError2, TError3>> MapError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3>(this Result<TSuccess, TError0, TError1Old, TError2, TError3> result,
		Func<TError1Old, Task<TError1New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(mapping(u.Value2)),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(Task.FromResult(u.Value3)),
			_ => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(Task.FromResult(u.Value4)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2New, TError3>> MapError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3>(this Result<TSuccess, TError0, TError1, TError2Old, TError3> result,
		Func<TError2Old, Task<TError2New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(mapping(u.Value3)),
			_ => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(Task.FromResult(u.Value4)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3New>> MapError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old>(this Result<TSuccess, TError0, TError1, TError2, TError3Old> result,
		Func<TError3Old, Task<TError3New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(Task.FromResult(u.Value3)),
			_ => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(mapping(u.Value4)),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3>> MapSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3>(this Task<Result<TSuccessOld, TError0, TError1, TError2, TError3>> result,
		Func<TSuccessOld, TSuccessNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value2),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value3),
			_ => Result<TSuccessNew, TError0, TError1, TError2, TError3>.FromError(u.Value4),
			};
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1, TError2, TError3>> MapError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3>(this Task<Result<TSuccess, TError0Old, TError1, TError2, TError3>> result,
		Func<TError0Old, TError0New> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(u.Value2),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(u.Value3),
			_ => Result<TSuccess, TError0New, TError1, TError2, TError3>.FromError(u.Value4),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New, TError2, TError3>> MapError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3>(this Task<Result<TSuccess, TError0, TError1Old, TError2, TError3>> result,
		Func<TError1Old, TError1New> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(mapping(u.Value2)),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(u.Value3),
			_ => Result<TSuccess, TError0, TError1New, TError2, TError3>.FromError(u.Value4),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2New, TError3>> MapError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3>(this Task<Result<TSuccess, TError0, TError1, TError2Old, TError3>> result,
		Func<TError2Old, TError2New> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(mapping(u.Value3)),
			_ => Result<TSuccess, TError0, TError1, TError2New, TError3>.FromError(u.Value4),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3New>> MapError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3Old>> result,
		Func<TError3Old, TError3New> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(u.Value3),
			_ => Result<TSuccess, TError0, TError1, TError2, TError3New>.FromError(mapping(u.Value4)),
			};
			
		}}
		