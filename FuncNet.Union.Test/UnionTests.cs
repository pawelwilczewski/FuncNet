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
}