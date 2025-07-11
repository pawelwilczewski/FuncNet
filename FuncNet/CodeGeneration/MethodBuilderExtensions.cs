using FuncNet.CodeGeneration.Builders;
using FuncNet.CodeGeneration.Models;

namespace FuncNet.CodeGeneration;

internal static class MethodBuilderExtensions
{
	public static MethodBuilder AddArgumentIf(this MethodBuilder methodBuilder, string argument, Func<bool> condition) =>
		methodBuilder.AddArguments(condition() ? [argument] : []);

	public static MethodBuilder AddCancellationTokenIfAsync(this MethodBuilder methodBuilder, MethodGenerationParams p) =>
		methodBuilder.AddArguments(p.IsAsync(UnionMethodAsyncConfig.ReturnType) ? ["CancellationToken cancellationToken = default"] : []);

	public static MethodBuilder AddThrowIfCanceledIfAsync(this MethodBuilder methodBuilder, MethodGenerationParams p) =>
		methodBuilder.AddBodyStatements(p.IsAsync(UnionMethodAsyncConfig.ReturnType) ? ["cancellationToken.ThrowIfCancellationRequested()"] : []);
}