using System.Collections.Immutable;
using System.Composition;
using FuncNet.Analyzers.Config;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;

namespace FuncNet.Analyzers;

[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(UnionRegistrationCodeFixProvider))]
[Shared]
public sealed class UnionRegistrationCodeFixProvider : CodeFixProvider
{
	public override ImmutableArray<string> FixableDiagnosticIds =>
		ImmutableArray.Create(UnionRegistrationAnalyzer.DIAGNOSTIC_ID);

	public override FixAllProvider GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

	public override Task RegisterCodeFixesAsync(CodeFixContext context)
	{
		var diagnostic = context.Diagnostics.First();
		if (!diagnostic.Properties.TryGetValue(UnionRegistrationAnalyzer.UNION_TYPE_PROPERTY_NAME, out var unionTypeString)
			|| string.IsNullOrEmpty(unionTypeString))
		{
			return Task.CompletedTask;
		}

		context.RegisterCodeFix(
			CodeAction.Create(
				$"Register '{unionTypeString}' in {FuncNetConfig.FILE_NAME}",
				cancellationToken => AddOrUpdateUnionRegistrationFileAsync(
					context.Document.Project.Solution, unionTypeString!, cancellationToken),
				nameof(UnionRegistrationCodeFixProvider) + "_" + unionTypeString),
			diagnostic);

		return Task.CompletedTask;
	}

	private static async Task<Solution> AddOrUpdateUnionRegistrationFileAsync(
		Solution solution,
		string unionTypeName,
		CancellationToken cancellationToken)
	{
		var config = await solution.GetOrCreateFuncNetConfig(default).ConfigureAwait(false);
		var newConfig = config.WithUnionRegistration(new UnionRegistration(unionTypeName));
		return newConfig.Solution;
	}
}