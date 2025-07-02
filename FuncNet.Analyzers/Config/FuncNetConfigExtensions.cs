using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace FuncNet.Analyzers.Config;

internal static class FuncNetConfigExtensions
{
	public static async Task<FuncNetConfig?> GetFuncNetConfig(this Solution solution, CancellationToken cancellationToken)
	{
		var configDocuments = solution.Projects
			.SelectMany(project => project.AdditionalDocuments)
			.Where(document => document.Name == FuncNetConfig.FILE_NAME)
			.ToImmutableArray();

		var configDocument = configDocuments.Length switch
		{
			0 => null,
			1 => configDocuments.First(),
			_ => throw new NotSupportedException("Multiple config files in single solution are not yet supported")
		};
		if (configDocument is null) return null;

		var configText = await configDocument.GetTextAsync(cancellationToken).ConfigureAwait(false);
		var contentDto = SimpleJson.SimpleJson.DeserializeObject<FuncNetConfigFileContentDto>(configText!.ToString())
			?? new FuncNetConfigFileContentDto();

		return new FuncNetConfig(solution, configDocument, FuncNetConfigFileContent.FromDto(contentDto));
	}

	public static FuncNetConfigFileContent? GetFuncNetConfig(this AnalyzerOptions options)
	{
		var configDocuments = options.AdditionalFiles
			.Where(text => Path.GetFileName(text.Path) == FuncNetConfig.FILE_NAME)
			.ToImmutableArray();

		var configDocument = configDocuments.Length switch
		{
			0 => null,
			1 => configDocuments.First(),
			_ => throw new NotSupportedException("Multiple config files in single solution are not yet supported")
		};
		if (configDocument is null) return null;

		var configText = configDocument.GetText();
		var contentDto = SimpleJson.SimpleJson.DeserializeObject<FuncNetConfigFileContentDto>(configText?.ToString())
			?? new FuncNetConfigFileContentDto();

		return FuncNetConfigFileContent.FromDto(contentDto);
	}
}