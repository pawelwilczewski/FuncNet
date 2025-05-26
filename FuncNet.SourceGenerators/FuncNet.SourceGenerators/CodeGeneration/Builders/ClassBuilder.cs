namespace FuncNet.Generator.CodeGeneration.Builders;

internal sealed class ClassBuilder
{
	private readonly string className;

	private readonly List<MethodBuilder> methods = [];

	public ClassBuilder(string className) => this.className = className;

	public ClassBuilder AddMethod(MethodBuilder method)
	{
		methods.Add(method);
		return this;
	}

	public ClassBuilder AddMethods(IEnumerable<MethodBuilder> methods)
	{
		this.methods.AddRange(methods);
		return this;
	}

	public override string ToString() => $"{className}\n{{{string.Join("\n\n\t", methods)}}}";
}