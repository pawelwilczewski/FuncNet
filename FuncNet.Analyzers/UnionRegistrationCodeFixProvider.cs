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

	public override async Task RegisterCodeFixesAsync(CodeFixContext context)
	{
		var diagnostic = context.Diagnostics.First();
		if (!diagnostic.Properties.TryGetValue(UnionRegistrationAnalyzer.UNION_TYPE_PROPERTY_NAME, out var unionTypeString)
			|| string.IsNullOrEmpty(unionTypeString))
		{
			return;
		}

		var funcNetConfig = await context.Document.Project.Solution.GetFuncNetConfig(CancellationToken.None);
		if (funcNetConfig is null) throw new InvalidOperationException("FuncNet config should exist, because the diagnostic mustn't be thrown without it.");

		var unionTypeEntry = new TypeEntry(unionTypeString!);
		if (funcNetConfig.Content.UnionRegistrations.Contains(unionTypeEntry)) return;

		context.RegisterCodeFix(
			CodeAction.Create(
				$"Register '{unionTypeString}' in {FuncNetConfig.FILE_NAME}",
				cancellationToken => AddOrUpdateUnionRegistrationFileAsync(
					context.Document.Project.Solution, unionTypeEntry, cancellationToken),
				$"{nameof(UnionRegistrationCodeFixProvider)}_{unionTypeEntry}"),
			diagnostic);
	}

	private static async Task<Solution> AddOrUpdateUnionRegistrationFileAsync(
		Solution solution,
		TypeEntry unionType,
		CancellationToken cancellationToken)
	{
		var config = await solution.GetFuncNetConfig(cancellationToken).ConfigureAwait(false);
		if (config is null) return solution;

		var newConfig = config.WithUnionRegistration(unionType);
		return newConfig.Solution;
	}
}