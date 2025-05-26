namespace FuncNet.Common;

internal static class EnumerableExtensions
{
	public static IEnumerable<TSource> DistinctBy<TSource, TKey>(
		this IEnumerable<TSource> source,
		Func<TSource, TKey> keySelector,
		IEqualityComparer<TKey>? comparer = null)
	{
		if (source == null) throw new ArgumentNullException(nameof(source));
		if (keySelector == null) throw new ArgumentNullException(nameof(keySelector));

		return _(source, keySelector, comparer);

		static IEnumerable<TSource> _(
			IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector,
			IEqualityComparer<TKey>? comparer)
		{
			var knownKeys = new HashSet<TKey>(comparer);
			foreach (var element in source)
			{
				if (knownKeys.Add(keySelector(element))) yield return element;
			}
		}
	}
}