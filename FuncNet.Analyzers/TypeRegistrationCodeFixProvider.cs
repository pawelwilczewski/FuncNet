using System.Collections.Immutable;
using System.Composition;
using FuncNet.Shared.Config;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;

namespace FuncNet.Analyzers;

[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(TypeRegistrationCodeFixProvider))]
[Shared]
public sealed class TypeRegistrationCodeFixProvider : CodeFixProvider
{
	public override ImmutableArray<string> FixableDiagnosticIds =>
		ImmutableArray.Create(TypeRegistrationAnalyzer.DIAGNOSTIC_ID);

	public override FixAllProvider GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

	public override async Task RegisterCodeFixesAsync(CodeFixContext context)
	{
		var diagnostic = context.Diagnostics.First();
		if (!diagnostic.Properties.TryGetValue(TypeRegistrationAnalyzer.TYPE_PROPERTY_NAME, out var typeName)
			|| string.IsNullOrEmpty(typeName))
		{
			return;
		}

		var funcNetConfig = await context.Document.Project.Solution.GetFuncNetConfig(CancellationToken.None);
		if (funcNetConfig is null) throw new InvalidOperationException("FuncNet config should exist, because the diagnostic mustn't be thrown without it.");

		var typeEntry = new TypeEntry(typeName!);
		if (funcNetConfig.Content.TypeRegistrations.Contains(typeEntry)) return;

		context.RegisterCodeFix(
			CodeAction.Create(
				$"Register '{typeName}' in {FuncNetConfig.FILE_NAME}",
				cancellationToken => AddOrUpdateConfigFileAsync(
					context.Document.Project.Solution, typeEntry, cancellationToken),
				$"{nameof(TypeRegistrationCodeFixProvider)}_{typeEntry}"),
			diagnostic);
	}

	private static async Task<Solution> AddOrUpdateConfigFileAsync(
		Solution solution,
		TypeEntry typeEntry,
		CancellationToken cancellationToken)
	{
		var config = await solution.GetFuncNetConfig(cancellationToken).ConfigureAwait(false);
		if (config is null) return solution;

		var newConfig = config.WithTypeRegistration(typeEntry);
		return newConfig.Solution;
	}
}