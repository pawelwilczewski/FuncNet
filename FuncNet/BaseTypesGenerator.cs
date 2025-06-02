using FuncNet.CodeGeneration;
using Microsoft.CodeAnalysis;
using static FuncNet.CodeGeneration.Models.UnionMethodConfigConsts;

namespace FuncNet;

[Generator]
internal sealed class BaseTypesGenerator : ISourceGenerator
{
	public void Initialize(GeneratorInitializationContext context) { }

	public void Execute(GeneratorExecutionContext context)
	{
		for (var unionSize = 2; unionSize <= MAX_UNION_SIZE; ++unionSize)
		{
			context.AddSourceIfNotExists($"Union{unionSize}", UnionGenerator.GenerateUnionFile(NAMESPACE, unionSize));
			context.AddSourceIfNotExists($"Result{unionSize}", ResultGenerator.GenerateResultFile(NAMESPACE, unionSize));
		}
	}
}