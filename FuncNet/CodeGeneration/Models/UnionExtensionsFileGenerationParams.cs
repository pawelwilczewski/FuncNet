using FuncNet.CodeGeneration.Builders;

namespace FuncNet.CodeGeneration.Models;

internal sealed record class UnionExtensionsFileGenerationParams(
	string Namespace,
	string AdditionalUsings,
	Func<UnionExtensionsFileGenerationParams, string> ClassDeclaration,
	string TypeName,
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
	public string FileName => $"{TypeName}{(TypeName == "Option" ? "" : UnionSize)}.{MethodNameOnly}";
}

internal delegate IEnumerable<MethodBuilder> GenerateAllMethods(UnionExtensionsFileGenerationParams p);