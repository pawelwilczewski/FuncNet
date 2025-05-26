namespace FuncNet.CodeGeneration.Builders;

internal sealed class IfStatementBuilder
{
	private const string DELIMITER = "\n\t\t";
	private readonly string condition;
	private readonly StatementsBlockBuilder statements = new();

	public IfStatementBuilder(string condition) => this.condition = condition;

	public IfStatementBuilder AddStatement(string statement)
	{
		statements.AddStatement(statement);
		return this;
	}

	public override string ToString() => $"if ({condition}){statements}";
}