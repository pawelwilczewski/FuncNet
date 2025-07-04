namespace FuncNet.Shared.Config;

public readonly record struct GenericArguments(string CommaSeparatedArguments)
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
}