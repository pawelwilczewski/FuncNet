using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace FuncNet.Analyzers.Config;

internal sealed record class FuncNetConfig(
	Solution Solution,
	TextDocument ConfigDocument,
	FuncNetConfigFileContent Content)
{
	public const string FILE_NAME = "FuncNetConfig.json";

	public FuncNetConfig WithUnionRegistration(UnionRegistration registration)
	{
		var newContent = Content.WithUnionRegistration(registration);
		var serializedContent = SimpleJson.SimpleJson.SerializeObject(newContent);
		var solution = Solution.WithAdditionalDocumentText(ConfigDocument.Id, SourceText.From(serializedContent));
		return new FuncNetConfig(solution, solution.GetAdditionalDocument(ConfigDocument.Id)!, newContent);
	}
}