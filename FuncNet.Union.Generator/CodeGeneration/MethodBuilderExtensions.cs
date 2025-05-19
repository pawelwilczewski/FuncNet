using FuncNet.Union.Generator.CodeGeneration.Builders;
using FuncNet.Union.Generator.CodeGeneration.Models;

namespace FuncNet.Union.Generator.CodeGeneration;

internal static class MethodBuilderExtensions
{
	public static MethodBuilder AddCancellationTokenIfAsync(this MethodBuilder methodBuilder, MethodGenerationParams p) =>
		methodBuilder.AddArguments(p.IsAsync(UnionMethodAsyncConfig.ReturnType) ? ["CancellationToken cancellationToken = default"] : []);

	public static MethodBuilder AddThrowIfCanceledIfAsync(this MethodBuilder methodBuilder, MethodGenerationParams p) =>
		methodBuilder.AddBodyStatements(p.IsAsync(UnionMethodAsyncConfig.ReturnType) ? ["cancellationToken.ThrowIfCancellationRequested()"] : []);
}