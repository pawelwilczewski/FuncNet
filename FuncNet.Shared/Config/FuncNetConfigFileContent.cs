using System.Collections.Immutable;

namespace FuncNet.Shared.Config;

public sealed record class FuncNetConfigFileContent
{
	public ImmutableHashSet<GenericArguments> GenericsRegistrations { get; }

	private FuncNetConfigFileContent(ImmutableHashSet<GenericArguments> genericsRegistrations) =>
		GenericsRegistrations = genericsRegistrations;

	public static FuncNetConfigFileContent Empty() =>
		new(ImmutableHashSet<GenericArguments>.Empty);

	public static FuncNetConfigFileContent FromDto(FuncNetConfigFileContentDto configDto) =>
		new(configDto.GenericsRegistrations.Select(entry => new GenericArguments(entry)).ToImmutableHashSet());

	public FuncNetConfigFileContentDto ToDto() =>
		new(GenericsRegistrations.Select(generics => generics.CommaSeparatedArguments).ToList());

	public static FuncNetConfigFileContent? Combine(params IEnumerable<FuncNetConfigFileContent> configs)
	{
		FuncNetConfigFileContent? finalConfig = null;
		foreach (var config in configs)
		{
			finalConfig = finalConfig == null ? config : finalConfig.WithTypeRegistrations(config.GenericsRegistrations);
		}

		return finalConfig;
	}

	public FuncNetConfigFileContent WithTypeRegistration(GenericArguments registration) =>
		GenericsRegistrations.Contains(registration)
			? this
			: new FuncNetConfigFileContent(GenericsRegistrations.Add(registration));

	public FuncNetConfigFileContent WithTypeRegistrations(params IEnumerable<GenericArguments> registrations) =>
		registrations.Aggregate(this, (config, registration) => config.WithTypeRegistration(registration));
}