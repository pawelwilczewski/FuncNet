using System.Reflection;
using FuncNet.Union.Generator;

var text = UnionGenerator.GenerateUnionFile("FuncNet.Union", 3);
var path = Path.Join(Path.GetFullPath(Assembly.GetExecutingAssembly().Location), "/../../../../../FuncNet.Union", "Union3.g.cs");

File.WriteAllText(path, text);