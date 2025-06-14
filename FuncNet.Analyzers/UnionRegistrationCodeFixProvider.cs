using System.Collections.Immutable;
using System.Composition;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;

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
		string unionTypeStringToAdd,
		CancellationToken cancellationToken)
	{
		var rootProject = await GetRootProject(solution, cancellationToken);
		if (rootProject == null) return solution;

		var funcNetFileConfig = await FuncNetConfigFile.GetOrCreate(
			rootProject, FuncNetConfigFile.FILE_NAME, cancellationToken);

		var newCommentText = $"// {unionTypeStringToAdd}";
		if (funcNetFileConfig.SyntaxRoot.DescendantTrivia()
			.Any(t => t.IsKind(SyntaxKind.SingleLineCommentTrivia)
				&& t.ToString().Trim() == newCommentText.Trim()))
		{
			return solution;
		}

		var funcNetNamespace = funcNetFileConfig.SyntaxRoot.DescendantNodes()
			.OfType<NamespaceDeclarationSyntax>()
			.FirstOrDefault(n => n.Name.ToString() == nameof(FuncNet));

		var newCommentTriviaWithLineEnding = SyntaxFactory.TriviaList(
			SyntaxFactory.Comment(newCommentText),
			SyntaxFactory.CarriageReturnLineFeed);

		if (funcNetNamespace != null)
		{
			var closeBrace = funcNetNamespace.CloseBraceToken;
			var newLeadingTrivia = closeBrace.LeadingTrivia.AddRange(newCommentTriviaWithLineEnding);
			var newCloseBrace = closeBrace.WithLeadingTrivia(newLeadingTrivia);
			var updatedNamespace = funcNetNamespace.WithCloseBraceToken(newCloseBrace);
			funcNetFileConfig = funcNetFileConfig.WithSyntaxRoot(root =>
				root.ReplaceNode(funcNetNamespace, updatedNamespace));
		}
		else
		{
			funcNetNamespace = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(nameof(FuncNet)))
				.WithOpenBraceToken(SyntaxFactory.Token(SyntaxKind.OpenBraceToken))
				.WithCloseBraceToken(
					SyntaxFactory.Token(SyntaxKind.CloseBraceToken)
						.WithLeadingTrivia(newCommentTriviaWithLineEnding));
			funcNetFileConfig = funcNetFileConfig.WithSyntaxRoot(root =>
				root.AddMembers(funcNetNamespace));
		}

		funcNetFileConfig = funcNetFileConfig.WithSyntaxRoot(root =>
			(CompilationUnitSyntax)Formatter.Format(
				root, solution.Workspace, solution.Workspace.Options, cancellationToken));

		return funcNetFileConfig.Document.Project.Solution;
	}

	private static async Task<Project?> GetRootProject(Solution solution, CancellationToken cancellationToken) =>
		(await AllProjectsWithCompilationFromSolution(solution, cancellationToken)
			.FirstOrDefaultAsync(HasReferenceToFuncNet, cancellationToken))?.Project;

	private static bool HasReferenceToFuncNet(ProjectWithCompilation project)
	{
		return project.Compilation.ReferencedAssemblyNames.Any(assembly => assembly.Name == nameof(FuncNet));
	}

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

	private sealed record class ConfigFileInfo(
		CompilationUnitSyntax CompilationRoot,
		DocumentId Id,
		Document? Document);
}