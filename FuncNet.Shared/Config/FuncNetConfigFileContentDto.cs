namespace FuncNet.Shared.Config;

public sealed record class FuncNetConfigFileContentDto(
	IReadOnlyCollection<string> GenericsRegistrations)
{
	public FuncNetConfigFileContentDto() : this([]) { }
}