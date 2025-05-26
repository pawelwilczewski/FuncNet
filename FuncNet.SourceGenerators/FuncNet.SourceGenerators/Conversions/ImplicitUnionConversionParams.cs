using System.Collections.Immutable;

namespace FuncNet.SourceGenerators.Conversions;

internal readonly record struct ImplicitUnionConversionParams(
	int ConversionTargetGenericSize,
	IImmutableList<int> ConversionSourceGenericArgsOrder)
{
	public string TargetGenericParamsCommaSeparated =>
		string.Join(", ", Enumerable.Range(0, ConversionTargetGenericSize).Select(i => $"T{i}"));

	public string SourceGenericParamsCommaSeparated =>
		string.Join(", ", ConversionSourceGenericArgsOrder.Select(i => $"T{i}"));

	public bool Equals(ImplicitUnionConversionParams other) =>
		ConversionTargetGenericSize == other.ConversionTargetGenericSize
		&& ConversionSourceGenericArgsOrder.SequenceEqual(ConversionSourceGenericArgsOrder);

	public override int GetHashCode()
	{
		unchecked
		{
			var hash = 17;
			hash = hash * 23 + ConversionTargetGenericSize.GetHashCode();

			foreach (var item in ConversionSourceGenericArgsOrder)
			{
				hash = hash * 23 + item.GetHashCode();
			}

			return hash;
		}
	}
}