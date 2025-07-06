using System.Collections.Immutable;
using System.Composition;
using FuncNet.Shared.Common;
using FuncNet.Shared.Config;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;

namespace FuncNet.Analyzers;

[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(GenericsRegistrationCodeFixProvider))]
[Shared]
public sealed class GenericsRegistrationCodeFixProvider : CodeFixProvider
{
	public override ImmutableArray<string> FixableDiagnosticIds =>
		ImmutableArray.Create(GenericsRegistrationAnalyzer.DIAGNOSTIC_ID);

	public override FixAllProvider GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

	public override async Task RegisterCodeFixesAsync(CodeFixContext context)
	{
		var diagnostic = context.Diagnostics.First();
		if (!diagnostic.Properties.Values.Any()) return;

		var funcNetConfig = await context.Document.Project.Solution.GetFuncNetConfig(CancellationToken.None);
		if (funcNetConfig is null)
		{
			throw new InvalidOperationException(
				"FuncNet config should exist, because the diagnostic mustn't be thrown without it.");
		}

		var genericEntries = diagnostic.Properties.Values
			.Select(generics => new GenericArguments(generics!))
			.ToImmutableHashSet();

		var genericEntriesString = genericEntries.FormatGenericsToDisplayString();

		context.RegisterCodeFix(
			CodeAction.Create(
				$"Register {genericEntriesString} in {FuncNetConfig.FILE_NAME}",
				cancellationToken => AddOrUpdateConfigFileAsync(
					context.Document.Project.Solution, genericEntries, cancellationToken),
				$"{nameof(GenericsRegistrationCodeFixProvider)}_{genericEntriesString}"),
			diagnostic);
	}

	private static async Task<Solution> AddOrUpdateConfigFileAsync(
		Solution solution,
		IEnumerable<GenericArguments> genericEntries,
		CancellationToken cancellationToken)
	{
		var config = await solution.GetFuncNetConfig(cancellationToken).ConfigureAwait(false);
		if (config is null) return solution;

		var newConfig = config.WithGenericsRegistration(genericEntries);
		return newConfig.Solution;
	}
}