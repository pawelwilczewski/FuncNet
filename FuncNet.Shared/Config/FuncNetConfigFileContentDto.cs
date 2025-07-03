namespace FuncNet.Shared.Config;

public sealed record class FuncNetConfigFileContentDto(
	IReadOnlyCollection<string> TypeRegistrations)
{
	public FuncNetConfigFileContentDto() : this([]) { }
}