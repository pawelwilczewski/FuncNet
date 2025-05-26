namespace FuncNet.SourceGenerators.Conversions;

internal sealed class ImplicitUnionConversion
{
	public string Code { get; }

	public string FileName { get; }

	public ImplicitUnionConversion(string code, ImplicitUnionConversionParams paramsUsed)
	{
		Code = code;
		FileName = $"Union{paramsUsed.ConversionTargetGenericSize}_From_{string.Join("", paramsUsed.ConversionSourceGenericArgsOrder)}";
	}
}