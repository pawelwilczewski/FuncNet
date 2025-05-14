namespace FuncNet.Union.Generator;

using static UnionSwitchPatternMethodGenerator;

public static class MapGenerator
{
	public static string GenerateMapExtensionsFile(string @namespace, int unionSize) =>
		GenerateExtensionsFile(
				@namespace,
				new MethodGroupGenerationParams(
					"Map",
					unionSize,
					index => $"T{index}New",
					"mapping"))
			.ToString();
}