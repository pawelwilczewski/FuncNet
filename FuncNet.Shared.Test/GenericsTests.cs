using FuncNet.Shared.Common;

namespace FuncNet.Shared.Test;

public sealed class GenericsTests
{
	[Test]
	[TestCase("Union<string, int, bool>", "string, int, bool")]
	[TestCase("Union<string, Result<int, DateTime, decimal>, bool>", "string, Result<int, DateTime, decimal>, bool")]
	public void UnwrapGenericArgs_Works(string typeName, string expectedArgs)
	{
		Assert.That(typeName.UnwrapGenericArgs(), Is.EqualTo(expectedArgs));
	}

	[Test]
	[TestCase("Task<int, string, bool>", "int, string, bool")]
	[TestCase("Task<int, Union<string, bool>>", "int, Union<string, bool>")]
	[TestCase("Task<int, Task<string>, bool>", "int, Task<string>, bool")]
	[TestCase("SomeNamespace.Task<int, Task<string>, bool>", "int, Task<string>, bool")]
	[TestCase("Result<int, string, bool>", "Result<int, string, bool>")]
	[TestCase("int", "int")]
	public void UnwrapTaskGenericArg_Works(string typeName, string expectedArgs)
	{
		Assert.That(typeName.UnwrapTaskGenericArg(), Is.EqualTo(expectedArgs));
	}
}