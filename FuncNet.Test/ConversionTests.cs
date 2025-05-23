namespace FuncNet.Test;

public class ConversionTests
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
	public void ResultToUnion_WhenError0_ReturnsUnionWithValue1()
	{
		var result = Result<int, string, bool>.FromError("error_string");
		var union = result.ToUnion();

		var matchResult = union.Match(
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
	public void ResultToOption_WhenError0_ReturnsNone()
	{
		var result = Result<int, string, bool>.FromError("another_error");
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
}