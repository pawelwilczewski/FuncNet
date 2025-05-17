namespace FuncNet.Union.Generator;

internal static class UnionExtensionMethodsFileGenerator
{
	public static string GenerateExtensionsFile(UnionExtensionMethodsFileGenerationParams p) =>
		new SourceCodeFileBuilder(
				$@"using System;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace {p.Namespace};")
			.AddClass(new ClassBuilder($"public static class {p.ExtendedTypeName}{p.UnionSize}{p.MethodNameOnly}")
				.AddMethods(p.GenerateAllMethods(p)))
			.ToString();
}