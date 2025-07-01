using System.Collections.Immutable;
using FuncNet.Analyzers.Config;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace FuncNet.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
internal sealed class RequireConfigFileAnalyzer : DiagnosticAnalyzer
{
	public const string DIAGNOSTIC_ID = "FN0001";
	private const string CATEGORY = nameof(FuncNet);

	private static readonly DiagnosticDescriptor rule = new(
		DIAGNOSTIC_ID,
		"FuncNet configuration file missing",
		$"FuncNet configuration file '{FuncNetConfig.FILE_NAME}' is missing. Create this file in your project to enable FuncNet features. "
		+ "You need to add an AdditionalFile entry to your .csproj in order for the config to be recognized by the analyzer.",
		CATEGORY,
		DiagnosticSeverity.Error,
		true,
		$"FuncNet requires a {FuncNetConfig.FILE_NAME} file to function properly.");

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(rule);

	public override void Initialize(AnalysisContext context)
	{
		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
		context.EnableConcurrentExecution();

		context.RegisterCompilationAction(AnalyzeCompilation);
	}

	private static void AnalyzeCompilation(CompilationAnalysisContext context)
	{
		var configExists = context.Options.AdditionalFiles
			.Any(file => file.Path.EndsWith(FuncNetConfig.FILE_NAME));
		if (configExists) return;

		var diagnostic = Diagnostic.Create(
			rule,
			Location.None);
		context.ReportDiagnostic(diagnostic);
	}
}