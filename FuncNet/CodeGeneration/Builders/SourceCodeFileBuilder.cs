using System.Text;

namespace FuncNet.CodeGeneration.Builders;

internal sealed class SourceCodeFileBuilder
{
	private const string DELIMITER = "\n\t\t";

	private readonly StringBuilder builder = new();

	public SourceCodeFileBuilder(string header)
	{
		builder.Append(header).Append(DELIMITER);
	}

	public SourceCodeFileBuilder AddClass(ClassBuilder classBuilder)
	{
		builder.Append(classBuilder).Append(DELIMITER);
		return this;
	}

	public SourceCodeFileBuilder AddClassIf(ClassBuilder classBuilder, Func<bool> shouldAdd)
	{
		if (shouldAdd())
		{
			AddClass(classBuilder);
		}

		return this;
	}

	public override string ToString() => builder.ToString();
}