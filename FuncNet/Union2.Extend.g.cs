using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace FuncNet;
		public static class Union2Extend
{public static Union<T0, T1, T2> Extend<T0, T1, T2>(this Union<T0, T1> union){
		Union<T0, T1, T2> extended = union;
			return extended;
			
		}

	public static Union<T0, T1, T2, T3> Extend<T0, T1, T2, T3>(this Union<T0, T1> union){
		Union<T0, T1, T2, T3> extended = union;
			return extended;
			
		}

	public static Union<T0, T1, T2, T3, T4> Extend<T0, T1, T2, T3, T4>(this Union<T0, T1> union){
		Union<T0, T1, T2, T3, T4> extended = union;
			return extended;
			
		}

	public static Union<T0, T1, T2, T3, T4, T5> Extend<T0, T1, T2, T3, T4, T5>(this Union<T0, T1> union){
		Union<T0, T1, T2, T3, T4, T5> extended = union;
			return extended;
			
		}

	public static Union<T0, T1, T2, T3, T4, T5, T6> Extend<T0, T1, T2, T3, T4, T5, T6>(this Union<T0, T1> union){
		Union<T0, T1, T2, T3, T4, T5, T6> extended = union;
			return extended;
			
		}

	public static Union<T0, T1, T2, T3, T4, T5, T6, T7> Extend<T0, T1, T2, T3, T4, T5, T6, T7>(this Union<T0, T1> union){
		Union<T0, T1, T2, T3, T4, T5, T6, T7> extended = union;
			return extended;
			
		}

	public static async Task<Union<T0, T1, T2>> Extend<T0, T1, T2>(this Task<Union<T0, T1>> union){
		Union<T0, T1, T2> extended = await (union).ConfigureAwait(false);
			return extended;
			
		}

	public static async Task<Union<T0, T1, T2, T3>> Extend<T0, T1, T2, T3>(this Task<Union<T0, T1>> union){
		Union<T0, T1, T2, T3> extended = await (union).ConfigureAwait(false);
			return extended;
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4>> Extend<T0, T1, T2, T3, T4>(this Task<Union<T0, T1>> union){
		Union<T0, T1, T2, T3, T4> extended = await (union).ConfigureAwait(false);
			return extended;
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5>> Extend<T0, T1, T2, T3, T4, T5>(this Task<Union<T0, T1>> union){
		Union<T0, T1, T2, T3, T4, T5> extended = await (union).ConfigureAwait(false);
			return extended;
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6>> Extend<T0, T1, T2, T3, T4, T5, T6>(this Task<Union<T0, T1>> union){
		Union<T0, T1, T2, T3, T4, T5, T6> extended = await (union).ConfigureAwait(false);
			return extended;
			
		}

	public static async Task<Union<T0, T1, T2, T3, T4, T5, T6, T7>> Extend<T0, T1, T2, T3, T4, T5, T6, T7>(this Task<Union<T0, T1>> union){
		Union<T0, T1, T2, T3, T4, T5, T6, T7> extended = await (union).ConfigureAwait(false);
			return extended;
			
		}}
		