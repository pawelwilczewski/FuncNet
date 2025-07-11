using FuncNet.CodeGeneration.Builders;
using FuncNet.CodeGeneration.Models;

namespace FuncNet.CodeGeneration;

internal static class MethodGenerationParamsExtensions
{
	public static IEnumerable<string> Ts(this MethodGenerationParams p) =>
		p.ElementTypeNamesGenerator().Select(t => $"T{t}");

	public static IEnumerable<string> TsWithSpecialReplacement(this MethodGenerationParamsWithSpecialIndex p, Func<string, string> replaceSpecial) =>
		p.Ts().Select((t, index) => index == p.SpecialIndex ? replaceSpecial(t) : t);

	public static IEnumerable<string> TsNew(this MethodGenerationParamsWithSpecialIndex p) =>
		p.TsWithSpecialReplacement(t => $"{t}New");

	public static string TypeOfTs(this MethodGenerationParams p) =>
		$"{p.TypeName}<{p.Ts().CommaSeparated()}>";

	public static string TypeOfTsNew(this MethodGenerationParamsWithSpecialIndex p) =>
		$"{p.TypeName}<{p.TsNew().CommaSeparated()}>";

	public static string WrapInNewTypeFromT(this string value, SwitchCase @case, MethodGenerationParamsWithSpecialIndex p) =>
		$"{p.TypeOfTsNew()}.{p.FactoryMethodName(@case.Index)}({value})";

	public static string WrapInNewTypeFromTIfNotSpecial(this string value, SwitchCase @case, MethodGenerationParamsWithSpecialIndex p) =>
		p.SpecialIndex == @case.Index ? value : value.WrapInNewTypeFromT(@case, p);
}