using System.Runtime.CompilerServices;

namespace FuncNet.Analyzers;

internal static class Debug
{
	public static void Trace(
		string text = "",
		[CallerFilePath] string filePath = "",
		[CallerLineNumber] int lineNumber = 0,
		[CallerMemberName] string memberName = "")
	{
#pragma warning disable RS1035
		File.AppendAllText("C:/temp/funcnet-trace.txt", $"{DateTime.Now}, {Path.GetFileNameWithoutExtension(filePath)}: {lineNumber}, {memberName}: {text}\n");
#pragma warning restore RS1035
	}
}