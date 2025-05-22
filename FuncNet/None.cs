namespace FuncNet;

public readonly record struct None
{
	public static None Instance { get; } = new();
}