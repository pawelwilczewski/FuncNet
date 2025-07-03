namespace FuncNet.Analyzers.Config;

internal sealed record class FuncNetConfigFileContentDto(
	IReadOnlyCollection<string> TypeRegistrations)
{
	public FuncNetConfigFileContentDto() : this([]) { }
}