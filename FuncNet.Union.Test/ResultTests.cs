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

		var bound = result.Bind(
			value => Result<string, string, float>.FromSuccess($"Value: {value}")
		);

		var finalValue = bound.Match(
			success => success,
			error => throw new UnreachableException(),
			otherErrors => throw new UnreachableException()
		);

		Assert.Equal("Value: 42", finalValue);
	}

	[Fact]
	public void Bind_WithError_PassesThrough()
	{
		var result = Result<int, string, float>.FromError("Original error");

		var bound = result.Bind(
			value => Result<string, string, float>.FromSuccess($"Value: {value}")
		);

		var finalValue = bound.Match(
			success => throw new UnreachableException(),
			error => error,
			otherErrors => throw new UnreachableException()
		);

		Assert.Equal("Original error", finalValue);
	}

	[Fact]
	public async Task AsyncBindVariants_Work()
	{
		var taskResult = Task.FromResult(Result<int, string, float>.FromSuccess(10));
		var boundTaskAsync = await taskResult.Bind(async value =>
		{
			await Task.Yield();
			return Result<double, string, float>.FromSuccess(value * 2.5);
		});

		var taskAsyncValue = boundTaskAsync.Match(
			success => success,
			error => throw new UnreachableException(),
			otherErrors => throw new UnreachableException()
		);

		Assert.Equal(25.0, taskAsyncValue);

		var result = Result<int, string, float>.FromSuccess(7);
		var boundAsync = await result.Bind(async value =>
		{
			await Task.Yield();
			return Result<string, string, float>.FromSuccess($"Processed: {value * 3}");
		});

		var asyncValue = boundAsync.Match(
			success => success,
			error => throw new UnreachableException(),
			otherErrors => throw new UnreachableException()
		);

		Assert.Equal("Processed: 21", asyncValue);

		var errorTaskResult = Task.FromResult(Result<int, string, float>.FromError(3.14f));
		var boundTask = await errorTaskResult.Bind(
			value => Result<string, string, float>.FromSuccess(value.ToString())
		);

		var errorPassThrough = boundTask.Match(
			success => throw new UnreachableException(),
			error => throw new UnreachableException(),
			otherErrors => true
		);

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
			.Bind(async value =>
			{
				await Task.Yield();
				return value > 100
					? Result<int, string, double>.FromError("Processing error: Value too large")
					: Result<int, string, double>.FromSuccess(value * 3);
			})
			.Bind(value => Result<string, string, double>.FromSuccess($"Success: {value}"))
			.Match(
				success => success,
				error => error,
				otherErrors => $"Other error: {otherErrors}"
			);
	}

	[Fact]
	public void BindError_WithError_Works()
	{
		var result = Result<int, string, float>.FromError("Error message");

		var bound = result.BindError0(
			errorMsg => Result<int, DateTime, float>.FromError(DateTime.Parse("2020-01-01"))
		);

		var finalValue = bound.Match(
			success => throw new UnreachableException(),
			error => error,
			otherErrors => throw new UnreachableException()
		);

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
			otherErrors => throw new UnreachableException()
		);

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
			otherErrors => throw new UnreachableException()
		);

		Assert.Equal("Success value", unchangedValue);
	}
}