using FuncNet.SourceGenerators.Conversions;
using Microsoft.CodeAnalysis;

namespace FuncNet.SourceGenerators;

[Generator]
public sealed class ResultConversionGenerator : IIncrementalGenerator
{
	public void Initialize(IncrementalGeneratorInitializationContext initializationContext) =>
		new ImplicitConversionGenerator(
				"Result",
				i => i == 0 ? "TSuccess" : $"TError{i - 1}",
				// we can only convert between results that have the same success type
				@params => @params.ConversionSourceGenericArgsOrder.First() == 0)
			.Initialize(initializationContext);
}