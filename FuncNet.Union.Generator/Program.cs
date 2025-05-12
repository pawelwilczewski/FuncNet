using System.Reflection;
using FuncNet.Union.Generator;

const int maxChoices = 8;

for (var i = 1; i < maxChoices + 1; ++i)
{
	var path = Path.Join(
		Path.GetFullPath(Assembly.GetExecutingAssembly().Location),
		"/../../../../../FuncNet.Union",
		$"Union{i}.g.cs");

	var code = UnionGenerator.GenerateUnionFile("FuncNet.Union", i);

	File.WriteAllText(path, code);
}