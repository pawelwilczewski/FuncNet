namespace FuncNet.CodeGeneration.Models;

internal record class MethodGenerationParamsWithOptionsCount(
	string TypeName,
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig,
	MethodType MethodType,
	Func<IEnumerable<string>> ElementTypeNamesGenerator,
	UnionGetter GetUnionOnArgument,
	FactoryMethodNameForTIndex FactoryMethodName,
	OtherSwitchCaseReturnValue OtherSwitchCaseReturnValue,
	int OptionsCount) : MethodGenerationParams(TypeName, MethodNameOnly, UnionSize, AsyncConfig, MethodType, ElementTypeNamesGenerator, GetUnionOnArgument, FactoryMethodName, OtherSwitchCaseReturnValue);