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

	File.WriteAllText(
		Path.Join(basePath, $"Union{i}.Match.g.cs"),
		MatchExtensionsGenerator.GenerateMatchExtensionsFile(
			new ExtensionsFileGenerationParams(@namespace, "Match", i)));

	File.WriteAllText(
		Path.Join(basePath, $"Union{i}.Map.g.cs"),
		MapExtensionsGenerator.GenerateMapExtensionsFile(
			new ExtensionsFileGenerationParams(@namespace, "Map", i)));

	File.WriteAllText(
		Path.Join(basePath, $"Union{i}.Bind.g.cs"),
		BindExtensionsGenerator.GenerateBindExtensionsFile(
			new ExtensionsFileGenerationParams(@namespace, "Bind", i)));
}

Console.WriteLine($"Generated in {Stopwatch.GetElapsedTime(startTime)}");