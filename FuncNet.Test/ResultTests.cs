using System.Diagnostics;
using System.Globalization;

namespace FuncNet.Test;

using UserResult = Result<ResultTests.User, ResultTests.ValidationError, ResultTests.DatabaseError, ResultTests.EmailSendingError>;

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
		var finalValue = Result<int, string, float>.FromSuccess(42)
			.BindSuccess(value => Result<bool, string, float>.FromSuccess(true))
			.Match(
				success => success,
				error => throw new UnreachableException(),
				otherErrors => throw new UnreachableException());

		Assert.True(finalValue);
	}

	[Fact]
	public void Bind_WithError_PassesThrough()
	{
		var result = Result<int, string, float>.FromError("Original error");

		var bound = result.BindSuccess(value => Result<double, string, float>.FromSuccess(23.43));

		var finalValue = bound.Match(
			success => throw new UnreachableException(),
			error => error,
			otherErrors => throw new UnreachableException());

		Assert.Equal("Original error", finalValue);
	}

	[Fact]
	public async Task AsyncBindVariants_Work()
	{
		var taskResult = Task.FromResult(Result<int, bool, float>.FromSuccess(10));
		var boundTaskAsync = await taskResult.BindSuccess(async value =>
		{
			await Task.Yield();
			return Result<double, bool, float>.FromSuccess(value * 2.5);
		});

		var taskAsyncValue = boundTaskAsync.Match(
			success => success,
			error => throw new UnreachableException(),
			otherErrors => throw new UnreachableException());

		Assert.Equal(25.0, taskAsyncValue);

		var result = Result<int, bool, float>.FromSuccess(7);
		var boundAsync = await result.BindSuccess(async value =>
		{
			await Task.Yield();
			return Result<string, bool, float>.FromSuccess($"Processed: {value * 3}");
		});

		var asyncValue = boundAsync.Match(
			success => success,
			error => throw new UnreachableException(),
			otherErrors => throw new UnreachableException());

		Assert.Equal("Processed: 21", asyncValue);

		var errorTaskResult = Task.FromResult(Result<int, bool, float>.FromError(3.14f));
		var boundTask = await errorTaskResult.BindSuccess(value => Result<string, bool, float>.FromSuccess(value.ToString()));

		var errorPassThrough = boundTask.Match(
			success => throw new UnreachableException(),
			error => throw new UnreachableException(),
			otherErrors => true);

		Assert.True(errorPassThrough);
	}

	[Fact]
	public async Task BindPipeline_Works()
	{
		Assert.Equal("Success: 36", await Process(Result<int, SomeError, double>.FromSuccess(12)));
		Assert.Equal("Input error", await Process(Result<int, SomeError, double>.FromError(new SomeError("Input error"))));
		Assert.Equal("Processing error: Value too large", await Process(Result<int, SomeError, double>.FromSuccess(150)));
		return;

		async Task<string> Process(Result<int, SomeError, double> input) => await input
			.BindSuccess(async value =>
			{
				await Task.Yield();
				return value > 100
					? Result<int, SomeError, double>.FromError(new SomeError("Processing error: Value too large"))
					: Result<int, SomeError, double>.FromSuccess(value * 3);
			})
			.BindSuccess(value => Result<string, SomeError, double>.FromSuccess($"Success: {value}"))
			.Match(
				success => success,
				error => error.Message,
				otherErrors => $"Other error: {otherErrors}");
	}

	[Fact]
	public void BindError_WithError_Works()
	{
		var result = Result<int, string, float>.FromError("Error message");

		var bound = result.BindError0(errorMsg => Result<int, DateTime, float>.FromError(DateTime.Parse("2020-01-01")));

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
			return Result<string, SomeError, float>.FromError(new SomeError("Transformed error"));
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

		var mapped = result.MapSuccess(value => value.ToString());

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

		var mapped = result.MapSuccess(value => value * 2);

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
		var mappedAsync = await result.MapSuccess<int>(async value =>
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
		var mappedTask = await errorTaskResult.MapSuccess(value => value.ToString());

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

		var mapped = result.MapError0(errorMsg => DateTime.Parse("2020-01-01"));

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
		var transformed = await result.MapError1<double>(async errorValue =>
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
			.MapError0<double>(async errorCode =>
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
		Assert.Equal("FINAL: 72", ProcessPipeline(Result<int, SomeError, double>.FromSuccess(7)));
		Assert.Equal("Error: Input error", ProcessPipeline(Result<int, SomeError, double>.FromError(new SomeError("Input error"))));
		Assert.Equal("Error: Value is negative", ProcessPipeline(Result<int, SomeError, double>.FromSuccess(-5)));
		Assert.Equal("Other error: 99.5", ProcessPipeline(Result<int, SomeError, double>.FromError(99.5)));
		return;

		string ProcessPipeline(Result<int, SomeError, double> input) =>
			input.MapSuccess(value => value * 2)
				.BindSuccess(value => value < 0
					? Result<int, SomeError, double>.FromError(new SomeError("Value is negative"))
					: Result<int, SomeError, double>.FromSuccess(value + 10))
				.MapError0(errorMsg => new SomeError($"Error: {errorMsg.Message}"))
				.MapSuccess(value => value * 3)
				.BindSuccess(value => Result<string, SomeError, double>.FromSuccess($"FINAL: {value}"))
				.Match(
					success => success,
					error => error.Message,
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
	public void TapAndFilterPipeline_Works()
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
				.FilterSuccess(
					value => value > 0,
					() =>
					{
						logMessages.Add($"Validation failed for: {input}");
						return Result<int, string, double>.FromError("Value must be positive");
					})
				.MapSuccess(value => value * 2)
				.TapSuccess(value => { logMessages.Add($"Doubled value: {value}"); })
				.FilterSuccess(
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

	[Fact]
	public void Combine_AllSuccess_CallsCombineSuccess()
	{
		var result1 = Result<int, SomeError, double>.FromSuccess(10);
		var result2 = Result<string, SomeError, double>.FromSuccess("test");

		var combined = Result.Combine(
			result1,
			result2,
			(num, str) => $"{str}-{num}",
			(errors0, errors1) => "Error case should not be reached");

		Assert.Equal("test-10", combined);
	}

	[Fact]
	public void Combine_Works()
	{
		var result1 = Result<int, string, double>.FromError("Error 1");
		var result2 = Result<DateTime, string, double>.FromSuccess(DateTime.Now);

		var combined = Result.Combine(
			result1,
			result2,
			(num, str) => "Success case should not be reached",
			(errors0, errors1) => $"Errors: {string.Join(", ", errors0)}");

		Assert.Equal("Errors: Error 1", combined);

		result1 = Result<int, string, double>.FromSuccess(10);
		result2 = Result<DateTime, string, double>.FromSuccess(DateTime.Now);

		combined = Result.Combine(
			result1,
			result2,
			(num, str) => "Success case should be reached",
			(errors0, errors1) => $"Errors: {string.Join(", ", errors0)}");

		Assert.Equal("Success case should be reached", combined);
	}

	[Fact]
	public void Combine_BothErrors_CollectsAllErrors()
	{
		var result1 = Result<int, string, double>.FromError("Error 1");
		var result2 = Result<bool, string, double>.FromError("Error 2");

		var combined = Result.Combine(
			result1,
			result2,
			(num, str) => "Success case should not be reached",
			(errors0, errors1) => $"Errors: {string.Join(", ", errors0.Concat(errors1.Select(err => err.ToString(CultureInfo.InvariantCulture))))}");

		Assert.Equal("Errors: Error 1, Error 2", combined);
	}

	[Fact]
	public void Combine_MixedErrorTypes_CollectsTypedErrors()
	{
		var result1 = Result<int, string, double>.FromError(123.45);
		var result2 = Result<bool, string, double>.FromError("Error string");

		var combined = Result.Combine(
			result1,
			result2,
			(num, str) => "Success case should not be reached",
			(errors0, errors1) => $"String errors: {string.Join(", ", errors0)}, Double errors: {string.Join(", ", errors1)}");

		Assert.Equal("String errors: Error string, Double errors: 123.45", combined);
	}

	[Fact]
	public void Combine_ThreeResults_AllSuccess()
	{
		var result1 = Result<int, SomeError, double>.FromSuccess(10);
		var result2 = Result<string, SomeError, double>.FromSuccess("test");
		var result3 = Result<bool, SomeError, double>.FromSuccess(true);

		var combined = Result.Combine(
			result1,
			result2,
			result3,
			(num, str, boolean) => $"{str}-{num}-{boolean}",
			(errors0, errors1) => "Error case should not be reached");

		Assert.Equal("test-10-True", combined);
	}

	[Fact]
	public void Combine_ThreeResults_MixedErrors()
	{
		var result1 = Result<int, string, double>.FromSuccess(10);
		var result2 = Result<bool, string, double>.FromError("Error 2");
		var result3 = Result<bool, string, double>.FromError(99.9);

		var combined = Result.Combine(
			result1,
			result2,
			result3,
			(num, str, boolean) => "Success case should not be reached",
			(errors0, errors1) => $"String errors: {errors1.Count}, Double errors: {errors0.Count}");

		Assert.Equal("String errors: 1, Double errors: 1", combined);
	}

	[Fact]
	public async Task Combine_Async_AllSuccess()
	{
		var result1 = Task.FromResult(Result<int, string, double>.FromSuccess(10));
		var result2 = Task.FromResult(Result<bool, string, double>.FromSuccess(true));

		var combined = await Result.Combine(
			result1,
			result2,
			async (num, boolean) =>
			{
				await Task.Yield();
				return $"{boolean}-{num}";
			},
			async (errors0, errors1) =>
			{
				await Task.Yield();
				return "Error case should not be reached";
			});

		Assert.Equal("True-10", combined);
	}

	[Fact]
	public async Task Combine_Async_WithErrors()
	{
		var result1 = Task.FromResult(Result<int, SomeError, double>.FromError(new SomeError("Error 1")));
		var result2 = Task.FromResult(Result<string, SomeError, double>.FromError(123.45));

		var combined = await Result.Combine(
			result1,
			result2,
			async (num, str) =>
			{
				await Task.Yield();
				return "Success case should not be reached";
			},
			async (errors0, errors1) =>
			{
				await Task.Yield();
				return $"Errors collected: {errors0.Count + errors1.Count}";
			});

		Assert.Equal("Errors collected: 2", combined);
	}

	[Fact]
	public async Task Combine_Async_WithCancellation()
	{
		var result1 = Task.FromResult(Result<int, SomeError, double>.FromSuccess(10));
		var result2 = Task.FromResult(Result<string, SomeError, double>.FromSuccess("test"));
		var cts = new CancellationTokenSource();

		var combined = Result.Combine(
			result1,
			result2,
			async (num, str) =>
			{
				await Task.Yield();
				return $"{str}-{num}";
			},
			async (errors0, errors1) =>
			{
				await Task.Yield();
				return "Error case should not be reached";
			},
			cts.Token);

		await cts.CancelAsync();

		Assert.Equal("test-10", await combined);
		await Assert.ThrowsAsync<TaskCanceledException>(async () =>
		{
			await Result.Combine(
				result1,
				result2,
				async (num, str) =>
				{
					await Task.Delay(1000, cts.Token);
					return $"{str}-{num}";
				},
				async (errors0, errors1) =>
				{
					await Task.Delay(1000, cts.Token);
					return "Error case should not be reached";
				},
				cts.Token);
		});
	}

	[Fact]
	public void Combine_PracticalExample_ValidationScenario()
	{
		var nameValidation = ValidateName("John Doe");
		var ageValidation = ValidateAge(25);
		var emailValidation = ValidateEmail("john@example.com");

		var validationResult = Result.Combine(
			nameValidation,
			ageValidation,
			emailValidation,
			(name, age, email) => Result<User, string>.FromSuccess(new User(name, age, email)),
			(stringErrors, doubleErrors) => string.Join(", ", stringErrors));

		validationResult.Match(
			user =>
			{
				Assert.Equal("John Doe", user.Name);
				Assert.Equal(25, user.Age);
				Assert.Equal("john@example.com", user.Email);
				return 0;
			},
			error => throw new UnreachableException());

		var invalidNameValidation = ValidateName("");
		var invalidAgeValidation = ValidateAge(-5);
		var invalidEmailValidation = ValidateEmail("not-an-email");

		var invalidResult = Result.Combine(
			invalidNameValidation,
			invalidAgeValidation,
			invalidEmailValidation,
			(name, age, email) => Result<User, string>.FromSuccess(new User(name, age, email)),
			(stringErrors, doubleErrors) => string.Join(", ", stringErrors.Select(error => error.Message)));

		Assert.Equal("Name cannot be empty, Age must be positive, Invalid email format", invalidResult);
		return;

		static Result<string, SomeError, double> ValidateName(string name) =>
			!string.IsNullOrEmpty(name)
				? Result<string, SomeError, double>.FromSuccess(name)
				: Result<string, SomeError, double>.FromError(new SomeError("Name cannot be empty"));

		static Result<int, SomeError, double> ValidateAge(int age) =>
			age > 0
				? Result<int, SomeError, double>.FromSuccess(age)
				: Result<int, SomeError, double>.FromError(new SomeError("Age must be positive"));

		static Result<string, SomeError, double> ValidateEmail(string email) =>
			email.Contains('@')
				? Result<string, SomeError, double>.FromSuccess(email)
				: Result<string, SomeError, double>.FromError(new SomeError("Invalid email format"));
	}

	[Fact]
	public void Extend_Works()
	{
		var initialResult = Result<string, int>.FromSuccess("hello");

		var extendedResult = initialResult.Extend<string, int, double>();

		extendedResult.Match(
			success =>
			{
				Assert.Equal("hello", success);
				return None.Instance;
			},
			error =>
			{
				Assert.Fail("Should be Success");
				return None.Instance;
			});
	}

	[Fact]
	public async Task ExtendAsync_Works()
	{
		var initialResult = Task.FromResult(Result<string, int>.FromSuccess("world"));

		var extendedResult = await initialResult.Extend<string, int, bool>();

		extendedResult.Match(
			success =>
			{
				Assert.Equal("world", success);
				return None.Instance;
			},
			error =>
			{
				Assert.Fail("Should be Success");
				return None.Instance;
			});
	}

	[Theory]
	[InlineData("John", "Doe", 25, "john.doe@example.com", true, null)]
	[InlineData("Jane", "Smith", 17, "jane.smith@example.com", false, "Age")]
	[InlineData("Bob", "Johnson", 30, "bobexample.com", false, "Email")]
	[InlineData("Alice", "Brown", 16, "aliceexample.com", false, "Age")]
	public void CreateUserPipeline_Works(string firstName, string lastName, int age, string email, bool shouldSucceed, string expectedErrorField)
	{
		var request = new CreateUserRequest(firstName, lastName, age, email);
		var result = CreateUser(request);

		if (shouldSucceed)
		{
			var userString = result.Match(
				user => $"User created: {user.Name}",
				validationError => $"Validation error: {validationError.Error}",
				databaseError => "Database error",
				emailSendingError => "Email sending error");

			Assert.StartsWith("User created:", userString);
		}
		else
		{
			var errorString = result.Match(
				user => $"User created: {user.Name}",
				validationError => $"Validation error: {validationError.Error} ({validationError.FieldName})",
				databaseError => "Database error",
				emailSendingError => "Email sending error");

			Assert.Contains(expectedErrorField, errorString);
		}
	}

	private static UserResult CreateUser(CreateUserRequest request) =>
		Result.Combine<UserResult, string, int, string, ValidationError>(
				$"{request.FirstName} {request.LastName}",
				ValidateAge(request.Age),
				ValidateEmail(request.Email),
				(name, age, email) => UserResult.FromSuccess(new User(name, age, email)),
				errors => errors[0])
			.BindSuccess(user => SaveUserToDb(user)
				.Match(
					UserResult.FromSuccess,
					error => error))
			.MapSuccess(user => user with
			{
				Age = 128
			})
			.BindSuccess(UserResult.FromSuccess);

	private static Result<int, ValidationError> ValidateAge(int age) =>
		age >= 18
			? Result<int, ValidationError>.FromSuccess(age)
			: Result<int, ValidationError>.FromError(new ValidationError("Users must be 18 or older", nameof(CreateUserRequest.Age)));

	private static Result<string, ValidationError> ValidateEmail(string email) =>
		email.Contains('@')
			? Result<string, ValidationError>.FromSuccess(email)
			: Result<string, ValidationError>.FromError(new ValidationError("Email must contain '@'", nameof(CreateUserRequest.Email)));

	public static Result<User, DatabaseError> SaveUserToDb(User user) => user;

	private readonly record struct SomeError(string Message);

	public sealed record class CreateUserRequest(string FirstName, string LastName, int Age, string Email);

	public sealed record class User(string Name, int Age, string Email);

	public sealed record class ValidationError(string Error, string FieldName);

	public sealed record class DatabaseError(Exception Error);

	public sealed record class EmailSendingError(Exception Error);
}