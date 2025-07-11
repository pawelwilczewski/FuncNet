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
	public const string NAMESPACE = nameof(FuncNet);

	public static UnionMethodAsyncConfig[] AllPossibleMethodAsyncConfigs { get; } =
	[
		UnionMethodAsyncConfig.None,
		UnionMethodAsyncConfig.All,
		UnionMethodAsyncConfig.ReturnType | UnionMethodAsyncConfig.AppliedMethodReturnType,
		UnionMethodAsyncConfig.ReturnType | UnionMethodAsyncConfig.InputUnion
	];

	public static UnionMethodAsyncConfig[] AllOrNoneNoneMethodAsyncConfigs { get; } =
	[
		UnionMethodAsyncConfig.None,
		UnionMethodAsyncConfig.All
	];

	public static UnionMethodAsyncConfig[] NoInputUnionTaskMethodAsyncConfigs { get; } =
	[
		UnionMethodAsyncConfig.None,
		UnionMethodAsyncConfig.ReturnType | UnionMethodAsyncConfig.AppliedMethodReturnType
	];

	public static UnionMethodAsyncConfig[] InputUnionTaskMethodAsyncConfigs { get; } =
	[
		UnionMethodAsyncConfig.All,
		UnionMethodAsyncConfig.ReturnType | UnionMethodAsyncConfig.InputUnion
	];

	public static IEnumerable<(MethodType methodType, UnionMethodAsyncConfig[] asyncConfig)> MemberAndExtensionMethodConfigs(string thisArgumentName) =>
	[
		(new MethodType.Member(), NoInputUnionTaskMethodAsyncConfigs),
		(new MethodType.Extension(thisArgumentName), InputUnionTaskMethodAsyncConfigs)
	];

	public static IEnumerable<(MethodType methodType, UnionMethodAsyncConfig[] asyncConfig)> AllOrNoneMemberAndExtensionMethodConfigs(string thisArgumentName) =>
	[
		(new MethodType.Member(), [UnionMethodAsyncConfig.None]),
		(new MethodType.Extension(thisArgumentName), [UnionMethodAsyncConfig.All])
	];
}