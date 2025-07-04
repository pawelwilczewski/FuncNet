using System.Collections.Immutable;
using System.Text.RegularExpressions;
using FuncNet.Shared.Common;
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

	private static readonly Regex typeRegex = new("(?:.*FuncNet\\.(?:Union|Result)|Extend)<(.*)>", RegexOptions.Compiled);

	private static readonly DiagnosticDescriptor rule = new(
		DIAGNOSTIC_ID,
		"Union or Result type not registered",
		"Generic Union or Result type(s) {0} is used but not registered in {1}. Consider registering it.",
		CATEGORY,
		DiagnosticSeverity.Warning,
		true,
		$"Union and Result types and Extend calls should be registered in {FuncNetConfig.FILE_NAME} file to enable source"
		+ " generation of implicit conversions.");

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
		IImmutableSet<GenericArguments> registeredTypes)
	{
		var genericNameNode = (GenericNameSyntax)context.Node;
		var semanticModel = context.SemanticModel;

		var symbol = semanticModel.GetSymbolInfo(genericNameNode, context.CancellationToken).Symbol;
		var symbolName = symbol switch
		{
			INamedTypeSymbol { IsGenericType: true } namedTypeSymbol =>
				namedTypeSymbol.ConstructedFrom.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
			IMethodSymbol { IsGenericMethod: true } methodSymbol =>
				methodSymbol.ConstructedFrom.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
			_ => null
		};

		if (symbolName is null || !typeRegex.IsMatch(symbolName)) return;

		IEnumerable<string> genericArgs = symbol switch
		{
			INamedTypeSymbol namedTypeSymbol =>
				[namedTypeSymbol.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat).UnwrapGenericArgs()],
			IMethodSymbol methodSymbol =>
			[
				methodSymbol.ReceiverType!.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat).UnwrapTaskGenericArg().UnwrapGenericArgs(),
				methodSymbol.ReturnType.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat).UnwrapTaskGenericArg().UnwrapGenericArgs()
			],
			_ => throw new ArgumentOutOfRangeException(nameof(symbol))
		};

		var genericEntries = genericArgs
			.Select(args => new GenericArguments(args))
			.ToImmutableHashSet();

		if (registeredTypes.IsSupersetOf(genericEntries)) return;

		var properties = genericEntries
			.Select((args, index) => (index, generics: args))
			.ToImmutableDictionary(
				args => args.index.ToString(),
				args => args.generics.CommaSeparatedArguments);

		var diagnostic = Diagnostic.Create(
			rule,
			genericNameNode.Identifier.GetLocation(),
			properties!,
			genericEntries.FormatGenericsToDisplayString(),
			FuncNetConfig.FILE_NAME);

		context.ReportDiagnostic(diagnostic);
	}
}