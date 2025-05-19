using System.Text;

namespace FuncNet.Union.Generator.CodeGeneration.Builders;

public sealed class StatementsBlockBuilder
{
	private const string DELIMITER = "\n\t\t";

	private readonly StringBuilder builder = new();

	public StatementsBlockBuilder AddStatement(string statement)
	{
		builder.Append(statement).Append(';').Append(DELIMITER).Append('\t');
		return this;
	}

	public StatementsBlockBuilder AddStatements(IEnumerable<string> statements)
	{
		foreach (var statement in statements)
		{
			builder.Append(statement).Append(';').Append(DELIMITER).Append('\t');
		}

		return this;
	}

	public override string ToString() => $"{{{DELIMITER}{builder}{DELIMITER}}}";
}