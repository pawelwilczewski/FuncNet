using System.Diagnostics;
using System.Reflection;
using FuncNet.Generator;
using FuncNet.Generator.CodeGeneration.Builders;
using FuncNet.Generator.CodeGeneration.Models;
using FuncNet.Generator.ExtensionsGenerators;
using static FuncNet.Generator.CodeGeneration.Models.UnionMethodAsyncConfigConsts;

var startTime = Stopwatch.GetTimestamp();

const string @namespace = "FuncNet";

(string extendedTypeName, string thisArgumentName, Func<IEnumerable<string>> elementNamesGenerator, UnionGetter unionGetter, FactoryMethodNameForTIndex factoryMethodName, OtherSwitchCaseReturnValue defaultSwitchCaseReturnValue)[] GenerateBaseParams(int unionSize) =>
[
	("Union", "union", UnionElementNamesGenerator(unionSize), UnionGetterForUnion, UnionFactoryMethodName, ThrowOtherSwitchCaseReturnValue),
	("Result", "result", ResultElementNamesGenerator(unionSize), UnionGetterForResult, ResultFactoryMethodName, ThrowOtherSwitchCaseReturnValue)
];

(string methodNameOnly, GenerateAllMethods generateMethods, Func<UnionExtensionsFileGenerationParams, string> classDeclaration, string additionalUsings)[] methodGenerators =
[
	("Match", MatchExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
	("Map", MapExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
	("Bind", BindExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
	("Tap", TapExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
	("Filter", FilterExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
	("Zip", ZipExtensionsGenerator.GenerateMethods, StaticClassDeclaration, "using System.Collections.Generic;\nusing System.Linq;\n"),
	("Combine", ResultCombineExtensionsGenerator.GenerateMethods, PartialRecordStructDeclaration, "using System.Collections.Generic;\n"),
	("ToUnion", ResultToUnionExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
	("ToOption", ResultToOptionExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
	("Extend", ExtendExtensionsGenerator.GenerateMethods, StaticClassDeclaration, "")
];

var generationParams =
	from m in methodGenerators
	from unionSize in Enumerable.Range(2, MAX_UNION_SIZE - 1)
	from p in GenerateBaseParams(unionSize)
	where !(p.extendedTypeName == "Union" && m.methodNameOnly is "Combine" or "ToUnion" or "ToOption") // hacky
	select new UnionExtensionsFileGenerationParams(
		@namespace, m.additionalUsings, m.classDeclaration, p.extendedTypeName, m.methodNameOnly, unionSize,
		m.generateMethods, p.thisArgumentName, p.elementNamesGenerator, p.unionGetter, p.factoryMethodName, p.defaultSwitchCaseReturnValue);

generationParams =
[
	..generationParams,
	new UnionExtensionsFileGenerationParams(@namespace, "", OptionStaticClassDeclaration, "Option",
		"ToResult", 1, OptionToResultExtensionsGenerator.GenerateMethods, "option",
		() => ["Some"], _ => throw new InvalidOperationException(),
		i => i == 0 ? "FromSuccess" : "None", ThrowOtherSwitchCaseReturnValue)
];

var basePath = Path.Join(
	Path.GetFullPath(Assembly.GetExecutingAssembly().Location),
	"/../../../../../FuncNet");

Parallel.For(2, MAX_UNION_SIZE + 1, unionSize =>
{
	File.WriteAllText(
		Path.Join(basePath, $"Union{unionSize}.g.cs"),
		UnionGenerator.GenerateUnionFile(@namespace, unionSize));

	File.WriteAllText(
		Path.Join(basePath, $"Result{unionSize}.g.cs"),
		ResultGenerator.GenerateResultFile(@namespace, unionSize));
});

Parallel.ForEach(generationParams, p =>
{
	File.WriteAllText(
		Path.Join(basePath, p.FileName),
		GenerateSourceFile(p));
});

Console.WriteLine($"Generated in {Stopwatch.GetElapsedTime(startTime)}");
return;

static string GenerateSourceFile(UnionExtensionsFileGenerationParams p) =>
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

static string OptionStaticClassDeclaration(UnionExtensionsFileGenerationParams p) =>
	$"public static class {p.ExtendedTypeName}{p.MethodNameOnly}";

static string StaticClassDeclaration(UnionExtensionsFileGenerationParams p) =>
	$"public static class {p.ExtendedTypeName}{p.UnionSize}{p.MethodNameOnly}";

static string PartialRecordStructDeclaration(UnionExtensionsFileGenerationParams p) =>
	$"public readonly partial record struct {p.ExtendedTypeName}";

static Func<IEnumerable<string>> UnionElementNamesGenerator(int unionSize) =>
	() => Enumerable.Range(0, unionSize).Select(i => i.ToString());

static Func<IEnumerable<string>> ResultElementNamesGenerator(int unionSize) =>
	() => new[] { "Success" }.Concat(Enumerable.Range(0, unionSize - 1).Select(i => $"Error{i}"));

static string UnionGetterForUnion(string argument) => argument;
static string UnionGetterForResult(string argument) => $"({argument}).Value";

static string UnionFactoryMethodName(int tIndex) => $"FromT{tIndex}";
static string ResultFactoryMethodName(int tIndex) => tIndex == 0 ? "FromSuccess" : "FromError";

static string ThrowOtherSwitchCaseReturnValue(MethodGenerationParams p) => "throw new ArgumentOutOfRangeException()";