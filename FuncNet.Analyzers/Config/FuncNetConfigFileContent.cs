namespace FuncNet.Analyzers.Config;

internal sealed record class FuncNetConfigFileContent(
	IReadOnlyList<string> UnionRegistrations)
{
	public FuncNetConfigFileContent() : this([]) { }

	public FuncNetConfigFileContent WithUnionRegistration(UnionRegistration registration) =>
		UnionRegistrations.Contains(registration.TypeName)
			? this
			: new FuncNetConfigFileContent([..UnionRegistrations, registration.TypeName]);
}