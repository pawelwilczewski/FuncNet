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
		Path.Join(basePath, $"Result{i}.g.cs"),
		ResultGenerator.GenerateResultFile(@namespace, i));

	UnionExtensionMethodsFileGenerationParams[] generationParams =
	[
		new("Union", @namespace, "Map", i, MapExtensionsGenerator.GenerateMethods, "union", UnionElementNamesGenerator(i), UnionGetterForUnion, UnionFactoryMethodName),
		new("Union", @namespace, "Bind", i, BindExtensionsGenerator.GenerateMethods, "union", UnionElementNamesGenerator(i), UnionGetterForUnion, UnionFactoryMethodName),
		new("Union", @namespace, "Match", i, UnionMatchExtensionsGenerator.GenerateMethods, "union", UnionElementNamesGenerator(i), UnionGetterForUnion, UnionFactoryMethodName),
		new("Result", @namespace, "Map", i, MapExtensionsGenerator.GenerateMethods, "result", ResultElementNamesGenerator(i), UnionGetterForResult, ResultFactoryMethodName),
		new("Result", @namespace, "Bind", i, BindExtensionsGenerator.GenerateMethods, "result", ResultElementNamesGenerator(i), UnionGetterForResult, ResultFactoryMethodName),
		new("Result", @namespace, "Match", i, ResultMatchExtensionsGenerator.GenerateMethods, "result", ResultElementNamesGenerator(i), UnionGetterForResult, ResultFactoryMethodName)
	];

	foreach (var p in generationParams)
	{
		File.WriteAllText(
			Path.Join(basePath, p.FileName),
			UnionExtensionMethodsFileGenerator.GenerateExtensionsFile(p));
	}

	File.WriteAllText(
		Path.Join(basePath, $"Result{i}.g.cs"),
		ResultGenerator.GenerateResultFile(@namespace, i));
}

Console.WriteLine($"Generated in {Stopwatch.GetElapsedTime(startTime)}");
return;

static Func<IEnumerable<string>> UnionElementNamesGenerator(int unionSize) =>
	() => Enumerable.Range(0, unionSize).Select(i => i.ToString());

static string UnionGetterForUnion(string argument) => argument;

static Func<IEnumerable<string>> ResultElementNamesGenerator(int unionSize) =>
	() => new[] { "Success" }.Concat(Enumerable.Range(0, unionSize - 1).Select(i => $"Error{i}"));

static string UnionGetterForResult(string argument) => $"({argument}).Value";

static string UnionFactoryMethodName(int tIndex) => $"FromT{tIndex}";
static string ResultFactoryMethodName(int tIndex) => tIndex == 0 ? "FromSuccess" : "FromError";