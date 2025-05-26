using System.Diagnostics;
using FuncNet.Generator;
using FuncNet.Generator.CodeGeneration.Builders;
using FuncNet.Generator.CodeGeneration.Models;
using FuncNet.Generator.ExtensionsGenerators;
using Microsoft.CodeAnalysis;
using static FuncNet.Generator.CodeGeneration.Models.UnionMethodAsyncConfigConsts;

[Generator]
public sealed class ExtensionsGenerator : ISourceGenerator
{
	public void Initialize(GeneratorInitializationContext context) { }

	public void Execute(GeneratorExecutionContext context)
	{
		var startTime = Stopwatch.GetTimestamp();

		const string @namespace = "FuncNet";

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
				@namespace, m.additionalUsings, m.classDeclaration, p.extendedTypeName, m.methodNameOnly, unionSize,
				m.generateMethods, p.thisArgumentName, p.elementNamesGenerator, p.unionGetter, p.factoryMethodName, p.defaultSwitchCaseReturnValue);

		generationParams =
		[
			..generationParams,
			new UnionExtensionsFileGenerationParams(@namespace, "", OptionStaticClassDeclaration, "Option",
				"ToResult", 1, OptionToResultExtensionsGenerator.GenerateMethods, "option",
				() => ["Some"], _ => throw new InvalidOperationException(),
				i => i == 0 ? "FromSuccess" : "None", ThrowOtherSwitchCaseReturnValue)
		];

		for (var unionSize = 2; unionSize <= MAX_UNION_SIZE; ++unionSize)
		{
			context.AddSource($"Union{unionSize}", UnionGenerator.GenerateUnionFile(@namespace, unionSize));

			context.AddSource($"Result{unionSize}", ResultGenerator.GenerateResultFile(@namespace, unionSize));
		}

		foreach (var p in generationParams)
		{
			context.AddSource(p.FileName, GenerateSourceFile(p));
		}

		context.AddSource("None", @"
namespace FuncNet;

public readonly record struct None
{
	public static None Instance { get; } = new();
}");

		context.AddSource("Option", @"
#nullable enable

using System.Collections.Generic;
using System.Threading.Tasks;

namespace FuncNet;

public readonly record struct Option<TValue>
{
	public static Option<TValue> None { get; } = new(default, false);

	internal TValue? Value0 { get; init; }
	private bool HasValue { get; }
	internal int Index => HasValue ? 0 : 1;

	private Option(TValue? value, bool hasValue)
	{
		Value0 = value;
		HasValue = hasValue;
	}

	public static Option<TValue> Some(TValue value) => new(value, true);
	public static async Task<Option<TValue>> Some(Task<TValue> value) => new(await value.ConfigureAwait(false), true);

	public static Option<TValue> FromNullable(TValue? value) => new(value, value is not null);

	public static async Task<Option<TValue>> FromNullable(Task<TValue?> value)
	{
		var v = await value.ConfigureAwait(false);
		return new Option<TValue>(v, v is not null);
	}

	public IEnumerable<TValue> ToEnumerable() => HasValue ? [Value0!] : [];
}");

		context.AddSource("Option.Bind", @"
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

		context.AddSource("Option.Map", @"
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

		context.AddSource("Option.Filter", @"
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

		context.AddSource("Option.Tap", @"
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

		context.AddSource("Option.Match", @"
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

		context.AddSource("Pipe", @"
using System;
using System.Threading.Tasks;

namespace FuncNet;

public static class PipeExtensions
{
	public static TNew Pipe<TOld, TNew>(this TOld value, Func<TOld, TNew> func) => func(value);

	public static async Task<TNew> Pipe<TOld, TNew>(this Task<TOld> value, Func<TOld, TNew> func) =>
		func(await value.ConfigureAwait(false));

	public static async Task<TNew> Pipe<TOld, TNew>(this Task<TOld> value, Func<TOld, Task<TNew>> func) =>
		await func(await value.ConfigureAwait(false)).ConfigureAwait(false);
}");

		// Console.WriteLine($"Generated in {Stopwatch.GetElapsedTime(startTime)}");
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