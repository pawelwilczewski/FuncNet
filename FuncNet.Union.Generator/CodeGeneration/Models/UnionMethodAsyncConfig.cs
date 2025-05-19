namespace FuncNet.Union.Generator.CodeGeneration.Models;

[Flags]
public enum UnionMethodAsyncConfig
{
	None = 0,
	All = ~0,
	ReturnType = 1 << 0,
	InputUnion = 1 << 1,
	AppliedMethodReturnType = 1 << 2
}