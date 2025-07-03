using System.Collections.Immutable;
using System.Text.RegularExpressions;
using FuncNet.Shared.Config;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace FuncNet.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
internal sealed class TypeRegistrationAnalyzer : DiagnosticAnalyzer
{
	public const string DIAGNOSTIC_ID = "FN0002";
	private const string CATEGORY = nameof(FuncNet);

	public const string TYPE_PROPERTY_NAME = "TypeName";

	private static readonly Regex typeRegex = new(".*FuncNet\\.(Union|Result)<(.*)>", RegexOptions.Compiled);

	private static readonly DiagnosticDescriptor rule = new(
		DIAGNOSTIC_ID,
		"Union or Result type not registered",
		"The type '{0}' is used but not registered in {1}. Consider registering it.",
		CATEGORY,
		DiagnosticSeverity.Warning,
		true,
		$"Union and Result types should be registered in {FuncNetConfig.FILE_NAME} file to enable source"
		+ " generation of necessary implicit conversions.");

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(rule);

	public override void Initialize(AnalysisContext context)
	{
		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
		context.EnableConcurrentExecution();
		context.RegisterCompilationStartAction(CompilationStart);
	}

	private static void CompilationStart(CompilationStartAnalysisContext compilationStartContext)
	{
		var funcNetConfig = compilationStartContext.Options.GetFuncNetConfig();
		if (funcNetConfig is null) return;

		compilationStartContext.RegisterSyntaxNodeAction(
			context => AnalyzeGenericNameSyntax(context, funcNetConfig.TypeRegistrations),
			SyntaxKind.GenericName);
	}

	private static void AnalyzeGenericNameSyntax(
		SyntaxNodeAnalysisContext context,
		IReadOnlyCollection<TypeEntry> registeredTypes)
	{
		var genericNameNode = (GenericNameSyntax)context.Node;
		var semanticModel = context.SemanticModel;

		var symbol = semanticModel.GetSymbolInfo(genericNameNode, context.CancellationToken).Symbol;
		if (symbol is not INamedTypeSymbol namedTypeSymbol
			|| !typeRegex.IsMatch(
				namedTypeSymbol.ConstructedFrom.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat))
			|| !namedTypeSymbol.IsGenericType)
		{
			return;
		}

		var typeEntry = new TypeEntry(namedTypeSymbol.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat));
		if (registeredTypes.Contains(typeEntry)) return;

		var properties = ImmutableDictionary<string, string?>.Empty
			.Add(TYPE_PROPERTY_NAME, typeEntry.TypeName);

		var diagnostic = Diagnostic.Create(
			rule,
			genericNameNode.Identifier.GetLocation(),
			properties,
			typeEntry,
			FuncNetConfig.FILE_NAME);

		context.ReportDiagnostic(diagnostic);
	}
}