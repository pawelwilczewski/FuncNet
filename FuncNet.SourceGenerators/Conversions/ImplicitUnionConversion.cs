namespace FuncNet.SourceGenerators.Conversions;

internal sealed class ImplicitUnionConversion
{
	public string Code { get; }

	public string FileName { get; }

	public ImplicitUnionConversion(string code, ImplicitUnionConversionParams paramsUsed, string typeName)
	{
		Code = code;
		FileName = $"{typeName}{paramsUsed.ConversionTargetGenericSize}_From_{string.Join("", paramsUsed.ConversionSourceGenericArgsOrder)}";
	}
}