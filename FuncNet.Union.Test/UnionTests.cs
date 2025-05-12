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
}