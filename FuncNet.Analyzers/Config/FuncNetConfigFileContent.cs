using System.Collections.Immutable;

namespace FuncNet.Analyzers.Config;

internal sealed record class FuncNetConfigFileContent
{
	public ImmutableList<TypeEntry> UnionRegistrations { get; }

	private FuncNetConfigFileContent(ImmutableList<TypeEntry> unionRegistrations) =>
		UnionRegistrations = unionRegistrations;

	public static FuncNetConfigFileContent Empty() =>
		new(ImmutableList<TypeEntry>.Empty);

	public static FuncNetConfigFileContent FromDto(FuncNetConfigFileContentDto configDto) =>
		new(configDto.UnionRegistrations.Select(entry => new TypeEntry(entry)).ToImmutableList());

	public FuncNetConfigFileContentDto ToDto() =>
		new(UnionRegistrations.Select(typeEntry => typeEntry.TypeName).ToList());

	public FuncNetConfigFileContent WithUnionRegistration(TypeEntry registration) =>
		UnionRegistrations.Contains(registration)
			? this
			: new FuncNetConfigFileContent(UnionRegistrations.Add(registration));
}