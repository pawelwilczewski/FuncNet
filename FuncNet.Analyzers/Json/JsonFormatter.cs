using System.Text;

namespace FuncNet.Analyzers.Json;

// Source: https://stackoverflow.com/a/6237866/8890805
internal static class JsonFormatter
{
	private const string INDENT_STRING = "  ";

	public static string Format(string json)
	{
		var indent = 0;
		var quoted = false;
		var sb = new StringBuilder();
		for (var i = 0; i < json.Length; i++)
		{
			var ch = json[i];
			switch (ch)
			{
				case '{':
				case '[':
					sb.Append(ch);
					if (!quoted)
					{
						sb.AppendLine();
						foreach (var _ in Enumerable.Range(0, ++indent))
						{
							sb.Append(INDENT_STRING);
						}
					}

					break;
				case '}':
				case ']':
					if (!quoted)
					{
						sb.AppendLine();
						foreach (var _ in Enumerable.Range(0, --indent))
						{
							sb.Append(INDENT_STRING);
						}
					}

					sb.Append(ch);
					break;
				case '"':
					sb.Append(ch);
					var escaped = false;
					var index = i;
					while (index > 0 && json[--index] == '\\')
					{
						escaped = !escaped;
					}

					if (!escaped) quoted = !quoted;
					break;
				case ',':
					sb.Append(ch);
					if (!quoted)
					{
						sb.AppendLine();
						foreach (var _ in Enumerable.Range(0, indent))
						{
							sb.Append(INDENT_STRING);
						}
					}

					break;
				case ':':
					sb.Append(ch);
					if (!quoted) sb.Append(" ");
					break;
				case '\r':
				case '\n': continue;
				default: sb.Append(ch); break;
			}
		}

		return sb.ToString();
	}
}