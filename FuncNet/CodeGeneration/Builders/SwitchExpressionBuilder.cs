using System.Text;

namespace FuncNet.CodeGeneration.Builders;

internal sealed class SwitchExpressionBuilder
{
	private const string DELIMITER = "\n\t\t";

	private readonly StringBuilder builder = new();

	public SwitchExpressionBuilder(string switchOnIdentifier)
	{
		builder.Append($"{switchOnIdentifier} switch{DELIMITER}{{{DELIMITER}\t");
	}

	public SwitchExpressionBuilder AddCase(SwitchCaseText @case)
	{
		builder.Append($"{@case.Left} => {@case.Right},").Append(DELIMITER).Append('\t');
		return this;
	}

	public SwitchExpressionBuilder AddCases(IEnumerable<SwitchCaseText> cases)
	{
		foreach (var @case in cases)
		{
			AddCase(@case);
		}

		return this;
	}

	public override string ToString() => $"{builder}}}";
}

public readonly record struct SwitchCase(int Index, string Identifier);

public readonly record struct SwitchCaseText(string Left, string Right);