namespace FuncNet.CodeGeneration.Models;

internal record class MethodGenerationParamsWithSpecialIndex(
	string ExtendedTypeName,
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig,
	MethodType MethodType,
	Func<IEnumerable<string>> ElementTypeNamesGenerator,
	UnionGetter GetUnionOnArgument,
	FactoryMethodNameForTIndex FactoryMethodName,
	OtherSwitchCaseReturnValue OtherSwitchCaseReturnValue,
	int SpecialIndex) : MethodGenerationParams(
	ExtendedTypeName, MethodNameOnly, UnionSize, AsyncConfig, MethodType, ElementTypeNamesGenerator,
	GetUnionOnArgument, FactoryMethodName, OtherSwitchCaseReturnValue);