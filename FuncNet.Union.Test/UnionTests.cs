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
}