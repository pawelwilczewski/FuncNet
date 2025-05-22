namespace FuncNet.Union.Generator.CodeGeneration.Models;

internal record class MethodGenerationParamsWithOtherCaseSize(
	string ExtendedTypeName,
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig,
	string ThisArgumentName,
	UnionGetter GetUnionOnArgument,
	FactoryMethodNameForTIndex FactoryMethodName,
	Func<IEnumerable<string>> ElementTypeNamesGenerator,
	OtherSwitchCaseReturnValue OtherSwitchCaseReturnValue,
	int OtherCaseSize) : MethodGenerationParams(ExtendedTypeName, MethodNameOnly, UnionSize, AsyncConfig, ThisArgumentName, ElementTypeNamesGenerator, GetUnionOnArgument, FactoryMethodName, OtherSwitchCaseReturnValue);