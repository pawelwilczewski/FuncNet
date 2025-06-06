namespace FuncNet.CodeGeneration.Models;

[Flags]
public enum UnionMethodAsyncConfig
{
	None = 0,
	All = ~0,
	ReturnType = 1 << 0,
	InputUnion = 1 << 1,
	AppliedMethodReturnType = 1 << 2
}

internal static class UnionMethodConfigConsts
{
	public const int MAX_UNION_SIZE = 8;
	public const string NAMESPACE = "FuncNet";

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