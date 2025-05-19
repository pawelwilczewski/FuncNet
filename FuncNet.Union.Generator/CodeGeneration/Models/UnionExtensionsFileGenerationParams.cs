using FuncNet.Union.Generator.CodeGeneration.Builders;

namespace FuncNet.Union.Generator.CodeGeneration.Models;

internal sealed record class UnionExtensionsFileGenerationParams(
	string Namespace,
	string AdditionalUsings,
	Func<UnionExtensionsFileGenerationParams, string> ClassDeclaration,
	string ExtendedTypeName,
	string MethodNameOnly,
	int UnionSize,
	GenerateAllMethods GenerateAllMethods,
	string ThisArgumentName,
	Func<IEnumerable<string>> ElementTypeNamesGenerator,
	UnionGetter GetUnionOnArgument,
	FactoryMethodNameForTIndex FactoryMethodName)
{
	public string FileName => $"{ExtendedTypeName}{UnionSize}.{MethodNameOnly}.g.cs";
}

internal delegate IEnumerable<MethodBuilder> GenerateAllMethods(UnionExtensionsFileGenerationParams p);