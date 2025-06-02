using Microsoft.CodeAnalysis;

namespace FuncNet.CodeGeneration;

internal static class SourceGeneratorExtensions
{
	public static void AddSourceIfNotExists(this GeneratorExecutionContext context, string hintName, string source)
	{
		var shouldAdd = context.Compilation.ReferencedAssemblyNames
			.Any(assemblyIdentity => assemblyIdentity.Name.Equals("FuncNet", StringComparison.OrdinalIgnoreCase));

		if (shouldAdd)
		{
			context.AddSource(hintName, source);
		}
	}
}