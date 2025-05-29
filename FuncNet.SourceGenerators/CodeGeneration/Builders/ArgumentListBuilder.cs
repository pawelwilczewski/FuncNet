namespace FuncNet.CodeGeneration.Builders;

internal sealed class ArgumentListBuilder
{
	private const string DELIMITER = ",\n\t\t";

	private readonly List<string> arguments = [];

	public ArgumentListBuilder AddArgument(string argument)
	{
		arguments.Add(argument);
		return this;
	}

	public ArgumentListBuilder AddArguments(IEnumerable<string> arguments)
	{
		this.arguments.AddRange(arguments);
		return this;
	}

	public override string ToString() => $"({string.Join(DELIMITER, arguments)})";
}