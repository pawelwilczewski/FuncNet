namespace FuncNet.Union.Generator.CodeGeneration.Models;

internal record class MethodGenerationParamsWithSpecialIndex(
	string ExtendedTypeName,
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig,
	string ThisArgumentName,
	Func<IEnumerable<string>> ElementTypeNamesGenerator,
	UnionGetter GetUnionOnArgument,
	FactoryMethodNameForTIndex FactoryMethodName,
	OtherSwitchCaseReturnValue OtherSwitchCaseReturnValue,
	int SpecialIndex) : MethodGenerationParams(
	ExtendedTypeName, MethodNameOnly, UnionSize, AsyncConfig, ThisArgumentName, ElementTypeNamesGenerator,
	GetUnionOnArgument, FactoryMethodName, OtherSwitchCaseReturnValue);