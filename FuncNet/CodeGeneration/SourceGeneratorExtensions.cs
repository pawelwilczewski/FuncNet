using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FuncNet.CodeGeneration;

public static class SourceGeneratorExtensions
{
	public static void AddSourceIfNotExists(this GeneratorExecutionContext context, string hintName, string source)
	{
		if (TryGetFullyQualifiedTypeName(source, out var typeName)
			&& TypeExists(context.Compilation, typeName!))
		{
			return;
		}

		context.AddSource(hintName, source);
	}

	private static bool TryGetFullyQualifiedTypeName(string source, out string? typeName)
	{
		typeName = null;

		var syntaxTree = CSharpSyntaxTree.ParseText(source);
		var root = syntaxTree.GetRoot();

		var typeDeclaration = root.DescendantNodes().OfType<TypeDeclarationSyntax>().FirstOrDefault();
		if (typeDeclaration is null) return false;

		var namespaceName = typeDeclaration.GetNamespace();

		typeName = typeDeclaration.Identifier.ValueText;
		var arity = typeDeclaration.TypeParameterList?.Parameters.Count ?? 0;
		if (arity > 0) typeName += $"`{arity}";

		typeName = string.IsNullOrEmpty(namespaceName) ? typeName : $"{namespaceName}.{typeName}";
		return true;
	}

	private static bool TypeExists(Compilation compilation, string fullyQualifiedTypeName)
	{
		var lastDotIndex = fullyQualifiedTypeName.LastIndexOf('.');
		if (lastDotIndex < 0) return compilation.GetTypeByMetadataName(fullyQualifiedTypeName) != null;

		var namespaceName = fullyQualifiedTypeName.Substring(0, lastDotIndex);
		var typeName = fullyQualifiedTypeName.Substring(lastDotIndex + 1);

		var type = compilation.GetTypeByMetadataName(fullyQualifiedTypeName);
		if (type is not null) return true;

		return compilation.SyntaxTrees.Select(syntaxTree => syntaxTree.GetRoot())
			.Select(root => root.DescendantNodes()
				.OfType<TypeDeclarationSyntax>()
				.Where(t => t.Identifier.ValueText == typeName))
			.Any(typeDeclarations => typeDeclarations.Select(GetNamespace)
				.Any(typeNamespace => typeNamespace == namespaceName));
	}

	private static string GetNamespace(this TypeDeclarationSyntax typeDeclaration) =>
		typeDeclaration.Ancestors().OfType<NamespaceDeclarationSyntax>().FirstOrDefault()?.Name.ToString()
		?? typeDeclaration.Ancestors().OfType<FileScopedNamespaceDeclarationSyntax>().FirstOrDefault()?.Name.ToString()
		?? string.Empty;
}