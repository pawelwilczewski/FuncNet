using System.Collections.Immutable;
using System.Text.RegularExpressions;
using FuncNet.Analyzers.Config;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace FuncNet.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
internal sealed class UnionRegistrationAnalyzer : DiagnosticAnalyzer
{
	public const string DIAGNOSTIC_ID = "FN0002";
	private const string CATEGORY = nameof(FuncNet);

	public const string UNION_TYPE_PROPERTY_NAME = "UnionTypeString";

	private static readonly Regex unionTypeRegex = new(".*FuncNet.Union<(.*)>", RegexOptions.Compiled);

	private static readonly DiagnosticDescriptor rule = new(
		DIAGNOSTIC_ID,
		"Union type not registered",
		"The Union type '{0}' is used but not registered in {1}. Consider registering it.",
		CATEGORY,
		DiagnosticSeverity.Warning,
		true,
		$"Union types should be registered in {FuncNetConfig.FILE_NAME} file to enable source generation of necessary conversions/helpers.");

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
			context => AnalyzeGenericNameSyntax(context, funcNetConfig.UnionRegistrations),
			SyntaxKind.GenericName);
	}

	private static void AnalyzeGenericNameSyntax(
		SyntaxNodeAnalysisContext context,
		IReadOnlyCollection<TypeEntry> registeredUnions)
	{
		var genericNameNode = (GenericNameSyntax)context.Node;
		var semanticModel = context.SemanticModel;

		var symbol = semanticModel.GetSymbolInfo(genericNameNode, context.CancellationToken).Symbol;
		if (symbol is not INamedTypeSymbol namedTypeSymbol
			|| !unionTypeRegex.IsMatch(
				namedTypeSymbol.ConstructedFrom.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat))
			|| !namedTypeSymbol.IsGenericType)
		{
			return;
		}

		var unionTypeEntry = new TypeEntry(namedTypeSymbol.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat));
		if (registeredUnions.Contains(unionTypeEntry)) return;

		var properties = ImmutableDictionary<string, string?>.Empty
			.Add(UNION_TYPE_PROPERTY_NAME, unionTypeEntry.TypeName);

		var diagnostic = Diagnostic.Create(
			rule,
			genericNameNode.Identifier.GetLocation(),
			properties,
			unionTypeEntry,
			FuncNetConfig.FILE_NAME);

		context.ReportDiagnostic(diagnostic);
	}
}