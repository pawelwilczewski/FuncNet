namespace FuncNet.Analyzers.Config;

internal sealed record class FuncNetConfigFileContentDto(
	IReadOnlyList<string> UnionRegistrations)
{
	public FuncNetConfigFileContentDto() : this([]) { }
}