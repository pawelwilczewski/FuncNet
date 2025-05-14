namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;
using static UnionSwitchPatternMethodGenerator;

public static class BindGenerator
{
	public static string GenerateBindExtensionsFile(string @namespace, int unionSize) =>
		GenerateExtensionsFile(
			@namespace,
			new MethodGroupGenerationParams(
				"Bind",
				unionSize,
				bindIndex => UnionOfTsOneNew(unionSize, bindIndex),
				"binding"))
		.ToString();
}