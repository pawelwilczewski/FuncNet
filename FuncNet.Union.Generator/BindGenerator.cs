namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;
using static UnionSwitchPatternMethodGenerator;

public static class BindGenerator
{
	public static string GenerateBindExtensionsFile(string @namespace, int unionSize) =>
		new SourceCodeFileBuilder(Header(@namespace))
			.AddClass(new ClassBuilder($"public static class Union{unionSize}Bind")
				.AddMethods(CreateMethodGenerationParams("Bind", unionSize, bindIndex => $"Union<{CommaSeparatedTsWithSpecialReplacement(unionSize, bindIndex, $"T{bindIndex}New")}>", "binding").SelectMany(GenerateMethods)))
			.ToString();
}