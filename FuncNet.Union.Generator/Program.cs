using System.Diagnostics;
using System.Reflection;
using FuncNet.Union.Generator;

var startTime = Stopwatch.GetTimestamp();

const int maxChoices = 8;
const string @namespace = "FuncNet.Union";

var basePath = Path.Join(
	Path.GetFullPath(Assembly.GetExecutingAssembly().Location),
	"/../../../../../FuncNet.Union");

for (var unionSize = 2; unionSize < maxChoices + 1; ++unionSize)
{
	File.WriteAllText(
		Path.Join(basePath, $"Union{unionSize}.g.cs"),
		UnionGenerator.GenerateUnionFile(@namespace, unionSize));

	File.WriteAllText(
		Path.Join(basePath, $"Result{unionSize}.g.cs"),
		ResultGenerator.GenerateResultFile(@namespace, unionSize));
}

(string methodNameOnly, GenerateAllMethods generateMethods)[] methodGenerators =
[
	("Match", MatchExtensionsGenerator.GenerateMethods),
	("Map", MapExtensionsGenerator.GenerateMethods),
	("Bind", BindExtensionsGenerator.GenerateMethods),
	("Tap", TapExtensionsGenerator.GenerateMethods)
];

var generationParams =
	from m in methodGenerators
	from unionSize in Enumerable.Range(2, maxChoices - 1)
	from p in GenerateBaseParams(unionSize)
	select new UnionExtensionMethodsFileGenerationParams(
		@namespace, p.extendedTypeName, m.methodNameOnly, unionSize, m.generateMethods, p.thisArgumentName, p.elementNamesGenerator, p.unionGetter, p.factoryMethodName);

foreach (var p in generationParams)
{
	File.WriteAllText(
		Path.Join(basePath, p.FileName),
		UnionExtensionMethodsFileGenerator.GenerateExtensionsFile(p));
}

Console.WriteLine($"Generated in {Stopwatch.GetElapsedTime(startTime)}");
return;

(string extendedTypeName, string thisArgumentName, Func<IEnumerable<string>> elementNamesGenerator, UnionGetter unionGetter, FactoryMethodNameForTIndex factoryMethodName)[] GenerateBaseParams(int unionSize) =>
[
	("Union", "union", UnionElementNamesGenerator(unionSize), UnionGetterForUnion, UnionFactoryMethodName),
	("Result", "result", ResultElementNamesGenerator(unionSize), UnionGetterForResult, ResultFactoryMethodName)
];

static Func<IEnumerable<string>> UnionElementNamesGenerator(int unionSize) =>
	() => Enumerable.Range(0, unionSize).Select(i => i.ToString());

static string UnionGetterForUnion(string argument) => argument;

static Func<IEnumerable<string>> ResultElementNamesGenerator(int unionSize) =>
	() => new[] { "Success" }.Concat(Enumerable.Range(0, unionSize - 1).Select(i => $"Error{i}"));

static string UnionGetterForResult(string argument) => $"({argument}).Value";

static string UnionFactoryMethodName(int tIndex) => $"FromT{tIndex}";
static string ResultFactoryMethodName(int tIndex) => tIndex == 0 ? "FromSuccess" : "FromError";