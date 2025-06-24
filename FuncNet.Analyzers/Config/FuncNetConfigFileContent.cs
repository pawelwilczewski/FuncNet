using System.Collections.Immutable;

namespace FuncNet.Analyzers.Config;

internal sealed record class FuncNetConfigFileContent(
	ImmutableList<string> UnionRegistrations)
{
	public FuncNetConfigFileContent WithUnionRegistration(UnionRegistration registration) =>
		UnionRegistrations.Contains(registration.TypeName)
			? this
			: new FuncNetConfigFileContent(UnionRegistrations.Add(registration.TypeName));
}