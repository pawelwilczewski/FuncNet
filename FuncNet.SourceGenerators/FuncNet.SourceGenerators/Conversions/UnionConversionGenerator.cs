using Microsoft.CodeAnalysis;

namespace FuncNet.SourceGenerators.Conversions;

[Generator]
public sealed class UnionConversionGenerator : IIncrementalGenerator
{
	public void Initialize(IncrementalGeneratorInitializationContext initializationContext) =>
		new ImplicitConversionGenerator("Union", i => $"T{i}", _ => true)
			.Initialize(initializationContext);
}