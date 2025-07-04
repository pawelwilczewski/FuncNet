using System.Collections.Immutable;
using FuncNet.Shared.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace FuncNet.Shared.Config;

public static class FuncNetConfigExtensions
{
	public static async Task<FuncNetConfig?> GetFuncNetConfig(this Solution solution, CancellationToken cancellationToken)
	{
		var configDocuments = solution.Projects
			.SelectMany(project => project.AdditionalDocuments)
			.DistinctBy(document => document.Id)
			.Where(document => document.Name == FuncNetConfig.FILE_NAME)
			.ToImmutableHashSet();

		var configDocumentsText = await Task.WhenAll(configDocuments
				.Select(document => document.GetTextAsync(cancellationToken)))
			.ConfigureAwait(false);

		var configFileContent = FuncNetConfigFileContent.Combine(configDocumentsText
				.Select(text => text.ToString())
				.Select(configText => SimpleJson.SimpleJson.DeserializeObjectOrDefault(configText?.ToString(), new FuncNetConfigFileContentDto()))
				.Select(FuncNetConfigFileContent.FromDto))
			?? FuncNetConfigFileContent.Empty();

		return new FuncNetConfig(solution, configDocuments, configFileContent);
	}

	public static FuncNetConfigFileContent? GetFuncNetConfig(this AnalyzerOptions options) =>
		FuncNetConfigFileContent.Combine(options.AdditionalFiles
			.DistinctBy(text => text.Path)
			.Where(text => Path.GetFileName(text.Path) == FuncNetConfig.FILE_NAME)
			.Select(configDocument => configDocument.GetText())
			.Select(configText => SimpleJson.SimpleJson.DeserializeObjectOrDefault(configText?.ToString(), new FuncNetConfigFileContentDto()))
			.Select(FuncNetConfigFileContent.FromDto));
}