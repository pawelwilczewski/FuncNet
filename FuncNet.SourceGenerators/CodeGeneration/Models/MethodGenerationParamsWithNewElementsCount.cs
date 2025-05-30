namespace FuncNet.SourceGenerators.CodeGeneration.Models;

internal record class MethodGenerationParamsWithNewElementsCount(
	string ExtendedTypeName,
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig,
	string ThisArgumentName,
	Func<IEnumerable<string>> ElementTypeNamesGenerator,
	UnionGetter GetUnionOnArgument,
	FactoryMethodNameForTIndex FactoryMethodName,
	OtherSwitchCaseReturnValue OtherSwitchCaseReturnValue,
	int NewElementsCount) : MethodGenerationParams(ExtendedTypeName, MethodNameOnly, UnionSize, AsyncConfig, ThisArgumentName, ElementTypeNamesGenerator, GetUnionOnArgument, FactoryMethodName, OtherSwitchCaseReturnValue);