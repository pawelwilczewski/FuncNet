using System.Diagnostics;
using System.Reflection;
using FuncNet.Union.Generator;

var startTime = Stopwatch.GetTimestamp();

const int maxChoices = 8;
const string @namespace = "FuncNet.Union";

for (var i = 2; i < maxChoices + 1; ++i)
{
	var basePath = Path.Join(
		Path.GetFullPath(Assembly.GetExecutingAssembly().Location),
		"/../../../../../FuncNet.Union");

	File.WriteAllText(
		Path.Join(basePath, $"Union{i}.g.cs"),
		UnionGenerator.GenerateUnionFile(@namespace, i));

	UnionExtensionMethodsFileGenerationParams[] generationParams =
	[
		new(@namespace, "Map", i, MapExtensionsGenerator.GenerateMethods),
		new(@namespace, "Bind", i, BindExtensionsGenerator.GenerateMethods),
		new(@namespace, "Match", i, MatchExtensionsGenerator.GenerateMethods)
	];

	foreach (var p in generationParams)
	{
		File.WriteAllText(
			Path.Join(basePath, p.FileName),
			UnionExtensionMethodsFileGenerator.GenerateExtensionsFile(p));
	}
}

Console.WriteLine($"Generated in {Stopwatch.GetElapsedTime(startTime)}");
