namespace FuncNet.Test;

public class OptionTests
{
	private const int DEFAULT_VALUE = 42;
	private const string DEFAULT_STRING_VALUE = "test value";
	private const string NOT_FOUND_MESSAGE = "not found";

	[Fact]
	public void Instantiation_AllMethods_WorkAsExpected()
	{
		var someOption = Option<string>.Some(DEFAULT_STRING_VALUE);
		var noneOption = Option<string>.None;

		var nonNullValue = "non-null";
		var someFromNullable = Option<string>.FromNullable(nonNullValue);

		string? nullValue = null;
		var noneFromNullable = Option<string>.FromNullable(nullValue);

		Assert.Equal(DEFAULT_STRING_VALUE, someOption.Match(value => value, () => null));
		Assert.Null(noneOption.Match(value => value, () => null));
		Assert.Equal(nonNullValue, someFromNullable.Match(value => value, () => null));
		Assert.Null(noneFromNullable.Match(value => value, () => null));
	}

	[Fact]
	public async Task AsyncInstantiation_AllMethods_WorkAsExpected()
	{
		var someOption = await Option<string>.Some(Task.FromResult("async value"));
		var someFromNullable = await Option<string>.FromNullable(Task.FromResult<string?>("async non-null"));
		var noneFromNullable = await Option<string>.FromNullable(Task.FromResult<string?>(null));

		Assert.Equal("async value", someOption.Match(value => value, () => null));
		Assert.Equal("async non-null", someFromNullable.Match(value => value, () => null));
		Assert.Null(noneFromNullable.Match(value => value, () => null));
	}

	[Fact]
	public void Match_SomeAndNone_ReturnsExpectedValues()
	{
		var someOption = Option<int>.Some(DEFAULT_VALUE);
		var noneOption = Option<int>.None;

		var someResult = someOption.Match(
			value => $"The answer is {value}",
			() => "No answer available");

		var noneResult = noneOption.Match(
			value => $"The answer is {value}",
			() => "No answer available");

		Assert.Equal($"The answer is {DEFAULT_VALUE}", someResult);
		Assert.Equal("No answer available", noneResult);
	}

	[Fact]
	public async Task AsyncMatch_AllVariants_WorkAsExpected()
	{
		var taskSomeOption = Task.FromResult(Option<int>.Some(DEFAULT_VALUE));
		var taskNoneOption = Task.FromResult(Option<int>.None);
		var someOption = Option<int>.Some(DEFAULT_VALUE);
		var noneOption = Option<int>.None;

		var expectedSome = $"The answer is {DEFAULT_VALUE}";
		var expectedNone = "No answer available";

		// Task<Option> with sync functions
		Assert.Equal(expectedSome, await taskSomeOption.Match(
			value => $"The answer is {value}",
			() => expectedNone));

		Assert.Equal(expectedNone, await taskNoneOption.Match(
			value => $"The answer is {value}",
			() => expectedNone));

		// Option with async functions
		Assert.Equal(expectedSome, await someOption.Match(
			async value =>
			{
				await Task.Delay(1);
				return $"The answer is {value}";
			},
			async () =>
			{
				await Task.Delay(1);
				return expectedNone;
			}));

		Assert.Equal(expectedNone, await noneOption.Match(
			async value =>
			{
				await Task.Delay(1);
				return $"The answer is {value}";
			},
			async () =>
			{
				await Task.Delay(1);
				return expectedNone;
			}));

		// Task<Option> with async functions
		Assert.Equal(expectedSome, await taskSomeOption.Match(
			async value =>
			{
				await Task.Delay(1);
				return $"The answer is {value}";
			},
			async () =>
			{
				await Task.Delay(1);
				return expectedNone;
			}));

		Assert.Equal(expectedNone, await taskNoneOption.Match(
			async value =>
			{
				await Task.Delay(1);
				return $"The answer is {value}";
			},
			async () =>
			{
				await Task.Delay(1);
				return expectedNone;
			}));
	}

	[Fact]
	public void MapValue_SomeAndNone_TransformsCorrectly()
	{
		var someOption = Option<int>.Some(DEFAULT_VALUE);
		var noneOption = Option<int>.None;

		var mappedSome = someOption.Map(x => x.ToString());
		var mappedNone = noneOption.Map(x => x.ToString());

		Assert.Equal(DEFAULT_VALUE.ToString(), mappedSome.Match(value => value, () => NOT_FOUND_MESSAGE));
		Assert.Equal(NOT_FOUND_MESSAGE, mappedNone.Match(value => value, () => NOT_FOUND_MESSAGE));
	}

	[Fact]
	public async Task AsyncMapValue_AllVariants_TransformCorrectly()
	{
		var taskSomeOption = Task.FromResult(Option<int>.Some(DEFAULT_VALUE));
		var someOption = Option<int>.Some(DEFAULT_VALUE);
		var expected = DEFAULT_VALUE.ToString();

		var mappedTaskSome = await taskSomeOption.Map(x => x.ToString());

		// var asyncMappedSome = await someOption.MapValue(async x =>
		// {
		// 	await Task.Delay(1);
		// 	return x.ToString();
		// });
		var asyncMappedTaskSome = await taskSomeOption.Map(async x =>
		{
			await Task.Delay(1);
			return x.ToString();
		});

		Assert.Equal(expected, mappedTaskSome.Match(value => value, () => NOT_FOUND_MESSAGE));

		// Assert.Equal(expected, asyncMappedSome.Match(value => value, () => NotFoundMessage));
		Assert.Equal(expected, asyncMappedTaskSome.Match(value => value, () => NOT_FOUND_MESSAGE));
	}

	[Fact]
	public void BindValue_AllCases_ChainsOperationsCorrectly()
	{
		var someOption = Option<int>.Some(DEFAULT_VALUE);
		var noneOption = Option<int>.None;

		var boundSomeToSome = someOption.Bind(x => Option<string>.Some(x.ToString()));
		var boundSomeToNone = someOption.Bind(x => Option<string>.None);
		var boundNone = noneOption.Bind(x => Option<string>.Some(x.ToString()));

		Assert.Equal(DEFAULT_VALUE.ToString(), boundSomeToSome.Match(value => value, () => NOT_FOUND_MESSAGE));
		Assert.Equal(NOT_FOUND_MESSAGE, boundSomeToNone.Match(value => value, () => NOT_FOUND_MESSAGE));
		Assert.Equal(NOT_FOUND_MESSAGE, boundNone.Match(value => value, () => NOT_FOUND_MESSAGE));
	}

	[Fact]
	public async Task AsyncBindValue_AllVariants_WorkAsExpected()
	{
		var taskSomeOption = Task.FromResult(Option<int>.Some(DEFAULT_VALUE));
		var someOption = Option<int>.Some(DEFAULT_VALUE);
		var expected = DEFAULT_VALUE.ToString();

		var boundTaskSome = await taskSomeOption.Bind(x => Option<string>.Some(x.ToString()));
		var asyncBoundSome = await someOption.Bind(async x =>
		{
			await Task.Delay(1);
			return Option<string>.Some(x.ToString());
		});
		var asyncBoundTaskSome = await taskSomeOption.Bind(async x =>
		{
			await Task.Delay(1);
			return Option<string>.Some(x.ToString());
		});

		Assert.Equal(expected, boundTaskSome.Match(value => value, () => NOT_FOUND_MESSAGE));
		Assert.Equal(expected, asyncBoundSome.Match(value => value, () => NOT_FOUND_MESSAGE));
		Assert.Equal(expected, asyncBoundTaskSome.Match(value => value, () => NOT_FOUND_MESSAGE));
	}

	[Fact]
	public void FilterValue_AllCases_FiltersProperly()
	{
		var someOption = Option<int>.Some(DEFAULT_VALUE);
		var noneOption = Option<int>.None;

		var filteredSomePass = someOption.Filter(x => x > 10);
		var filteredSomeFail = someOption.Filter(x => x < 10);
		var filteredNone = noneOption.Filter(x => x > 10);

		Assert.Equal(DEFAULT_VALUE, filteredSomePass.Match(value => value, () => -1));
		Assert.Equal(-1, filteredSomeFail.Match(value => value, () => -1));
		Assert.Equal(-1, filteredNone.Match(value => value, () => -1));
	}

	[Fact]
	public async Task AsyncFilterValue_AllVariants_WorkAsExpected()
	{
		var taskSomeOption = Task.FromResult(Option<int>.Some(DEFAULT_VALUE));
		var someOption = Option<int>.Some(DEFAULT_VALUE);

		var filteredTaskSome = await taskSomeOption.Filter(x => x > 10);

		var asyncFilteredSome = await someOption.Filter(
			async x =>
			{
				await Task.Delay(1);
				return x > 10;
			});

		Assert.Equal(DEFAULT_VALUE, filteredTaskSome.Match(value => value, () => -1));
		Assert.Equal(DEFAULT_VALUE, asyncFilteredSome.Match(value => value, () => -1));
	}

	[Fact]
	public void TapValue_SomeAndNone_AppliesSideEffectsCorrectly()
	{
		var sideEffects = new List<string>();
		var someOption = Option<int>.Some(DEFAULT_VALUE);
		var noneOption = Option<int>.None;

		var tappedSome = someOption.TapValue(x => sideEffects.Add($"Value: {x}"));
		var tappedNone = noneOption.TapValue(x => sideEffects.Add("Should not be added"));

		Assert.Equal(DEFAULT_VALUE, tappedSome.Match(value => value, () => -1));
		Assert.Equal(-1, tappedNone.Match(value => value, () => -1));

		Assert.Single(sideEffects);
		Assert.Equal($"Value: {DEFAULT_VALUE}", sideEffects[0]);
	}

	[Fact]
	public async Task AsyncTapValue_AllVariants_WorkAsExpected()
	{
		var sideEffects = new List<string>();
		var taskSomeOption = Task.FromResult(Option<int>.Some(DEFAULT_VALUE));
		var someOption = Option<int>.Some(24);

		var tappedTaskSome = await taskSomeOption.TapValue(x => sideEffects.Add($"Task value: {x}"));
		var asyncTappedSome = await someOption.TapValue(async x =>
		{
			await Task.Delay(1);
			sideEffects.Add($"Async value: {x}");
		});

		Assert.Equal(2, sideEffects.Count);
		Assert.Equal($"Task value: {DEFAULT_VALUE}", sideEffects[0]);
		Assert.Equal("Async value: 24", sideEffects[1]);
	}

	[Fact]
	public void ToEnumerable_SomeAndNone_ConvertsCorrectly()
	{
		var someOption = Option<string>.Some("test");
		var noneOption = Option<string>.None;

		var someEnumerable = someOption.ToEnumerable();
		var noneEnumerable = noneOption.ToEnumerable();

		Assert.Single(someEnumerable);
		Assert.Equal("test", someEnumerable.First());
		Assert.Empty(noneEnumerable);
	}

	[Theory]
	[InlineData("John", "JOHN is 4 letters long")]
	[InlineData("", "No name provided")]
	[InlineData("X", "NAME MUST BE AT LEAST 2 CHARACTERS is 34 letters long")]
	public void PipelinedOperations_CombineFunctionalityCorrectly(string input, string expected)
	{
		Assert.Equal(expected, ProcessName(input));
	}

	private static string ProcessName(string input) =>
		Option<string>.FromNullable(input)
			.Filter(name => !string.IsNullOrEmpty(name))
			.Bind(name => name.Length >= 2
				? Option<string>.Some(name)
				: Option<string>.Some("Name must be at least 2 characters"))
			.Map(name => name.ToUpper())
			.TapValue(name => Console.WriteLine($"Processing: {name}"))
			.Match(
				name => name.Contains(" at least") || name.Contains("cannot")
					? name
					: $"{name} is {name.Length} letters long",
				() => "No name provided");
}