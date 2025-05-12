using System.Reflection;
using FuncNet.Union.Generator;

const int maxChoices = 8;
const string @namespace = "FuncNet.Union";

for (var i = 1; i < maxChoices + 1; ++i)
{
	var basePath = Path.Join(
		Path.GetFullPath(Assembly.GetExecutingAssembly().Location),
		"/../../../../../FuncNet.Union");
	
	File.WriteAllText(
		Path.Join(basePath, $"Union{i}.g.cs"),
		UnionGenerator.GenerateUnionFile(@namespace, i));

	File.WriteAllText(
		Path.Join(basePath, $"Union{i}.Match.g.cs"),
		MatchGenerator.GenerateMatchExtensionsFile(@namespace, i));
}