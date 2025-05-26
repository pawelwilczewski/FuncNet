using FuncNet.Generator.CodeGeneration.Builders;

namespace FuncNet.Generator.CodeGeneration.Models;

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
	FactoryMethodNameForTIndex FactoryMethodName,
	OtherSwitchCaseReturnValue OtherSwitchCaseReturnValue)
{
	// hacky don't state union size for Option this can be easily fixed \/\/\/\/ via strategy but not worth it for now
	public string FileName => $"{ExtendedTypeName}{(ExtendedTypeName == "Option" ? "" : UnionSize)}.{MethodNameOnly}";
}

internal delegate IEnumerable<MethodBuilder> GenerateAllMethods(UnionExtensionsFileGenerationParams p);