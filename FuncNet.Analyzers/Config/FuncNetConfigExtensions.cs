using Microsoft.CodeAnalysis;

namespace FuncNet.Analyzers.Config;

internal static class FuncNetConfigExtensions
{
	public static async Task<FuncNetConfig> GetOrCreateFuncNetConfig(this Solution solution, CancellationToken cancellationToken)
	{
		var configProject = await solution.GetFuncNetReferencingProject(cancellationToken);
		if (configProject is null)
		{
			throw new InvalidOperationException("No FuncNet-referencing project found. Make sure FuncNet is installed.");
		}

		var configDocument = configProject.AdditionalDocuments
			.FirstOrDefault(document => document.Name == FuncNetConfig.FILE_NAME);
		var configFileId = configDocument?.Id ?? DocumentId.CreateNewId(configProject.Id);

		if (configDocument is null)
		{
			solution = solution.AddAdditionalDocument(
				configFileId,
				FuncNetConfig.FILE_NAME,
				SimpleJson.SimpleJson.SerializeObject(new FuncNetConfigFileContent()),
				filePath: Path.Combine(Path.GetDirectoryName(configProject.FilePath!)!, FuncNetConfig.FILE_NAME));
		}

		configDocument = solution.GetProject(configProject.Id)!.GetAdditionalDocument(configFileId)!;
		var configText = await configDocument.GetTextAsync(cancellationToken).ConfigureAwait(false);
		var content = SimpleJson.SimpleJson.DeserializeObject<FuncNetConfigFileContent>(configText!.ToString())
			?? new FuncNetConfigFileContent();

		return new FuncNetConfig(solution, configDocument, content);
	}

	private static async Task<Project?> GetFuncNetReferencingProject(this Solution solution, CancellationToken cancellationToken)
	{
		var projects = solution.Projects
			.Where(project => !project.Name.Contains(".Test")); // TODO Pawel: hacky but I'm not sure what the best way is... In general users shouldn't have more than one project referencing FuncNet anyways

		foreach (var project in projects)
		{
			var hasReference = await project.HasReferenceToFuncNet(cancellationToken);
			if (hasReference) return project;
		}

		return null;
	}

	private static async Task<bool> HasReferenceToFuncNet(
		this Project project,
		CancellationToken cancellationToken)
	{
		var sourceGeneratedDocuments = await project.GetSourceGeneratedDocumentsAsync(cancellationToken).ConfigureAwait(false);
		return sourceGeneratedDocuments.Any(document => document.Name == "Result3.cs");
	}
}