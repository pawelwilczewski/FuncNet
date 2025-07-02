using System.Collections.Immutable;

namespace FuncNet.Analyzers.Config;

internal sealed record class FuncNetConfigFileContent
{
	public ImmutableHashSet<TypeEntry> UnionRegistrations { get; }

	private FuncNetConfigFileContent(ImmutableHashSet<TypeEntry> unionRegistrations) =>
		UnionRegistrations = unionRegistrations;

	public static FuncNetConfigFileContent Empty() =>
		new(ImmutableHashSet<TypeEntry>.Empty);

	public static FuncNetConfigFileContent FromDto(FuncNetConfigFileContentDto configDto) =>
		new(configDto.UnionRegistrations.Select(entry => new TypeEntry(entry)).ToImmutableHashSet());

	public FuncNetConfigFileContentDto ToDto() =>
		new(UnionRegistrations.Select(typeEntry => typeEntry.TypeName).ToList());

	public FuncNetConfigFileContent WithUnionRegistration(TypeEntry registration) =>
		UnionRegistrations.Contains(registration)
			? this
			: new FuncNetConfigFileContent(UnionRegistrations.Add(registration));
}