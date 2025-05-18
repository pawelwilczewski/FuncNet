using System.Diagnostics;

namespace FuncNet.Union.Test;

public class ResultTests
{
	[Fact]
	public async Task Match_Works()
	{
		var result = Result<int, string, float>.FromSuccess(18);

		var value = result.Match(
			success => "abcd",
			error => throw new UnreachableException(),
			otherErrors => throw new UnreachableException());

		Assert.Equal("abcd", value);

		var resultAsync = Result<int, string, float>.FromError(Task.FromResult(123.4f));

		var valueAsync = resultAsync.Match(
			success => throw new UnreachableException(),
			error => throw new UnreachableException(),
			otherErrors => 1000);

		Assert.Equal(1000, await valueAsync);
	}

	[Fact]
	public void Bind_WithSuccess_Works()
	{
		var result = Result<int, string, float>.FromSuccess(42);

		var bound = result.BindSuccess(
			value => Result<string, string, float>.FromSuccess($"Value: {value}"));

		var finalValue = bound.Match(
			success => success,
			error => throw new UnreachableException(),
			otherErrors => throw new UnreachableException());

		Assert.Equal("Value: 42", finalValue);
	}

	[Fact]
	public void Bind_WithError_PassesThrough()
	{
		var result = Result<int, string, float>.FromError("Original error");

		var bound = result.BindSuccess(
			value => Result<string, string, float>.FromSuccess($"Value: {value}"));

		var finalValue = bound.Match(
			success => throw new UnreachableException(),
			error => error,
			otherErrors => throw new UnreachableException());

		Assert.Equal("Original error", finalValue);
	}

	[Fact]
	public async Task AsyncBindVariants_Work()
	{
		var taskResult = Task.FromResult(Result<int, string, float>.FromSuccess(10));
		var boundTaskAsync = await taskResult.BindSuccess(async value =>
		{
			await Task.Yield();
			return Result<double, string, float>.FromSuccess(value * 2.5);
		});

		var taskAsyncValue = boundTaskAsync.Match(
			success => success,
			error => throw new UnreachableException(),
			otherErrors => throw new UnreachableException());

		Assert.Equal(25.0, taskAsyncValue);

		var result = Result<int, string, float>.FromSuccess(7);
		var boundAsync = await result.BindSuccess(async value =>
		{
			await Task.Yield();
			return Result<string, string, float>.FromSuccess($"Processed: {value * 3}");
		});

		var asyncValue = boundAsync.Match(
			success => success,
			error => throw new UnreachableException(),
			otherErrors => throw new UnreachableException());

		Assert.Equal("Processed: 21", asyncValue);

		var errorTaskResult = Task.FromResult(Result<int, string, float>.FromError(3.14f));
		var boundTask = await errorTaskResult.BindSuccess(
			value => Result<string, string, float>.FromSuccess(value.ToString()));

		var errorPassThrough = boundTask.Match(
			success => throw new UnreachableException(),
			error => throw new UnreachableException(),
			otherErrors => true);

		Assert.True(errorPassThrough);
	}

	[Fact]
	public async Task BindPipeline_Works()
	{
		Assert.Equal("Success: 36", await Process(Result<int, string, double>.FromSuccess(12)));
		Assert.Equal("Input error", await Process(Result<int, string, double>.FromError("Input error")));
		Assert.Equal("Processing error: Value too large", await Process(Result<int, string, double>.FromSuccess(150)));
		return;

		async Task<string> Process(Result<int, string, double> input) => await input
			.BindSuccess(async value =>
			{
				await Task.Yield();
				return value > 100
					? Result<int, string, double>.FromError("Processing error: Value too large")
					: Result<int, string, double>.FromSuccess(value * 3);
			})
			.BindSuccess(value => Result<string, string, double>.FromSuccess($"Success: {value}"))
			.Match(
				success => success,
				error => error,
				otherErrors => $"Other error: {otherErrors}");
	}

	[Fact]
	public void BindError_WithError_Works()
	{
		var result = Result<int, string, float>.FromError("Error message");

		var bound = result.BindError0(
			errorMsg => Result<int, DateTime, float>.FromError(DateTime.Parse("2020-01-01")));

		var finalValue = bound.Match(
			success => throw new UnreachableException(),
			error => error,
			otherErrors => throw new UnreachableException());

		Assert.Equal(DateTime.Parse("2020-01-01"), finalValue);
	}

	[Fact]
	public async Task BindErrorAsync_Works()
	{
		var result = Result<int, string, double>.FromError(132.43);
		var transformed = await result.BindError1(async errorMsg =>
		{
			await Task.Yield();
			return Result<int, string, double>.FromSuccess(42);
		});

		var finalValue = transformed.Match(
			success => success,
			error => throw new UnreachableException(),
			otherErrors => throw new UnreachableException());

		Assert.Equal(42, finalValue);

		var successResult = Result<string, int, float>.FromSuccess("Success value");
		var unchanged = await successResult.BindError0(async errorCode =>
		{
			await Task.Yield();
			return Result<string, string, float>.FromError("Transformed error");
		});

		var unchangedValue = unchanged.Match(
			success => success,
			error => throw new UnreachableException(),
			otherErrors => throw new UnreachableException());

		Assert.Equal("Success value", unchangedValue);
	}

	[Fact]
	public void Map_WithSuccess_Works()
	{
		var result = Result<int, string, float>.FromSuccess(42);

		var mapped = result.MapSuccess(
			value => value.ToString());

		var finalValue = mapped.Match(
			success => success,
			error => throw new UnreachableException(),
			otherErrors => throw new UnreachableException());

		Assert.Equal("42", finalValue);
	}

	[Fact]
	public void Map_WithError_PassesThrough()
	{
		var result = Result<int, string, float>.FromError("Original error");

		var mapped = result.MapSuccess(
			value => value * 2);

		var finalValue = mapped.Match(
			success => throw new UnreachableException(),
			error => error,
			otherErrors => throw new UnreachableException());

		Assert.Equal("Original error", finalValue);
	}

	[Fact]
	public async Task AsyncMapVariants_Work()
	{
		var taskResult = Task.FromResult(Result<int, string, float>.FromSuccess(10));
		var mappedTaskAsync = await taskResult.MapSuccess(async value =>
		{
			await Task.Yield();
			return value * 2.5;
		});

		var taskAsyncValue = mappedTaskAsync.Match(
			success => success,
			error => throw new UnreachableException(),
			otherErrors => throw new UnreachableException());

		Assert.Equal(25.0, taskAsyncValue);

		var result = Result<int, string, float>.FromSuccess(7);
		var mappedAsync = await result.MapSuccess<int, int, string, float>(async value =>
		{
			await Task.Yield();
			return value * 3;
		});

		var asyncValue = mappedAsync.Match(
			success => success,
			error => throw new UnreachableException(),
			otherErrors => throw new UnreachableException());

		Assert.Equal(21, asyncValue);

		var errorTaskResult = Task.FromResult(Result<int, string, float>.FromError(3.14f));
		var mappedTask = await errorTaskResult.MapSuccess(
			value => value.ToString());

		var errorPassThrough = mappedTask.Match(
			success => throw new UnreachableException(),
			error => throw new UnreachableException(),
			otherErrors => true);

		Assert.True(errorPassThrough);
	}

	[Fact]
	public void MapError_WithError_Works()
	{
		var result = Result<int, string, float>.FromError("Error message");

		var mapped = result.MapError0(
			errorMsg => DateTime.Parse("2020-01-01"));

		var finalValue = mapped.Match(
			success => throw new UnreachableException(),
			error => error,
			otherErrors => throw new UnreachableException());

		Assert.Equal(DateTime.Parse("2020-01-01"), finalValue);
	}

	[Fact]
	public async Task MapErrorAsync_Works()
	{
		var result = Result<int, string, double>.FromError(132.43);
		var transformed = await result.MapError1<double, int, string, double>(async errorValue =>
		{
			await Task.Yield();
			return errorValue / 2;
		});

		var finalValue = transformed.Match(
			success => throw new UnreachableException(),
			error => throw new UnreachableException(),
			otherErrors => otherErrors);

		Assert.Equal(66.215, finalValue);

		var successResult = Result<string, int, float>.FromSuccess("Success value");
		var unchanged = await successResult
			.MapError0<double, string, int, float>(async errorCode =>
			{
				await Task.Yield();
				return errorCode * 0.5;
			});

		var unchangedValue = unchanged.Match(
			success => success,
			error => throw new UnreachableException(),
			otherErrors => throw new UnreachableException());

		Assert.Equal("Success value", unchangedValue);
	}

	[Fact]
	public void CombinedPipeline_WithMapAndBind_Works()
	{
		Assert.Equal("FINAL: 72", ProcessPipeline(Result<int, string, double>.FromSuccess(7)));
		Assert.Equal("Error: Input error", ProcessPipeline(Result<int, string, double>.FromError("Input error")));
		Assert.Equal("Error: Value is negative", ProcessPipeline(Result<int, string, double>.FromSuccess(-5)));
		Assert.Equal("Other error: 99.5", ProcessPipeline(Result<int, string, double>.FromError(99.5)));
		return;

		string ProcessPipeline(Result<int, string, double> input) =>
			input.MapSuccess(value => value * 2)
				.BindSuccess(value => value < 0
					? Result<int, string, double>.FromError("Value is negative")
					: Result<int, string, double>.FromSuccess(value + 10))
				.MapError0(errorMsg => $"Error: {errorMsg}")
				.MapSuccess(value => value * 3)
				.BindSuccess(value => Result<string, string, double>.FromSuccess($"FINAL: {value}"))
				.Match(
					success => success,
					error => error,
					otherErrors => $"Other error: {otherErrors}");
	}

	[Fact]
	public async Task ReusablePipeline_Works()
	{
		Assert.Equal("Result: 30", await ProcessWithReusablePipeline(Result<int, string, double>.FromSuccess(5)));
		Assert.Equal("Error: Invalid input", await ProcessWithReusablePipeline(Result<int, string, double>.FromError("Invalid input")));
		Assert.Equal("Error: Number too large", await ProcessWithReusablePipeline(Result<int, string, double>.FromSuccess(50)));
		Assert.Equal("Other error: 123.45", await ProcessWithReusablePipeline(Result<int, string, double>.FromError(123.45)));
		return;

		async Task<string> ProcessWithReusablePipeline(Result<int, string, double> input)
		{
			return await input.BindSuccess(Operation)
				.MapSuccess(value => $"Result: {value}")
				.MapError0(error => $"Error: {error}")
				.Match(
					success => success,
					error => error,
					otherErrors => $"Other error: {otherErrors}");

			async Task<Result<int, string, double>> Operation(int value)
			{
				if (value > 20) return Result<int, string, double>.FromError("Number too large");

				await Task.Yield();
				return Result<int, string, double>.FromSuccess(value * 6);
			}
		}
	}

	[Fact]
	public void TapAndEnsurePipeline_Works()
	{
		var messages = new List<string>();

		var successResult = ProcessWithValidation(42, messages);
		Assert.Equal("Final value: 84", successResult);
		Assert.Equal(2, messages.Count);
		Assert.Contains("Processing value: 42", messages);
		Assert.Contains("Doubled value: 84", messages);

		messages.Clear();

		var invalidResult = ProcessWithValidation(-5, messages);
		Assert.Equal("Validation error: Value must be positive", invalidResult);
		Assert.Equal(2, messages.Count);
		Assert.Contains("Validation failed for: -5", messages);

		messages.Clear();

		var tooBigResult = ProcessWithValidation(150, messages);
		Assert.Equal("Validation error: Value exceeds maximum", tooBigResult);
		Assert.Equal(3, messages.Count);
		Assert.Contains("Processing value: 150", messages);
		Assert.Contains("Validation failed: 150 is too large", messages);

		return;

		static string ProcessWithValidation(int input, List<string> logMessages) =>
			Result<int, string, double>.FromSuccess(input)
				.TapSuccess(value => { logMessages.Add($"Processing value: {value}"); })
				.EnsureSuccess(
					value => value > 0,
					() =>
					{
						logMessages.Add($"Validation failed for: {input}");
						return Result<int, string, double>.FromError("Value must be positive");
					})
				.MapSuccess(value => value * 2)
				.TapSuccess(value => { logMessages.Add($"Doubled value: {value}"); })
				.EnsureSuccess(
					value => value < 100,
					() =>
					{
						logMessages.Add($"Validation failed: {input} is too large");
						return Result<int, string, double>.FromError("Value exceeds maximum");
					})
				.MapSuccess(value => $"Final value: {value}")
				.MapError0(error => $"Validation error: {error}")
				.Match(
					success => success,
					error => error,
					otherErrors => $"Other error: {otherErrors}");
	}
}