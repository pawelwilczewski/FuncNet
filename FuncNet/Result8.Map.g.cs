using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Result8Map
{public static Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6> MapSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccessOld, TSuccessNew> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6> MapError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError0Old, TError0New> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6> MapError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError1Old, TError1New> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(mapping(u.Value2)),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6> MapError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6> result,
		Func<TError2Old, TError2New> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(mapping(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6> MapError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6> result,
		Func<TError3Old, TError3New> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(mapping(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6> MapError4<TError4New, TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6> result,
		Func<TError4Old, TError4New> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(mapping(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6> MapError5<TError5New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6> result,
		Func<TError5Old, TError5New> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(mapping(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New> MapError6<TError6New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old> result,
		Func<TError6Old, TError6New> mapping){
		var u = (result).Value;
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(mapping(u.Value7)),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> MapSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>> MapError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError0Old, Task<TError0New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>> MapError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError1Old, Task<TError1New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(mapping(u.Value2)),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>> MapError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6>> result,
		Func<TError2Old, Task<TError2New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(mapping(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>> MapError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6>> result,
		Func<TError3Old, Task<TError3New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(mapping(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>> MapError4<TError4New, TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6>> result,
		Func<TError4Old, Task<TError4New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(mapping(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>> MapError5<TError5New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6>> result,
		Func<TError5Old, Task<TError5New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(mapping(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>> MapError6<TError6New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old>> result,
		Func<TError6Old, Task<TError6New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(mapping(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> MapSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TSuccessOld, Task<TSuccessNew>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>> MapError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError0Old, Task<TError0New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>> MapError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6> result,
		Func<TError1Old, Task<TError1New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(mapping(u.Value2)),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>> MapError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6> result,
		Func<TError2Old, Task<TError2New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(mapping(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>> MapError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6> result,
		Func<TError3Old, Task<TError3New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(mapping(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>> MapError4<TError4New, TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6> result,
		Func<TError4Old, Task<TError4New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(mapping(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>> MapError5<TError5New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6> result,
		Func<TError5Old, Task<TError5New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(mapping(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(Task.FromResult(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>> MapError6<TError6New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old>(this Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old> result,
		Func<TError6Old, Task<TError6New>> mapping,
		CancellationToken cancellationToken = default){
		var u = (result).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return await (u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromSuccess(Task.FromResult(u.Value0)),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value1)),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value2)),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(Task.FromResult(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(mapping(u.Value7)),
			_ => throw new Unreachable(),
			}).ConfigureAwait(false);
			
		}

	public static async Task<Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> MapSuccess<TSuccessNew, TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccessOld, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TSuccessOld, TSuccessNew> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(mapping(u.Value0)),
			1 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccessNew, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>> MapError0<TError0New, TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0Old, TError1, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError0Old, TError0New> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(mapping(u.Value1)),
			2 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0New, TError1, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>> MapError1<TError1New, TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1Old, TError2, TError3, TError4, TError5, TError6>> result,
		Func<TError1Old, TError1New> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(mapping(u.Value2)),
			3 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1New, TError2, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>> MapError2<TError2New, TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2Old, TError3, TError4, TError5, TError6>> result,
		Func<TError2Old, TError2New> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(mapping(u.Value3)),
			4 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2New, TError3, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>> MapError3<TError3New, TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3Old, TError4, TError5, TError6>> result,
		Func<TError3Old, TError3New> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(mapping(u.Value4)),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3New, TError4, TError5, TError6>.FromError(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>> MapError4<TError4New, TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4Old, TError5, TError6>> result,
		Func<TError4Old, TError4New> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(mapping(u.Value5)),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4New, TError5, TError6>.FromError(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>> MapError5<TError5New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5Old, TError6>> result,
		Func<TError5Old, TError5New> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(mapping(u.Value6)),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5New, TError6>.FromError(u.Value7),
			_ => throw new Unreachable(),
			};
			
		}

	public static async Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>> MapError6<TError6New, TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old>(this Task<Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6Old>> result,
		Func<TError6Old, TError6New> mapping,
		CancellationToken cancellationToken = default){
		var u = (await (result).ConfigureAwait(false)).Value;
			cancellationToken.ThrowIfCancellationRequested();
			return u.Index switch
		{
			0 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromSuccess(u.Value0),
			1 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value1),
			2 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value2),
			3 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value3),
			4 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value4),
			5 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value5),
			6 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(u.Value6),
			7 => Result<TSuccess, TError0, TError1, TError2, TError3, TError4, TError5, TError6New>.FromError(mapping(u.Value7)),
			_ => throw new Unreachable(),
			};
			
		}}
		