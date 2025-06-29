using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace FuncNet.Analyzers.Config;

internal sealed record class FuncNetConfig(
	Solution Solution,
	TextDocument? ConfigDocument,
	FuncNetConfigFileContent Content)
{
	public const string FILE_NAME = "FuncNetConfig.json";

	public FuncNetConfig WithUnionRegistration(UnionRegistration registration)
	{
		var newContent = Content.WithUnionRegistration(registration);

		if (ConfigDocument is null)
		{
			// No document exists yet, so we can't update it
			// The changes will be picked up when the file is created by MSBuild and loaded in the next build
			return new FuncNetConfig(Solution, null, newContent);
		}

		var serializedContent = SimpleJson.SimpleJson.SerializeObject(newContent);
		var solution = Solution.WithAdditionalDocumentText(ConfigDocument.Id, SourceText.From(serializedContent));
		return new FuncNetConfig(solution, solution.GetAdditionalDocument(ConfigDocument.Id)!, newContent);
	}
}