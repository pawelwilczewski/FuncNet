namespace FuncNet.Shared.Config;

public readonly record struct GenericArguments(string CommaSeparatedArguments) : IComparable<GenericArguments>
{
	public string CommaSeparatedArguments { get; } = NormalizeTypeName(CommaSeparatedArguments);

	public static string NormalizeTypeName(string typeName) =>
		string.IsNullOrWhiteSpace(typeName)
			? string.Empty
			: typeName.Replace(" ", "")
				.Replace("\t", "")
				.Replace("\r", "")
				.Replace("\n", "");

	public override string ToString() => CommaSeparatedArguments;

	public int CompareTo(GenericArguments other) =>
		string.Compare(CommaSeparatedArguments, other.CommaSeparatedArguments, StringComparison.OrdinalIgnoreCase);
}