using FuncNet.Generator.CodeGeneration.Builders;
using FuncNet.Generator.CodeGeneration.Models;

namespace FuncNet.Generator.CodeGeneration;

internal static class MethodBuilderExtensions
{
	public static MethodBuilder AddCancellationTokenIfAsync(this MethodBuilder methodBuilder, MethodGenerationParams p) =>
		methodBuilder.AddArguments(p.IsAsync(UnionMethodAsyncConfig.ReturnType) ? ["CancellationToken cancellationToken = default"] : []);

	public static MethodBuilder AddThrowIfCanceledIfAsync(this MethodBuilder methodBuilder, MethodGenerationParams p) =>
		methodBuilder.AddBodyStatements(p.IsAsync(UnionMethodAsyncConfig.ReturnType) ? ["cancellationToken.ThrowIfCancellationRequested()"] : []);
}