namespace FuncNet.Test;

public class ResultConversionTests
{
	[Fact]
	public void ResultToUnion_WhenSuccess_ReturnsUnionWithValue0()
	{
		var result = Result<int, string, bool>.FromSuccess(123);
		var union = result.ToUnion();

		var matchResult = union.Match(
			successVal =>
			{
				Assert.Equal(123, successVal);
				return "success";
			},
			error0Val =>
			{
				Assert.Fail("Should be success (was error0: " + error0Val + ")");
				return "error0";
			},
			error1Val =>
			{
				Assert.Fail("Should be success (was error1: " + error1Val + ")");
				return "error1";
			}
		);
		Assert.Equal("success", matchResult);
	}

	[Fact]
	public async Task ResultToUnion_WhenError0_ReturnsUnionWithValue1()
	{
		var result = Task.FromResult(Result<int, string, bool>.FromError("error_string"));
		var union = result.ToUnion();

		var matchResult = await union.Match(
			successVal =>
			{
				Assert.Fail("Should be error0 (was success: " + successVal + ")");
				return "success";
			},
			error0Val =>
			{
				Assert.Equal("error_string", error0Val);
				return "error0";
			},
			error1Val =>
			{
				Assert.Fail("Should be error0 (was error1: " + error1Val + ")");
				return "error1";
			}
		);
		Assert.Equal("error0", matchResult);
	}

	[Fact]
	public void ResultToUnion_WhenError1_ReturnsUnionWithValue2()
	{
		var result = Result<int, string, bool>.FromError(true);
		var union = result.ToUnion();

		var matchResult = union.Match(
			successVal =>
			{
				Assert.Fail("Should be error1 (was success: " + successVal + ")");
				return "success";
			},
			error0Val =>
			{
				Assert.Fail("Should be error1 (was error0: " + error0Val + ")");
				return "error0";
			},
			error1Val =>
			{
				Assert.True(error1Val);
				return "error1";
			}
		);
		Assert.Equal("error1", matchResult);
	}

	[Fact]
	public void ResultToOption_WhenSuccess_ReturnsSome()
	{
		var result = Result<int, string, bool>.FromSuccess(456);
		var option = result.ToOption();

		var matchResult = option.Match(
			someVal =>
			{
				Assert.Equal(456, someVal);
				return "some";
			},
			() =>
			{
				Assert.Fail("Should be Some");
				return "none";
			}
		);
		Assert.Equal("some", matchResult);
	}

	[Fact]
	public async Task ResultToOption_WhenError0_ReturnsNone()
	{
		var result = Task.FromResult(Result<int, string, bool>.FromError("another_error"));
		var option = result.ToOption();

		var matchResult = await option.Match(
			someVal =>
			{
				Assert.Fail("Should be None (was Some: " + someVal + ")");
				return "some";
			},
			() => "none");
		Assert.Equal("none", matchResult);
	}

	[Fact]
	public void ResultToOption_WhenError1_ReturnsNone()
	{
		var result = Result<int, string, bool>.FromError(false);
		var option = result.ToOption();

		var matchResult = option.Match(
			someVal =>
			{
				Assert.Fail("Should be None (was Some: " + someVal + ")");
				return "some";
			},
			() => "none");

		Assert.Equal("none", matchResult);
	}

	[Fact]
	public void ResultFromResult_Works()
	{
		Result<int, string, bool> a = Result<int, bool, string>.FromSuccess(123);
		Assert.True(a.Value.Is0);

		Result<int, string, bool, DateTime, int, double, float> b = Result<int, bool, float, double>.FromError(123.0f);
		Assert.True(a.Value.Is0);
	}

	[Fact]
	public void ResultFromAnotherResult_NotPermitted_WouldNotCompile()
	{
		// if the results below were unions, it would be fine to implicitly convert between them
		// however, given the semantic meaning of TSuccess of Result, it shouldn't be allowed for TResult
		Result<int, string, bool> a = 123;
		Result<bool, int, string> b = true;

		// check if there is an implicit conversion from Result<int, string, bool> to Result<bool, int, string>
		// ^ there shouldn't be
		Assert.DoesNotContain(typeof(ResultConversionTests).Assembly.DefinedTypes
				.SelectMany(t =>
					t.DeclaredMethods)
				.Where(m => m.Name == "op_Implicit"
					&& m.ReturnType.ToString().Contains("Result`3")),
			m => m.GetParameters().First().ParameterType.ToString().Contains("Result`3[TError2"));
	}
}