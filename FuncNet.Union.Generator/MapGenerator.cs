namespace FuncNet.Union.Generator;

using static MapAndBindExtensionsGenerator;

public static class MapGenerator
{
	public static string GenerateMapExtensionsFile(string @namespace, int unionSize) =>
		GenerateExtensionsFile(
				@namespace,
				new UnionMethodGroupGenerationParams(
					"Map",
					unionSize,
					index => $"T{index}New",
					"mapping"))
			.ToString();
}