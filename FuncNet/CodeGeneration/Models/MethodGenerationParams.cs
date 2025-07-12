namespace FuncNet.CodeGeneration.Models;

internal record class MethodGenerationParams(
	string TypeName,
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig,
	MethodType MethodType,
	Func<IEnumerable<string>> ElementTypeNamesGenerator,
	UnionGetter GetUnionOnArgument,
	FactoryMethodNameForTIndex FactoryMethodName,
	OtherSwitchCaseReturnValue OtherSwitchCaseReturnValue)
{
	public string ThisArgumentName => MethodType is MethodType.Extension extension ? extension.ThisArgumentName : "this";

	public string MethodName => $"{MethodNameOnly}{AsyncSuffixOrEmpty}";
	public string AsyncSuffixOrEmpty => $"{(IsAsync(UnionMethodAsyncConfig.ReturnType) ? "Async" : "")}";

	public bool IsAsync(UnionMethodAsyncConfig typeToCheck) => (typeToCheck & AsyncConfig) != 0;
}

internal delegate string FactoryMethodNameForTIndex(int tIndex);

internal delegate string UnionGetter(string argument);

internal delegate string OtherSwitchCaseReturnValue(MethodGenerationParams p);

internal abstract record class MethodType
{
	internal sealed record class Extension(string ThisArgumentName) : MethodType;

	internal sealed record class Member : MethodType;
}