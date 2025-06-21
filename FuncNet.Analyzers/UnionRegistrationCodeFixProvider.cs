using System.Collections.Immutable;
using System.Composition;
using System.Runtime.CompilerServices;
using FuncNet.Analyzers.Config;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;

namespace FuncNet.Analyzers;

[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(UnionRegistrationCodeFixProvider))]
[Shared]
public class UnionRegistrationCodeFixProvider : CodeFixProvider
{
	public sealed override ImmutableArray<string> FixableDiagnosticIds =>
		ImmutableArray.Create(UnionRegistrationAnalyzer.DIAGNOSTIC_ID);

	public sealed override FixAllProvider GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

	public sealed override Task RegisterCodeFixesAsync(CodeFixContext context)
	{
		var diagnostic = context.Diagnostics.First();
		if (!diagnostic.Properties.TryGetValue("UnionTypeString", out var unionTypeString)
			|| string.IsNullOrEmpty(unionTypeString))
		{
			return Task.CompletedTask;
		}

		context.RegisterCodeFix(
			CodeAction.Create(
				$"Register '{unionTypeString}' in Root project's {FuncNetConfigFile.FILE_NAME}",
				c => AddOrUpdateUnionRegistrationFileAsync(
					context.Document.Project.Solution, unionTypeString!, c),
				nameof(UnionRegistrationCodeFixProvider) + "_" + unionTypeString),
			diagnostic);

		return Task.CompletedTask;
	}

	private static async Task<Solution> AddOrUpdateUnionRegistrationFileAsync(
		Solution solution,
		string unionTypeName,
		CancellationToken cancellationToken)
	{
		var rootProject = await GetRootProject(solution, cancellationToken).ConfigureAwait(false);
		if (rootProject == null) return solution;

		var funcNetFileConfig = await FuncNetConfigFile.GetOrCreate(rootProject, cancellationToken)
			.ConfigureAwait(false);

		return funcNetFileConfig.WithUnionRegistration(unionTypeName, solution.Workspace).Document.Project.Solution;
	}

	private static async Task<Project?> GetRootProject(Solution solution, CancellationToken cancellationToken) =>
		(await AllProjectsWithCompilationFromSolution(solution, cancellationToken)
			.FirstOrDefaultAsync(HasReferenceToFuncNet, cancellationToken))?.Project;

	private static bool HasReferenceToFuncNet(ProjectWithCompilation project) =>
		project.Compilation.ReferencedAssemblyNames.Any(assembly => assembly.Name == nameof(FuncNet));

	private static async IAsyncEnumerable<ProjectWithCompilation> AllProjectsWithCompilationFromSolution(
		Solution solution,
		[EnumeratorCancellation] CancellationToken cancellationToken)
	{
		foreach (var project in solution.Projects)
		{
			var compilation = await project.GetCompilationAsync(cancellationToken);
			yield return new ProjectWithCompilation(project, compilation!);
		}
	}

	private sealed record class ProjectWithCompilation(Project Project, Compilation Compilation);
}