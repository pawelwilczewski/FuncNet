namespace FuncNet.Test;

public sealed class PipeTests
{
	[Fact]
	public async Task Pipe_Works()
	{
		var syncResult = 10.Pipe(x => x * 2);
		Assert.Equal(20, syncResult);

		var asyncResultSyncFunc = await Task.FromResult(10).Pipe(x => x * 3);
		Assert.Equal(30, asyncResultSyncFunc);

		var asyncLambda = (Func<int, Task<int>>)(async x =>
		{
			await Task.Yield();
			return x * 4;
		});
		var asyncResultAsyncFunc = await Task.FromResult(10).Pipe(asyncLambda);
		Assert.Equal(40, asyncResultAsyncFunc);

		var stringResult = "hello".Pipe(s => s.ToUpper());
		Assert.Equal("HELLO", stringResult);

		var asyncStringResultSyncFunc = await Task.FromResult("world").Pipe(s => s.Length);
		Assert.Equal(5, asyncStringResultSyncFunc);

		var asyncStringLambda = (Func<string, Task<string>>)(async s =>
		{
			await Task.Delay(10);
			return $"Piped: {s}";
		});
		var asyncStringResultAsyncFunc = await Task.FromResult("pipe").Pipe(asyncStringLambda);
		Assert.Equal("Piped: pipe", asyncStringResultAsyncFunc);
	}
}