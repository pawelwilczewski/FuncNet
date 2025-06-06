using FuncNet.CodeGeneration;
using FuncNet.CodeGeneration.Builders;
using FuncNet.CodeGeneration.Models;
using FuncNet.ExtensionsGenerators;
using Microsoft.CodeAnalysis;
using static FuncNet.CodeGeneration.Models.UnionMethodConfigConsts;

namespace FuncNet;

[Generator]
public sealed class ExtensionsGenerator : ISourceGenerator
{
	public void Initialize(GeneratorInitializationContext context) { }

	public void Execute(GeneratorExecutionContext context)
	{
		(string extendedTypeName, string thisArgumentName, Func<IEnumerable<string>> elementNamesGenerator, UnionGetter unionGetter, FactoryMethodNameForTIndex factoryMethodName, OtherSwitchCaseReturnValue defaultSwitchCaseReturnValue)[] GenerateBaseParams(int unionSize) =>
		[
			("Union", "union", UnionElementNamesGenerator(unionSize), UnionGetterForUnion, UnionFactoryMethodName, ThrowOtherSwitchCaseReturnValue),
			("Result", "result", ResultElementNamesGenerator(unionSize), UnionGetterForResult, ResultFactoryMethodName, ThrowOtherSwitchCaseReturnValue)
		];

		(string methodNameOnly, GenerateAllMethods generateMethods, Func<UnionExtensionsFileGenerationParams, string> classDeclaration, string additionalUsings)[] methodGenerators =
		[
			("Match", MatchExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
			("Map", MapExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
			("Bind", BindExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
			("Tap", TapExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
			("Filter", FilterExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
			("Zip", ZipExtensionsGenerator.GenerateMethods, StaticClassDeclaration, "using System.Collections.Generic;\nusing System.Linq;\n"),
			("Combine", ResultCombineExtensionsGenerator.GenerateMethods, PartialRecordStructDeclaration, "using System.Collections.Generic;\n"),
			("ToUnion", ResultToUnionExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
			("ToOption", ResultToOptionExtensionsGenerator.GenerateMethods, StaticClassDeclaration, ""),
			("Extend", ExtendExtensionsGenerator.GenerateMethods, StaticClassDeclaration, "")
		];

		var generationParams =
			from m in methodGenerators
			from unionSize in Enumerable.Range(2, MAX_UNION_SIZE - 1)
			from p in GenerateBaseParams(unionSize)
			where !(p.extendedTypeName == "Union" && m.methodNameOnly is "Combine" or "ToUnion" or "ToOption") // hacky
			select new UnionExtensionsFileGenerationParams(
				NAMESPACE, m.additionalUsings, m.classDeclaration, p.extendedTypeName, m.methodNameOnly, unionSize,
				m.generateMethods, p.thisArgumentName, p.elementNamesGenerator, p.unionGetter, p.factoryMethodName, p.defaultSwitchCaseReturnValue);

		generationParams =
		[
			..generationParams,
			new UnionExtensionsFileGenerationParams(NAMESPACE, "", OptionStaticClassDeclaration, "Option",
				"ToResult", 1, OptionToResultExtensionsGenerator.GenerateMethods, "option",
				() => ["Some"], _ => throw new InvalidOperationException(),
				i => i == 0 ? "FromSuccess" : "None", ThrowOtherSwitchCaseReturnValue)
		];

		foreach (var p in generationParams)
		{
			context.AddSourceIfNotExistsOrPartial(p.FileName, GenerateSourceFile(p));
		}

		context.AddSourceIfNotExistsOrPartial("Option.Bind", @"
#nullable enable

using System;
using System.Threading;
using System.Threading.Tasks;

namespace FuncNet;

public static class OptionBind
{
	public static Option<TValueNew> Bind<TValueNew, TValueOld>(
		this Option<TValueOld> option,
		Func<TValueOld, Option<TValueNew>> binding)
	{
		var u = option;
		return u.Index switch
		{
			0 => binding(u.Value0!),
			_ => Option<TValueNew>.None
		};
	}

	public static async Task<Option<TValueNew>> Bind<TValueNew, TValueOld>(
		this Task<Option<TValueOld>> option,
		Func<TValueOld, Task<Option<TValueNew>>> binding,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		return await (u.Index switch
		{
			0 => binding(u.Value0!),
			_ => Task.FromResult(Option<TValueNew>.None)
		}).ConfigureAwait(false);
	}

	public static async Task<Option<TValueNew>> Bind<TValueNew, TValueOld>(
		this Option<TValueOld> option,
		Func<TValueOld, Task<Option<TValueNew>>> binding,
		CancellationToken cancellationToken = default)
	{
		var u = option;
		cancellationToken.ThrowIfCancellationRequested();
		return await (u.Index switch
		{
			0 => binding(u.Value0!),
			_ => Task.FromResult(Option<TValueNew>.None)
		}).ConfigureAwait(false);
	}

	public static async Task<Option<TValueNew>> Bind<TValueNew, TValueOld>(
		this Task<Option<TValueOld>> option,
		Func<TValueOld, Option<TValueNew>> binding,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		return u.Index switch
		{
			0 => binding(u.Value0!),
			_ => Option<TValueNew>.None
		};
	}
}");

		context.AddSourceIfNotExistsOrPartial("Option.Map", @"
#nullable enable

using System;
using System.Threading;
using System.Threading.Tasks;

namespace FuncNet;

public static class OptionMap
{
	public static Option<TValueNew> Map<TValueNew, TValueOld>(
		this Option<TValueOld> option,
		Func<TValueOld, TValueNew> mapping)
	{
		var u = option;
		return u.Index switch
		{
			0 => Option<TValueNew>.Some(mapping(u.Value0!)),
			_ => Option<TValueNew>.None
		};
	}

	public static async Task<Option<TValueNew>> Map<TValueNew, TValueOld>(
		this Task<Option<TValueOld>> option,
		Func<TValueOld, Task<TValueNew>> mapping,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		return await (u.Index switch
		{
			0 => Option<TValueNew>.Some(mapping(u.Value0!)),
			_ => Task.FromResult(Option<TValueNew>.None)
		}).ConfigureAwait(false);
	}

	public static async Task<Option<TValueNew>> Map<TValueNew, TValueOld>(
		this Option<TValueOld> option,
		Func<TValueOld, Task<TValueNew>> mapping,
		CancellationToken cancellationToken = default)
	{
		var u = option;
		cancellationToken.ThrowIfCancellationRequested();
		return await (u.Index switch
		{
			0 => Option<TValueNew>.Some(mapping(u.Value0!)),
			_ => Task.FromResult(Option<TValueNew>.None)
		}).ConfigureAwait(false);
	}

	public static async Task<Option<TValueNew>> Map<TValueNew, TValueOld>(
		this Task<Option<TValueOld>> option,
		Func<TValueOld, TValueNew> mapping,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		return u.Index switch
		{
			0 => Option<TValueNew>.Some(mapping(u.Value0!)),
			_ => Option<TValueNew>.None
		};
	}
}");

		context.AddSourceIfNotExistsOrPartial("Option.Filter", @"
#nullable enable

using System;
using System.Threading;
using System.Threading.Tasks;

namespace FuncNet;

public static class OptionFilter
{
	public static Option<TValue> Filter<TValue>(
		this Option<TValue> option,
		Func<TValue, bool> predicate)
	{
		var u = option;
		if (u.Index == 0 && !predicate(u.Value0!)) return Option<TValue>.None;

		return option;
	}

	public static async Task<Option<TValue>> Filter<TValue>(
		this Task<Option<TValue>> option,
		Func<TValue, Task<bool>> predicate,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		if (u.Index == 0 && !await predicate(u.Value0!).ConfigureAwait(false)) return Option<TValue>.None;

		return await option.ConfigureAwait(false);
	}

	public static async Task<Option<TValue>> Filter<TValue>(
		this Option<TValue> option,
		Func<TValue, Task<bool>> predicate,
		CancellationToken cancellationToken = default)
	{
		var u = option;
		cancellationToken.ThrowIfCancellationRequested();
		if (u.Index == 0 && !await predicate(u.Value0!).ConfigureAwait(false)) return Option<TValue>.None;

		return option;
	}

	public static async Task<Option<TValue>> Filter<TValue>(
		this Task<Option<TValue>> option,
		Func<TValue, bool> predicate,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		if (u.Index == 0 && !predicate(u.Value0!)) return Option<TValue>.None;

		return await option.ConfigureAwait(false);
	}
}");

		context.AddSourceIfNotExistsOrPartial("Option.Tap", @"
#nullable enable

using System;
using System.Threading;
using System.Threading.Tasks;

namespace FuncNet;

public static class OptionTap
{
	public static Option<TValue> Tap<TValue>(
		this Option<TValue> option,
		Action<TValue> action)
	{
		var u = option;
		if (u.Index == 0) action(u.Value0!);
		return option;
	}

	public static async Task<Option<TValue>> Tap<TValue>(
		this Task<Option<TValue>> option,
		Func<TValue, Task> action,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		if (u.Index == 0) await action(u.Value0!).ConfigureAwait(false);
		return await option.ConfigureAwait(false);
	}

	public static async Task<Option<TValue>> Tap<TValue>(
		this Option<TValue> option,
		Func<TValue, Task> action,
		CancellationToken cancellationToken = default)
	{
		var u = option;
		cancellationToken.ThrowIfCancellationRequested();
		if (u.Index == 0) await action(u.Value0!).ConfigureAwait(false);
		return option;
	}

	public static async Task<Option<TValue>> Tap<TValue>(
		this Task<Option<TValue>> option,
		Action<TValue> action,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		if (u.Index == 0) action(u.Value0!);
		return await option.ConfigureAwait(false);
	}
}");

		context.AddSourceIfNotExistsOrPartial("Option.Match", @"
#nullable enable

using System;
using System.Threading;
using System.Threading.Tasks;

namespace FuncNet;

public static class OptionMatch
{
	public static TResult Match<TResult, TValue>(
		this Option<TValue> option,
		Func<TValue, TResult> some,
		Func<TResult> none)
	{
		var u = option;
		return u.Index switch
		{
			0 => some(u.Value0!),
			_ => none()
		};
	}

	public static async Task<TResult> Match<TResult, TValue>(
		this Task<Option<TValue>> option,
		Func<TValue, Task<TResult>> some,
		Func<Task<TResult>> none,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		return await (u.Index switch
		{
			0 => some(u.Value0!),
			_ => none()
		}).ConfigureAwait(false);
	}

	public static async Task<TResult> Match<TResult, TValue>(
		this Option<TValue> option,
		Func<TValue, Task<TResult>> some,
		Func<Task<TResult>> none,
		CancellationToken cancellationToken = default)
	{
		var u = option;
		cancellationToken.ThrowIfCancellationRequested();
		return await (u.Index switch
		{
			0 => some(u.Value0!),
			_ => none()
		}).ConfigureAwait(false);
	}

	public static async Task<TResult> Match<TResult, TValue>(
		this Task<Option<TValue>> option,
		Func<TValue, TResult> some,
		Func<TResult> none,
		CancellationToken cancellationToken = default)
	{
		var u = await option.ConfigureAwait(false);
		cancellationToken.ThrowIfCancellationRequested();
		return u.Index switch
		{
			0 => some(u.Value0!),
			_ => none()
		};
	}
}");
	}

	private static string GenerateSourceFile(UnionExtensionsFileGenerationParams p) =>
		new SourceCodeFileBuilder(
				$@"using System;
	using System.Threading;
	using System.Threading.Tasks;
	{p.AdditionalUsings}
	#nullable enable

	namespace {p.Namespace};")
			.AddClass(new ClassBuilder(p.ClassDeclaration(p))
				.AddMethods(p.GenerateAllMethods(p)))
			.ToString();

	private static string OptionStaticClassDeclaration(UnionExtensionsFileGenerationParams p) =>
		$"public static class {p.ExtendedTypeName}{p.MethodNameOnly}";

	private static string StaticClassDeclaration(UnionExtensionsFileGenerationParams p) =>
		$"public static class {p.ExtendedTypeName}{p.UnionSize}{p.MethodNameOnly}";

	private static string PartialRecordStructDeclaration(UnionExtensionsFileGenerationParams p) =>
		$"public readonly partial record struct {p.ExtendedTypeName}";

	private static Func<IEnumerable<string>> UnionElementNamesGenerator(int unionSize) =>
		() => Enumerable.Range(0, unionSize).Select(i => i.ToString());

	private static Func<IEnumerable<string>> ResultElementNamesGenerator(int unionSize) =>
		() => new[] { "Success" }.Concat(Enumerable.Range(0, unionSize - 1).Select(i => $"Error{i}"));

	private static string UnionGetterForUnion(string argument) => argument;
	private static string UnionGetterForResult(string argument) => $"({argument}).Value";

	private static string UnionFactoryMethodName(int tIndex) => $"FromT{tIndex}";
	private static string ResultFactoryMethodName(int tIndex) => tIndex == 0 ? "FromSuccess" : "FromError";

	private static string ThrowOtherSwitchCaseReturnValue(MethodGenerationParams p) => "throw new ArgumentOutOfRangeException()";
}