namespace FuncNet.Generator.CodeGeneration.Builders;

internal sealed class MethodBuilder
{
	private readonly string name;
	private readonly ArgumentListBuilder argumentList = new();
	private readonly StatementsBlockBuilder body = new();

	public MethodBuilder(string name) => this.name = name;

	public MethodBuilder AddArgument(string argument)
	{
		argumentList.AddArgument(argument);
		return this;
	}

	public MethodBuilder AddArguments(IEnumerable<string> arguments)
	{
		argumentList.AddArguments(arguments);
		return this;
	}

	public MethodBuilder AddBodyStatements(IEnumerable<string> statements)
	{
		body.AddStatements(statements);
		return this;
	}

	public MethodBuilder AddBodyStatement(string statement)
	{
		body.AddStatement(statement);
		return this;
	}

	public MethodBuilder AddBodyStatementIf(string statement, bool shouldAdd) =>
		shouldAdd ? AddBodyStatement(statement) : this;

	public override string ToString() => $"{name}{argumentList}{body}";
}