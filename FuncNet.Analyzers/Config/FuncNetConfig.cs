using FuncNet.Analyzers.Json;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace FuncNet.Analyzers.Config;

internal sealed record class FuncNetConfig(
	Solution Solution,
	TextDocument ConfigDocument,
	FuncNetConfigFileContent Content)
{
	public const string FILE_NAME = "funcnet.json";

	public FuncNetConfig WithUnionRegistration(TypeEntry unionType)
	{
		var newContent = Content.WithUnionRegistration(unionType);
		var serializedContent = JsonFormatter.Format(SimpleJson.SimpleJson.SerializeObject(newContent.ToDto()));
		var solution = Solution.WithAdditionalDocumentText(ConfigDocument.Id, SourceText.From(serializedContent));
		return new FuncNetConfig(solution, solution.GetAdditionalDocument(ConfigDocument.Id)!, newContent);
	}
}