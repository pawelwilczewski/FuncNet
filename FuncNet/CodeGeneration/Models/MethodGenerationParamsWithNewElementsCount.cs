namespace FuncNet.CodeGeneration.Models;

internal record class MethodGenerationParamsWithNewElementsCount(
	string TypeName,
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig,
	MethodType MethodType,
	Func<IEnumerable<string>> ElementTypeNamesGenerator,
	UnionGetter GetUnionOnArgument,
	FactoryMethodNameForTIndex FactoryMethodName,
	OtherSwitchCaseReturnValue OtherSwitchCaseReturnValue,
	int NewElementsCount) : MethodGenerationParams(TypeName, MethodNameOnly, UnionSize, AsyncConfig, MethodType, ElementTypeNamesGenerator, GetUnionOnArgument, FactoryMethodName, OtherSwitchCaseReturnValue);