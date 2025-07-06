namespace FuncNet.Shared.Linq;

public static class LinqExtensions
{
	public static IEnumerable<TValue> DistinctBy<TValue, TKey>(
		this IEnumerable<TValue> values,
		Func<TValue, TKey> comparisonKey) => values
		.GroupBy(comparisonKey)
		.Select(group => group.First());
}