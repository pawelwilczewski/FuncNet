namespace FuncNet.Analyzers.Config;

public readonly record struct TypeEntry
{
	public string TypeName { get; }

	public TypeEntry(string typeName) => TypeName = NormalizeTypeName(typeName);

	private static string NormalizeTypeName(string typeName) =>
		string.IsNullOrWhiteSpace(typeName)
			? string.Empty
			: typeName.Replace(" ", "")
				.Replace("\t", "")
				.Replace("\r", "")
				.Replace("\n", "");

	public override string ToString() => TypeName;
}