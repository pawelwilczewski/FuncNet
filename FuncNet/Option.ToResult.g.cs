using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class OptionToResult
{public static Result<TSome, TError0> ToResult<TSome, TError0>(this Option<TSome> option,
		Func<TError0> errorIfNone){
		var extended = (option).Match<Result<TSome, TError0>, TSome>(some => Result<TSome, TError0>.FromSuccess(some),  () => (errorIfNone()));
			return extended;;
			
		}

	public static Result<TSome, TError0, TError1> ToResult<TSome, TError0, TError1>(this Option<TSome> option,
		Func<Union<TError0, TError1>> errorIfNone){
		var extended = (option).Match<Result<TSome, TError0, TError1>, TSome>(some => Result<TSome, TError0, TError1>.FromSuccess(some),  () => (errorIfNone()).Match<Result<TSome, TError0, TError1>, TError0, TError1>(error0 => error0, error1 => error1));
			return extended;;
			
		}

	public static Result<TSome, TError0, TError1, TError2> ToResult<TSome, TError0, TError1, TError2>(this Option<TSome> option,
		Func<Union<TError0, TError1, TError2>> errorIfNone){
		var extended = (option).Match<Result<TSome, TError0, TError1, TError2>, TSome>(some => Result<TSome, TError0, TError1, TError2>.FromSuccess(some),  () => (errorIfNone()).Match<Result<TSome, TError0, TError1, TError2>, TError0, TError1, TError2>(error0 => error0, error1 => error1, error2 => error2));
			return extended;;
			
		}

	public static Result<TSome, TError0, TError1, TError2, TError3> ToResult<TSome, TError0, TError1, TError2, TError3>(this Option<TSome> option,
		Func<Union<TError0, TError1, TError2, TError3>> errorIfNone){
		var extended = (option).Match<Result<TSome, TError0, TError1, TError2, TError3>, TSome>(some => Result<TSome, TError0, TError1, TError2, TError3>.FromSuccess(some),  () => (errorIfNone()).Match<Result<TSome, TError0, TError1, TError2, TError3>, TError0, TError1, TError2, TError3>(error0 => error0, error1 => error1, error2 => error2, error3 => error3));
			return extended;;
			
		}

	public static Result<TSome, TError0, TError1, TError2, TError3, TError4> ToResult<TSome, TError0, TError1, TError2, TError3, TError4>(this Option<TSome> option,
		Func<Union<TError0, TError1, TError2, TError3, TError4>> errorIfNone){
		var extended = (option).Match<Result<TSome, TError0, TError1, TError2, TError3, TError4>, TSome>(some => Result<TSome, TError0, TError1, TError2, TError3, TError4>.FromSuccess(some),  () => (errorIfNone()).Match<Result<TSome, TError0, TError1, TError2, TError3, TError4>, TError0, TError1, TError2, TError3, TError4>(error0 => error0, error1 => error1, error2 => error2, error3 => error3, error4 => error4));
			return extended;;
			
		}

	public static Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5> ToResult<TSome, TError0, TError1, TError2, TError3, TError4, TError5>(this Option<TSome> option,
		Func<Union<TError0, TError1, TError2, TError3, TError4, TError5>> errorIfNone){
		var extended = (option).Match<Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5>, TSome>(some => Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5>.FromSuccess(some),  () => (errorIfNone()).Match<Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5>, TError0, TError1, TError2, TError3, TError4, TError5>(error0 => error0, error1 => error1, error2 => error2, error3 => error3, error4 => error4, error5 => error5));
			return extended;;
			
		}

	public static Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5, TError6> ToResult<TSome, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Option<TSome> option,
		Func<Union<TError0, TError1, TError2, TError3, TError4, TError5, TError6>> errorIfNone){
		var extended = (option).Match<Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5, TError6>, TSome>(some => Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(some),  () => (errorIfNone()).Match<Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5, TError6>, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(error0 => error0, error1 => error1, error2 => error2, error3 => error3, error4 => error4, error5 => error5, error6 => error6));
			return extended;;
			
		}

	public static async Task<Result<TSome, TError0>> ToResult<TSome, TError0>(this Task<Option<TSome>> option,
		Func<Task<TError0>> errorIfNone){
		var extended = (await (option).ConfigureAwait(false)).Match<Result<TSome, TError0>, TSome>(some => Task.FromResult(Result<TSome, TError0>.FromSuccess(some)), async  () => (await (errorIfNone()).ConfigureAwait(false)));
			return await (extended).ConfigureAwait(false);;
			
		}

	public static async Task<Result<TSome, TError0, TError1>> ToResult<TSome, TError0, TError1>(this Task<Option<TSome>> option,
		Func<Task<Union<TError0, TError1>>> errorIfNone){
		var extended = (await (option).ConfigureAwait(false)).Match<Result<TSome, TError0, TError1>, TSome>(some => Task.FromResult(Result<TSome, TError0, TError1>.FromSuccess(some)), async  () => (await (errorIfNone()).ConfigureAwait(false)).Match<Result<TSome, TError0, TError1>, TError0, TError1>(error0 => error0, error1 => error1));
			return await (extended).ConfigureAwait(false);;
			
		}

	public static async Task<Result<TSome, TError0, TError1, TError2>> ToResult<TSome, TError0, TError1, TError2>(this Task<Option<TSome>> option,
		Func<Task<Union<TError0, TError1, TError2>>> errorIfNone){
		var extended = (await (option).ConfigureAwait(false)).Match<Result<TSome, TError0, TError1, TError2>, TSome>(some => Task.FromResult(Result<TSome, TError0, TError1, TError2>.FromSuccess(some)), async  () => (await (errorIfNone()).ConfigureAwait(false)).Match<Result<TSome, TError0, TError1, TError2>, TError0, TError1, TError2>(error0 => error0, error1 => error1, error2 => error2));
			return await (extended).ConfigureAwait(false);;
			
		}

	public static async Task<Result<TSome, TError0, TError1, TError2, TError3>> ToResult<TSome, TError0, TError1, TError2, TError3>(this Task<Option<TSome>> option,
		Func<Task<Union<TError0, TError1, TError2, TError3>>> errorIfNone){
		var extended = (await (option).ConfigureAwait(false)).Match<Result<TSome, TError0, TError1, TError2, TError3>, TSome>(some => Task.FromResult(Result<TSome, TError0, TError1, TError2, TError3>.FromSuccess(some)), async  () => (await (errorIfNone()).ConfigureAwait(false)).Match<Result<TSome, TError0, TError1, TError2, TError3>, TError0, TError1, TError2, TError3>(error0 => error0, error1 => error1, error2 => error2, error3 => error3));
			return await (extended).ConfigureAwait(false);;
			
		}

	public static async Task<Result<TSome, TError0, TError1, TError2, TError3, TError4>> ToResult<TSome, TError0, TError1, TError2, TError3, TError4>(this Task<Option<TSome>> option,
		Func<Task<Union<TError0, TError1, TError2, TError3, TError4>>> errorIfNone){
		var extended = (await (option).ConfigureAwait(false)).Match<Result<TSome, TError0, TError1, TError2, TError3, TError4>, TSome>(some => Task.FromResult(Result<TSome, TError0, TError1, TError2, TError3, TError4>.FromSuccess(some)), async  () => (await (errorIfNone()).ConfigureAwait(false)).Match<Result<TSome, TError0, TError1, TError2, TError3, TError4>, TError0, TError1, TError2, TError3, TError4>(error0 => error0, error1 => error1, error2 => error2, error3 => error3, error4 => error4));
			return await (extended).ConfigureAwait(false);;
			
		}

	public static async Task<Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5>> ToResult<TSome, TError0, TError1, TError2, TError3, TError4, TError5>(this Task<Option<TSome>> option,
		Func<Task<Union<TError0, TError1, TError2, TError3, TError4, TError5>>> errorIfNone){
		var extended = (await (option).ConfigureAwait(false)).Match<Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5>, TSome>(some => Task.FromResult(Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5>.FromSuccess(some)), async  () => (await (errorIfNone()).ConfigureAwait(false)).Match<Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5>, TError0, TError1, TError2, TError3, TError4, TError5>(error0 => error0, error1 => error1, error2 => error2, error3 => error3, error4 => error4, error5 => error5));
			return await (extended).ConfigureAwait(false);;
			
		}

	public static async Task<Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5, TError6>> ToResult<TSome, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(this Task<Option<TSome>> option,
		Func<Task<Union<TError0, TError1, TError2, TError3, TError4, TError5, TError6>>> errorIfNone){
		var extended = (await (option).ConfigureAwait(false)).Match<Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5, TError6>, TSome>(some => Task.FromResult(Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5, TError6>.FromSuccess(some)), async  () => (await (errorIfNone()).ConfigureAwait(false)).Match<Result<TSome, TError0, TError1, TError2, TError3, TError4, TError5, TError6>, TError0, TError1, TError2, TError3, TError4, TError5, TError6>(error0 => error0, error1 => error1, error2 => error2, error3 => error3, error4 => error4, error5 => error5, error6 => error6));
			return await (extended).ConfigureAwait(false);;
			
		}}
		