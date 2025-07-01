using Microsoft.CodeAnalysis;

namespace FuncNet.Analyzers.Config;

internal static class FuncNetConfigExtensions
{
	public static async Task<FuncNetConfig?> TryGetFuncNetConfig(this Solution solution, CancellationToken cancellationToken)
	{
		var configDocument = solution.Projects.SelectMany(project => project.AdditionalDocuments)
			.FirstOrDefault(document => document.Name == FuncNetConfig.FILE_NAME);
		if (configDocument is null) return null;

		var configText = await configDocument.GetTextAsync(cancellationToken).ConfigureAwait(false);
		var content = SimpleJson.SimpleJson.DeserializeObject<FuncNetConfigFileContent>(configText!.ToString())
			?? new FuncNetConfigFileContent();

		return new FuncNetConfig(solution, configDocument, content);
	}
}