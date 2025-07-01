using System.Collections.Immutable;
using System.Composition;
using FuncNet.Analyzers.Config;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;

namespace FuncNet.Analyzers;

[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(RequireConfigFileCodeFixProvider))]
[Shared]
public sealed class RequireConfigFileCodeFixProvider : CodeFixProvider
{
	public override ImmutableArray<string> FixableDiagnosticIds =>
		ImmutableArray.Create(RequireConfigFileAnalyzer.DIAGNOSTIC_ID);

	public override FixAllProvider GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

	public override Task RegisterCodeFixesAsync(CodeFixContext context)
	{
		var diagnostic = context.Diagnostics.First(d => d.Id == RequireConfigFileAnalyzer.DIAGNOSTIC_ID);

		context.RegisterCodeFix(
			CodeAction.Create(
				$"Create {FuncNetConfig.FILE_NAME}",
				_ => CreateFuncNetConfigAsync(context.Document.Project),
				nameof(RequireConfigFileCodeFixProvider)),
			diagnostic);
		return Task.CompletedTask;
	}

	private static Task<Solution> CreateFuncNetConfigAsync(Project project) =>
		Task.FromResult(FuncNetConfig.CreateInProject(project, new FuncNetConfigFileContent()));
}