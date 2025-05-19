using FuncNet.Union.Generator.CodeGeneration.Models;

namespace FuncNet.Union.Generator;

internal static class CodeGenerationUtils
{
	public static readonly UnionMethodAsyncConfig[] allPossibleAsyncMethodConfigs =
	[
		UnionMethodAsyncConfig.None,
		UnionMethodAsyncConfig.All,
		UnionMethodAsyncConfig.ReturnType | UnionMethodAsyncConfig.AppliedMethodReturnType,
		UnionMethodAsyncConfig.ReturnType | UnionMethodAsyncConfig.InputUnion
	];
}