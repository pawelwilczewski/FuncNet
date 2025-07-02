namespace FuncNet.Analyzers.Config;

internal sealed record class FuncNetConfigFileContentDto(
	IReadOnlyCollection<string> UnionRegistrations)
{
	public FuncNetConfigFileContentDto() : this([]) { }
}