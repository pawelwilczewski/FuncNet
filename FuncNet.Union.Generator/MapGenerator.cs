namespace FuncNet.Union.Generator;

using static CodeGenerationUtils;
using static UnionSwitchPatternMethodGenerator;

public static class MapGenerator
{
	public static string GenerateMapExtensionsFile(string @namespace, int unionSize) =>
		new SourceCodeFileBuilder(Header(@namespace))
			.AddClass(new ClassBuilder($"public static class Union{unionSize}Map")
				.AddMethods(Params("Map", unionSize, mapIndex => $"T{mapIndex}New", "mapping").SelectMany(GenerateMethods)))
			.ToString();
}