using System.Collections.Immutable;
using FuncNet.Shared.Json;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace FuncNet.Shared.Config;

public sealed record class FuncNetConfig(
	Solution Solution,
	ImmutableHashSet<TextDocument> ConfigDocuments,
	FuncNetConfigFileContent Content)
{
	public const string FILE_NAME = "funcnet.json";

	public FuncNetConfig WithTypeRegistration(TypeEntry typeEntry)
	{
		var newContent = Content.WithTypeRegistration(typeEntry);
		var serializedContent = JsonFormatter.Format(SimpleJson.SimpleJson.SerializeObject(newContent.ToDto()));
		var solution = Solution.WithAdditionalDocumentText(ConfigDocuments.First().Id, SourceText.From(serializedContent));
		return new FuncNetConfig(solution, ConfigDocuments.Select(configDocument => solution.GetAdditionalDocument(configDocument.Id)!).ToImmutableHashSet(), newContent);
	}
}