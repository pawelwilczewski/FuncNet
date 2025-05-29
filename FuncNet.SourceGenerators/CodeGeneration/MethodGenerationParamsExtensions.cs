using FuncNet.CodeGeneration.Builders;
using FuncNet.CodeGeneration.Models;

namespace FuncNet.CodeGeneration;

internal static class MethodGenerationParamsExtensions
{
	public static IEnumerable<string> Ts(this MethodGenerationParams p) =>
		p.ElementTypeNamesGenerator().Select(t => $"T{t}");

	public static string TsCommaSeparated(this MethodGenerationParams p) =>
		string.Join(", ", p.Ts());

	public static string TsCommaSeparatedWithSpecialReplacement(this MethodGenerationParamsWithSpecialIndex p, Func<string, string> replaceSpecial) =>
		string.Join(", ", p.Ts().Select((t, index) => index == p.SpecialIndex ? replaceSpecial(t) : t));

	public static string TsCommaSeparatedNew(this MethodGenerationParamsWithSpecialIndex p) =>
		p.TsCommaSeparatedWithSpecialReplacement(t => $"{t}New");

	public static string TsCommaSeparatedOld(this MethodGenerationParamsWithSpecialIndex p) =>
		p.TsCommaSeparatedWithSpecialReplacement(t => $"{t}Old");

	public static string ExtendedTypeOfTs(this MethodGenerationParams p) =>
		$"{p.ExtendedTypeName}<{p.TsCommaSeparated()}>";

	public static string ExtendedTypeOfTsNew(this MethodGenerationParamsWithSpecialIndex p) =>
		$"{p.ExtendedTypeName}<{p.TsCommaSeparatedNew()}>";

	public static string ExtendedTypeOfTsOld(this MethodGenerationParamsWithSpecialIndex p) =>
		$"{p.ExtendedTypeName}<{p.TsCommaSeparatedOld()}>";

	public static string WrapInNewExtendedTypeFromT(this string value, SwitchCase @case, MethodGenerationParamsWithSpecialIndex p) =>
		$"{p.ExtendedTypeOfTsNew()}.{p.FactoryMethodName(@case.Index)}({value})";

	public static string WrapInNewExtendedTypeFromTIfNotSpecial(this string value, SwitchCase @case, MethodGenerationParamsWithSpecialIndex p) =>
		p.SpecialIndex == @case.Index ? value : value.WrapInNewExtendedTypeFromT(@case, p);
}