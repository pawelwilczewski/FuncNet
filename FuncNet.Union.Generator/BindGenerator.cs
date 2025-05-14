namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;
using static MapAndBindExtensionsGenerator;

public static class BindGenerator
{
	public static string GenerateBindExtensionsFile(string @namespace, int unionSize) =>
		GenerateExtensionsFile(
			@namespace,
			new UnionMethodGroupGenerationParams(
				"Bind",
				unionSize,
				bindIndex => UnionOfTsOneNew(unionSize, bindIndex),
				"binding"))
		.ToString();
}