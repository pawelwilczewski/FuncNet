using System.Collections.Immutable;

namespace FuncNet.Analyzers.Config;

internal sealed record class FuncNetConfigFileContent
{
	public ImmutableHashSet<TypeEntry> TypeRegistrations { get; }

	private FuncNetConfigFileContent(ImmutableHashSet<TypeEntry> typeRegistrations) =>
		TypeRegistrations = typeRegistrations;

	public static FuncNetConfigFileContent Empty() =>
		new(ImmutableHashSet<TypeEntry>.Empty);

	public static FuncNetConfigFileContent FromDto(FuncNetConfigFileContentDto configDto) =>
		new(configDto.TypeRegistrations.Select(entry => new TypeEntry(entry)).ToImmutableHashSet());

	public FuncNetConfigFileContentDto ToDto() =>
		new(TypeRegistrations.Select(typeEntry => typeEntry.TypeName).ToList());

	public FuncNetConfigFileContent WithUnionRegistration(TypeEntry registration) =>
		TypeRegistrations.Contains(registration)
			? this
			: new FuncNetConfigFileContent(TypeRegistrations.Add(registration));
}