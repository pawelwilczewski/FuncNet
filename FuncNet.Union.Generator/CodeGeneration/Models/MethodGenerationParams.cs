namespace FuncNet.Union.Generator.CodeGeneration.Models;

internal record class MethodGenerationParams(
	string ExtendedTypeName,
	string MethodNameOnly,
	int UnionSize,
	UnionMethodAsyncConfig AsyncConfig,
	string ThisArgumentName,
	Func<IEnumerable<string>> ElementTypeNamesGenerator,
	UnionGetter GetUnionOnArgument,
	FactoryMethodNameForTIndex FactoryMethodName)
{
	public bool IsAsync(UnionMethodAsyncConfig typeToCheck) => (typeToCheck & AsyncConfig) != 0;
}

internal delegate string FactoryMethodNameForTIndex(int tIndex);

internal delegate string UnionGetter(string argument);