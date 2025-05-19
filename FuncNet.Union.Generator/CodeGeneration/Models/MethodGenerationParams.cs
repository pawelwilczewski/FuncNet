namespace FuncNet.Union.Generator.CodeGeneration.Models;

internal record class MethodGenerationParams(
	string ExtendedTypeName,
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig,
	string ThisArgumentName,
	UnionGetter GetUnionOnArgument,
	FactoryMethodNameForTIndex FactoryMethodName,
	Func<IEnumerable<string>> ElementTypeNamesGenerator)
{
	public bool IsAsync(UnionMethodAsyncConfig typeToCheck) => (typeToCheck & AsyncConfig) != 0;
}

internal delegate string FactoryMethodNameForTIndex(int tIndex);

internal delegate string UnionGetter(string argument);