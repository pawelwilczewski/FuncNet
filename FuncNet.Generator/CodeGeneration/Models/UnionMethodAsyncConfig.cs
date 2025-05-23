namespace FuncNet.Generator.CodeGeneration.Models;

[Flags]
public enum UnionMethodAsyncConfig
{
	None = 0,
	All = ~0,
	ReturnType = 1 << 0,
	InputUnion = 1 << 1,
	AppliedMethodReturnType = 1 << 2
}

internal static class UnionMethodAsyncConfigConsts
{
	public static UnionMethodAsyncConfig[] AllPossibleMethodAsyncConfigs { get; } =
	[
		UnionMethodAsyncConfig.None,
		UnionMethodAsyncConfig.All,
		UnionMethodAsyncConfig.ReturnType | UnionMethodAsyncConfig.AppliedMethodReturnType,
		UnionMethodAsyncConfig.ReturnType | UnionMethodAsyncConfig.InputUnion
	];

	public static UnionMethodAsyncConfig[] NoneOrAllMethodAsyncConfigs { get; } =
	[
		UnionMethodAsyncConfig.None,
		UnionMethodAsyncConfig.All
	];
}