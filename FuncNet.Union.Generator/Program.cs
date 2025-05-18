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

(string methodNameOnly, GenerateAllMethods generateMethods, Func<UnionExtensionMethodsFileGenerationParams, string> classDeclaration, string additionalUsings)[] methodGenerators =
[
	("Match", MatchExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
	("Map", MapExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
	("Bind", BindExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
	("Tap", TapExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
	("Ensure", EnsureExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
	("Combine", CombineExtensionsGenerator.GenerateMethods, PartialRecordStructDeclaration, "using System.Collections.Generic;\n")
];

var generationParams =
	from m in methodGenerators
	from unionSize in Enumerable.Range(2, maxChoices - 1)
	from p in GenerateBaseParams(unionSize)
	where !(p.extendedTypeName == "Union" && m.methodNameOnly == "Combine") // hacky don't generate Combine for Union
	select new UnionExtensionMethodsFileGenerationParams(
		@namespace, m.additionalUsings, m.classDeclaration, p.extendedTypeName, m.methodNameOnly, unionSize,
		m.generateMethods, p.thisArgumentName, p.elementNamesGenerator, p.unionGetter, p.factoryMethodName);

foreach (var p in generationParams)
{
	File.WriteAllText(
		Path.Join(basePath, p.FileName),
		GenerateSourceFile(p));
}

Console.WriteLine($"Generated in {Stopwatch.GetElapsedTime(startTime)}");
return;

static string GenerateSourceFile(UnionExtensionMethodsFileGenerationParams p) =>
	new SourceCodeFileBuilder(
			$@"using System;
using System.Threading;
using System.Threading.Tasks;
{p.AdditionalUsings}
#nullable enable

namespace {p.Namespace};")
		.AddClass(new ClassBuilder(p.ClassDeclaration(p))
			.AddMethods(p.GenerateAllMethods(p)))
		.ToString();

static string StaticClassDeclaration(UnionExtensionMethodsFileGenerationParams p) =>
	$"public static class {p.ExtendedTypeName}{p.UnionSize}{p.MethodNameOnly}";

static string PartialRecordStructDeclaration(UnionExtensionMethodsFileGenerationParams p) =>
	$"public readonly partial record struct {p.ExtendedTypeName}";

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