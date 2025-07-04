using System.Collections.Immutable;

namespace FuncNet.Shared.Config;

public sealed record class FuncNetConfigFileContent
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

	public static FuncNetConfigFileContent? Combine(params IEnumerable<FuncNetConfigFileContent> configs)
	{
		FuncNetConfigFileContent? finalConfig = null;
		foreach (var config in configs)
		{
			finalConfig = finalConfig == null ? config : finalConfig.WithTypeRegistrations(config.TypeRegistrations);
		}

		return finalConfig;
	}

	public FuncNetConfigFileContent WithTypeRegistration(TypeEntry registration) =>
		TypeRegistrations.Contains(registration)
			? this
			: new FuncNetConfigFileContent(TypeRegistrations.Add(registration));

	public FuncNetConfigFileContent WithTypeRegistrations(params IEnumerable<TypeEntry> registrations) =>
		registrations.Aggregate(this, (config, registration) => config.WithTypeRegistration(registration));
}