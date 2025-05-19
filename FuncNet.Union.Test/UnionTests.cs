namespace FuncNet.Union.Test;

public class UnionTests
{
	[Fact]
	public void Instantiation_Compiles()
	{
		Union<string, int, float> a = 12;
		Assert.IsType<Union<string, int, float>>(a);

		Union<string, int, float> b = "Hello!";
		Assert.IsType<Union<string, int, float>>(b);

		var c = Union<string, float, int>.FromT0("value");
		Assert.IsType<Union<string, float, int>>(c);

		var d = Union<string, float, int>.FromT0(Task.FromResult("async value"));
		Assert.IsType<Task<Union<string, float, int>>>(d);
	}

	[Fact]
	public void AssignmentFromSmaller_Compiles()
	{
		Union<string, int> a = 12;

		Union<string, int, float> b = a;
		Assert.IsType<Union<string, int, float>>(b);

		Union<string, int, float, DateTime> c = 13.43f;
		c = b;
		c = a;
		Assert.IsType<Union<string, int, float, DateTime>>(c);
	}

	[Fact]
	public void BasicMatch_Works()
	{
		Union<string, int> a = 12;

		var correct = a.Match(
			t0 => false,
			t1 => true);
		Assert.True(correct);

		a = "Hello!";
		correct = a.Match(
			t0 => true,
			t1 => false);
		Assert.True(correct);
	}

	[Fact]
	public void MatchWithOtherAsUnion_Works()
	{
		Union<string, int, double, DateTime> a = 12;

		var correct = a.Match(
			t0 => false,
			other => true);
		Assert.True(correct);

		a = DateTime.Now;
		correct = a.Match(
			t0 => false,
			t1 => false,
			other => other.Match(
				t0 => false,
				t1 => true));
		Assert.True(correct);
	}

	[Fact]
	public async Task AsyncMatchVariants_Work()
	{
		Union<string, int, DateTime, Guid> u1 = 123;
		var r1 = await u1.Match(
			t0 => Task.FromResult(t0.Length),
			t1 => Task.FromResult(t1 * 2),
			t2 => Task.FromResult(420),
			t3 => Task.FromResult(69));
		Assert.Equal(246, r1);

		var u2 = Task.FromResult<Union<string, int>>("four");
		var r2 = await u2.Match(
			t0 => t0.Length,
			t1 => t1 * 2);
		Assert.Equal(4, r2);

		var u3 = Task.FromResult<Union<string, int, double>>(7);
		var r3 = await u3.Match(
			t0 => Task.FromResult(t0.Length),
			t1 => Task.FromResult(t1 * 3),
			t2 => Task.FromResult(924));
		Assert.Equal(21, r3);

		Union<string, int> u4 = "abc";
		var r4 = await u4.Match(
			t0 => Task.FromResult(t0.Length),
			t1 => Task.FromResult(t1));
		Assert.Equal(3, r4);
	}

	[Fact]
	public async Task MapVariants_Work()
	{
		var u = Union<int, string, float>.FromT0(42);
		var mapped = u.Map0(i => $"Value is {i}");
		var result = mapped.Match(
			s => s,
			_ => throw new InvalidOperationException("Should not be here"),
			_ => throw new InvalidOperationException("Should not be here")
		);

		Assert.Equal("Value is 42", result);

		var uTask = Task.FromResult<Union<string, int, double>>(7);
		var mapped2 = await uTask.Map1(async i =>
		{
			await Task.Yield(); // simulate async work
			return i * 3.0;
		});

		var result2 = mapped2.Match(
			_ => throw new InvalidOperationException("Should not be here"),
			d => d,
			_ => throw new InvalidOperationException("Should not be here")
		);
		Assert.Equal(21.0, result2);

		Union<string, int, double> u0 = "hello";
		var passThru = await u0.Map2<DateTime, string, int, double>(async d => new DateTime());
		var passThruResult = passThru.Match(
			s => s,
			_ => throw new InvalidOperationException("Should not be here"),
			_ => throw new InvalidOperationException("Should not be here")
		);
		Assert.Equal("hello", passThruResult);

		var u2Task = Task.FromResult<Union<string, int, double>>(4.2);
		var mapped3 = await u2Task.Map2(async d =>
		{
			await Task.Yield();
			return (d * 2).ToString("F1");
		});

		var mapped3Result = mapped3.Match(
			_ => throw new InvalidOperationException("Should not be here"),
			_ => throw new InvalidOperationException("Should not be here"),
			s => s
		);
		Assert.Equal("8.4", mapped3Result);
	}

	[Fact]
	public async Task BindVariants_Work()
	{
		var result0 = Union<int, string, float>.FromT0(42)
			.Bind0(i => Union<int, string, float>.FromT1($"Value: {i}"))
			.Match(
				_ => throw new InvalidOperationException("Should not be here"),
				s => s,
				_ => throw new InvalidOperationException("Should not be here")
			);
		Assert.Equal("Value: 42", result0);

		var result1 = await Task.FromResult<Union<string, int, double>>(7)
			.Bind1(async i =>
			{
				await Task.Yield();
				return Union<string, int, double>.FromT2(i * 3.0);
			})
			.Match(
				_ => throw new InvalidOperationException("Should not be here"),
				_ => throw new InvalidOperationException("Should not be here"),
				d => d);
		Assert.Equal(21.0, result1);

		Union<string, int, double> u2 = "hello";
		var passThroughResult = await u2
			.Bind2<DateTime, string, int, double>(async d =>
			{
				await Task.Yield();
				return new DateTime(2000, 1, 1);
			})
			.Match(
				s => s,
				_ => throw new InvalidOperationException("Should not be here"),
				_ => throw new InvalidOperationException("Should not be here")
			);
		Assert.Equal("hello", passThroughResult);

		var result2 = await Task.FromResult<Union<string, int, double>>(4.2)
			.Bind2(async d =>
			{
				await Task.Yield();
				return Union<string, int, double>.FromT0((d * 2).ToString("F1"));
			})
			.Match(
				s => s,
				_ => throw new InvalidOperationException("Should not be here"),
				s => throw new InvalidOperationException("Should not be here")
			);
		Assert.Equal("8.4", result2);
	}

	[Fact]
	public void MapThenBindThenMatch_PipelineExample()
	{
		Assert.Equal("ERROR: initial error", Process(Union<string, int, double>.FromT0("initial error")));
		Assert.Equal("Final normalized value is 9.00", Process(10));
		Assert.Equal("ERROR: Value -3 is below zero", Process(-8));
		Assert.Equal("Final normalized value is 8.00", Process(Union<string, int, double>.FromT2(16.0)));
		return;

		string Process(Union<string, int, double> input) =>
			input
				.Map1(raw => raw + 5)
				.Bind1(calibrated => calibrated < 0
					? Union<string, int, double>.FromT0($"Value {calibrated} is below zero")
					: Union<string, int, double>.FromT2(calibrated * 1.2))
				.Map2(d => d / 2.0)
				.Map0(err => $"ERROR: {err}")
				.Match(
					errMsg => errMsg,
					_ => throw new InvalidOperationException(),
					normalizedDouble => $"Final normalized value is {normalizedDouble:F2}");
	}

	[Fact]
	public void TapVariants_Work()
	{
		var sideEffects = new List<string>();

		var u1 = Union<string, int, double>.FromT0("test string");
		var result1 = u1.Tap0(s => sideEffects.Add($"Tapped string: {s}"));

		Assert.Single(sideEffects);
		Assert.Equal("Tapped string: test string", sideEffects[0]);

		var originalValue = result1.Match(
			s => s,
			_ => throw new InvalidOperationException("Should not be here"),
			_ => throw new InvalidOperationException("Should not be here"));
		Assert.Equal("test string", originalValue);

		Union<string, int, double> u2 = 42;
		var result2 = u2.Tap1(i => sideEffects.Add($"Tapped int: {i}"));

		Assert.Equal(2, sideEffects.Count);
		Assert.Equal("Tapped int: 42", sideEffects[1]);

		Union<string, int, double> u3 = 3.14;
		var result3 = u3.Tap1(i => sideEffects.Add("This shouldn't be added"));

		Assert.Equal(2, sideEffects.Count);

		var finalValue = result3.Match(
			_ => throw new InvalidOperationException("Should not be here"),
			_ => throw new InvalidOperationException("Should not be here"),
			d => d);
		Assert.Equal(3.14, finalValue);
	}

	[Fact]
	public async Task AsyncTapVariants_Work()
	{
		var sideEffects = new List<string>();

		var taskUnion = Task.FromResult<Union<string, int, double>>("async test");
		var result1 = await taskUnion.Tap0(async s =>
		{
			await Task.Delay(10);
			sideEffects.Add($"Async tapped: {s}");
		});

		Assert.Single(sideEffects);
		Assert.Equal("Async tapped: async test", sideEffects[0]);

		var originalValue = result1.Match(
			s => s,
			_ => throw new InvalidOperationException("Should not be here"),
			_ => throw new InvalidOperationException("Should not be here"));
		Assert.Equal("async test", originalValue);

		Union<string, int, double> u2 = 42;
		var result2 = await u2.Tap1(async i =>
		{
			await Task.Delay(10);
			sideEffects.Add($"Async tapped int: {i}");
		});

		Assert.Equal(2, sideEffects.Count);
		Assert.Equal("Async tapped int: 42", sideEffects[1]);

		Union<string, int, double> u3 = 3.14;
		var result3 = await u3.Tap0(async s =>
		{
			await Task.Delay(10);
			sideEffects.Add("This shouldn't be added");
		});

		Assert.Equal(2, sideEffects.Count);
	}

	[Fact]
	public void TapInPipeline_Works()
	{
		var logs = new List<string>();

		Assert.Equal("Value processed to: 7.5", ProcessWithLogging(5, logs));
		Assert.Equal(3, logs.Count);
		Assert.Equal("Processing input: 5", logs[0]);
		Assert.Equal("After conversion: 10.0", logs[1]);
		Assert.Equal("Final result: 7.5", logs[2]);

		logs.Clear();
		Assert.Equal("Error: Input was zero", ProcessWithLogging(0, logs));
		Assert.Equal(2, logs.Count);
		Assert.Equal("Processing input: 0", logs[0]);

		logs.Clear();
		Assert.Equal("Error: Value too large", ProcessWithLogging(100, logs));
		Assert.Equal(3, logs.Count);
		Assert.Equal("Processing input: 100", logs[0]);
		Assert.Equal("After conversion: 200.0", logs[1]);
		Assert.Equal("Error detected: Value too large", logs[2]);
		return;

		static string ProcessWithLogging(int input, List<string> logList) =>
			Union<string, int, double>.FromT1(input)
				.Tap1(i => logList.Add($"Processing input: {i}"))
				.Bind1(i => i == 0
					? Union<string, int, double>.FromT0("Input was zero")
					: Union<string, int, double>.FromT2(i * 2.0))
				.Tap2(d => logList.Add($"After conversion: {d:F1}"))
				.Bind2(d => d > 100
					? Union<string, int, double>.FromT0("Value too large")
					: Union<string, int, double>.FromT2(d * 0.75))
				.Tap0(err => logList.Add($"Error detected: {err}"))
				.Tap2(result => logList.Add($"Final result: {result:F1}"))
				.Match(
					error => $"Error: {error}",
					i => $"Integer value: {i}",
					d => $"Value processed to: {d:F1}");
	}

	[Fact]
	public void EnsureVariants_Work()
	{
		Union<string, int, double> u1 = "test";
		var result1 = u1.Ensure0(
			s => s.Length > 2,
			() => Union<string, int, double>.FromT0("error"));

		var original = result1.Match(
			s => s,
			_ => string.Empty,
			_ => string.Empty);
		Assert.Equal("test", original);

		Union<string, int, double> u2 = "a";
		var result2 = u2.Ensure0(
			s => s.Length > 2,
			() => Union<string, int, double>.FromT1(42));

		var switched = result2.Match(
			_ => -1,
			i => i,
			_ => -1);
		Assert.Equal(42, switched);

		Union<string, int, double> u3 = 5;
		var result3 = u3.Ensure1(
			i => i > 10,
			() => Union<string, int, double>.FromT2(99.9));

		var valueType = result3.Match(
			_ => "string",
			_ => "int",
			_ => "double");
		Assert.Equal("double", valueType);

		Union<string, int, double> u4 = 20;
		var result4 = u4.Ensure1(
			i => i > 10,
			() => Union<string, int, double>.FromT0("should not happen"));

		Assert.Equal(20, result4.Match(
			_ => 0,
			i => i,
			_ => 0));
	}

	[Fact]
	public async Task AsyncEnsureVariants_Work()
	{
		var taskUnion = Task.FromResult<Union<string, int, double>>("short");
		var result1 = await taskUnion.Ensure0(
			async s =>
			{
				await Task.Delay(10);
				return s.Length > 5;
			},
			async () =>
			{
				await Task.Delay(10);
				return Union<string, int, double>.FromT1(123);
			});

		Assert.Equal(123, result1.Match(
			_ => 0,
			i => i,
			_ => 0));

		Union<string, int, double> u2 = 15.5;
		var result2 = await u2.Ensure2(
			async d =>
			{
				await Task.Delay(10);
				return d < 10.0;
			},
			async () =>
			{
				await Task.Delay(10);
				return Union<string, int, double>.FromT0("value too large");
			});

		Assert.Equal("value too large", result2.Match(
			s => s,
			_ => string.Empty,
			_ => string.Empty));
	}

	[Fact]
	public void EnsureInPipeline_Works()
	{
		var result = ProcessWithValidation(5);
		Assert.Equal("Processed value: 20", result);

		result = ProcessWithValidation(-5);
		Assert.Equal("Invalid input: Value must be positive", result);

		result = ProcessWithValidation(200);
		Assert.Equal("Invalid input: Value too large", result);

		return;

		static string ProcessWithValidation(int input) =>
			Union<string, int>.FromT1(input)
				.Ensure1(
					i => i > 0,
					() => Union<string, int>.FromT0("Value must be positive"))
				.Ensure1(
					i => i < 100,
					() => Union<string, int>.FromT0("Value too large"))
				.Match(
					errorMsg => $"Invalid input: {errorMsg}",
					i => $"Processed value: {i * 4}");
	}

	[Fact]
	public void Zip_SyncInput_SyncZip_Works()
	{
		var values = new List<Union<string, int, double>>
		{
			Union<string, int, double>.FromT0("apple"),
			Union<string, int, double>.FromT1(10),
			Union<string, int, double>.FromT0("banana"),
			Union<string, int, double>.FromT2(20.5),
			Union<string, int, double>.FromT1(5)
		};

		var result = values.Zip((strs, ints, dbls) =>
			$"S:{string.Join(",", strs.OrderBy(s => s))}|I:{string.Join(",", ints.OrderBy(i => i))}|D:{string.Join(",", dbls.OrderBy(d => d))}"
		);

		Assert.Equal("S:apple,banana|I:5,10|D:20.5", result);
	}

	[Fact]
	public void Zip_EmptyInput_SyncInput_SyncZip_Works()
	{
		var values = new List<Union<string, int, double>>();

		var result = values.Zip((strs, ints, dbls) =>
			$"S:{string.Join(",", strs.OrderBy(s => s))}|I:{string.Join(",", ints.OrderBy(i => i))}|D:{string.Join(",", dbls.OrderBy(d => d))}");

		Assert.Equal("S:|I:|D:", result);
	}

	[Fact]
	public async Task Zip_AsyncInput_AsyncZip_Works()
	{
		var values = new List<Task<Union<string, int, double>>>
		{
			Task.FromResult(Union<string, int, double>.FromT0("apple")),
			Task.FromResult(Union<string, int, double>.FromT1(10)),
			Task.FromResult(Union<string, int, double>.FromT0("banana")),
			Task.FromResult(Union<string, int, double>.FromT2(20.5)),
			Task.FromResult(Union<string, int, double>.FromT1(5))
		};

		var result = await values.Zip(async (strs, ints, dbls) =>
		{
			await Task.Yield();
			return $"S:{string.Join(",", strs.OrderBy(s => s))}|I:{string.Join(",", ints.OrderBy(i => i))}|D:{string.Join(",", dbls.OrderBy(d => d))}";
		});

		Assert.Equal("S:apple,banana|I:5,10|D:20.5", result);
	}

	[Fact]
	public async Task Zip_SyncInput_AsyncZip_Works()
	{
		var values = new List<Union<string, int, double>>
		{
			Union<string, int, double>.FromT0("apple"),
			Union<string, int, double>.FromT1(10),
			Union<string, int, double>.FromT0("banana"),
			Union<string, int, double>.FromT2(20.5),
			Union<string, int, double>.FromT1(5)
		};

		var result = await values.Zip(async (strs, ints, dbls) =>
		{
			await Task.Yield();
			return $"S:{string.Join(",", strs.OrderBy(s => s))}|I:{string.Join(",", ints.OrderBy(i => i))}|D:{string.Join(",", dbls.OrderBy(d => d))}";
		});

		Assert.Equal("S:apple,banana|I:5,10|D:20.5", result);
	}

	[Fact]
	public async Task Zip_AsyncInput_SyncZip_Works()
	{
		var values = new List<Task<Union<string, int, double>>>
		{
			Task.FromResult(Union<string, int, double>.FromT0("apple")),
			Task.FromResult(Union<string, int, double>.FromT1(10)),
			Task.FromResult(Union<string, int, double>.FromT0("banana")),
			Task.FromResult(Union<string, int, double>.FromT2(20.5)),
			Task.FromResult(Union<string, int, double>.FromT1(5))
		};

		var result = await values.Zip((strs, ints, dbls) =>
			$"S:{string.Join(",", strs.OrderBy(s => s))}|I:{string.Join(",", ints.OrderBy(i => i))}|D:{string.Join(",", dbls.OrderBy(d => d))}");

		Assert.Equal("S:apple,banana|I:5,10|D:20.5", result);
	}
}