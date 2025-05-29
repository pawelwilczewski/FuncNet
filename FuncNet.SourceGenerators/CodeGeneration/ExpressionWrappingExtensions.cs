namespace FuncNet.CodeGeneration;

internal static class ExpressionWrappingExtensions
{
	public static string WrapInTask(this string expression) => $"Task<{expression}>";
	public static string WrapInTaskFromResult(this string expression) => $"Task.FromResult({expression})";
	public static string WrapInAsyncTask(this string expression) => $"async {WrapInTask(expression)}";

	public static string WrapInResultGetter(this string expression) =>
		$"({expression}).Result";

	public static string WrapInAwaitConfigured(this string expression) =>
		$"await ({expression}).ConfigureAwait(false)";

	public static string WrapInTaskIf(this string expression, bool shouldWrap) =>
		shouldWrap ? WrapInTask(expression) : expression;

	public static string WrapInTaskFromResultIf(this string expression, bool shouldWrap) =>
		shouldWrap ? WrapInTaskFromResult(expression) : expression;

	public static string WrapInAsyncTaskIf(this string expression, bool shouldWrap) =>
		shouldWrap ? WrapInAsyncTask(expression) : expression;

	public static string WrapInAwaitConfiguredIf(this string expression, bool shouldWrap) =>
		shouldWrap ? WrapInAwaitConfigured(expression) : expression;

	public static string WrapInResultGetterIf(this string expression, bool shouldWrap) =>
		shouldWrap ? WrapInResultGetter(expression) : expression;
}