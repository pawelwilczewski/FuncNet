using System.Collections.Immutable;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace FuncNet.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
internal sealed class UnionRegistrationAnalyzer : DiagnosticAnalyzer
{
	public const string DIAGNOSTIC_ID = "FN0001";
	private const string CATEGORY = nameof(FuncNet);
	private const string CONFIG_PROJECT_NAME = "Root";

	private static readonly Regex unionTypeRegex = new(".*FuncNet.Union<(.*)>", RegexOptions.Compiled);

	private static readonly DiagnosticDescriptor rule = new(
		DIAGNOSTIC_ID,
		"Union type not registered",
		"The Union type '{0}' is used but not registered in {1}/{2}. Consider registering it.",
		CATEGORY,
		DiagnosticSeverity.Warning,
		true,
		$"Union types should be registered in the {CONFIG_PROJECT_NAME} project's _UnionConversions.cs file to enable source generation of necessary conversions/helpers.");

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(rule);

	public override void Initialize(AnalysisContext context)
	{
		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
		context.EnableConcurrentExecution();
		context.RegisterCompilationStartAction(CompilationStart);
	}

	private void CompilationStart(CompilationStartAnalysisContext compilationStartContext)
	{
		var registeredUnionStrings = new HashSet<string>();

		compilationStartContext.RegisterSyntaxNodeAction(
			context => AnalyzeGenericNameSyntax(context, registeredUnionStrings),
			SyntaxKind.GenericName);
	}

	private static void AnalyzeGenericNameSyntax(
		SyntaxNodeAnalysisContext context,
		HashSet<string> registeredUnions)
	{
		var genericNameNode = (GenericNameSyntax)context.Node;
		var semanticModel = context.SemanticModel;

		var symbol = semanticModel.GetSymbolInfo(genericNameNode, context.CancellationToken).Symbol;

		if (symbol is INamedTypeSymbol namedTypeSymbol
			&& unionTypeRegex.IsMatch(namedTypeSymbol.ConstructedFrom
				.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat))
			&& namedTypeSymbol.IsGenericType)
		{
			var unionTypeDisplayString = namedTypeSymbol.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat);

			if (!registeredUnions.Contains(unionTypeDisplayString))
			{
				var properties = ImmutableDictionary<string, string?>.Empty
					.Add("UnionTypeString", unionTypeDisplayString);

				var diagnostic = Diagnostic.Create(
					rule,
					genericNameNode.Identifier.GetLocation(),
					properties,
					unionTypeDisplayString,
					CONFIG_PROJECT_NAME,
					FuncNetConfigFile.FILE_NAME);
				context.ReportDiagnostic(diagnostic);
			}
		}
	}
}