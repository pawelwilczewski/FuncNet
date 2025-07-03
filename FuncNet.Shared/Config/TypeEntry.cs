namespace FuncNet.Shared.Config;

public readonly record struct TypeEntry(string TypeName)
{
	public string TypeName { get; } = NormalizeTypeName(TypeName);

	private static string NormalizeTypeName(string typeName) =>
		string.IsNullOrWhiteSpace(typeName)
			? string.Empty
			: typeName.Replace(" ", "")
				.Replace("\t", "")
				.Replace("\r", "")
				.Replace("\n", "");

	public override string ToString() => TypeName;
}