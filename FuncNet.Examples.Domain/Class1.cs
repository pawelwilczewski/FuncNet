namespace FuncNet.Examples.Domain;

public class Class1
{
	public Union<int, string, bool, decimal, float, DateTime> Value { get; set; }

	public static void Method()
	{
		Union<int, string, bool> test = 213;
		var test2 = test.Extend<int, string, bool, DateTime, decimal>();
		var test3 = Union<int, string, bool, DateTime>.FromT0(232);
		var test4 = Union<int, decimal, string, bool, DateTime>.FromT0(232);
		var test5 = Union<float, string, bool, DateTime>.FromT0(232);
	}
}