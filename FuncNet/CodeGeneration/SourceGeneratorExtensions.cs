using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FuncNet.CodeGeneration;

internal static class SourceGeneratorExtensions
{
	public static void AddSourceIfNotExistsOrPartial(this GeneratorExecutionContext context, string hintName, string source)
	{
		if (!TryExtractTypeDeclarationSyntax(source, out var typeDeclaration))
		{
			throw new Exception($"Cannot extract type declaration from source: {source}");
		}

		if (!typeDeclaration!.IsPartial()
			&& TryGetFullyQualifiedTypeName(typeDeclaration!, out var typeName)
			&& TypeExists(context.Compilation, typeName!))
		{
			return;
		}

		context.AddSource(hintName, source);
	}

	private static bool IsPartial(this TypeDeclarationSyntax typeDeclaration)
	{
		return typeDeclaration.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword));
	}

	private static bool TryGetFullyQualifiedTypeName(TypeDeclarationSyntax typeDeclaration, out string? typeName)
	{
		typeName = null;

		if (typeDeclaration.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword))) return false;

		typeName = typeDeclaration.Identifier.ValueText;
		if (typeDeclaration.Arity > 0) typeName += $"`{typeDeclaration.Arity}";

		var namespaceName = typeDeclaration.GetNamespace();
		typeName = string.IsNullOrEmpty(namespaceName) ? typeName : $"{namespaceName}.{typeName}";
		return true;
	}

	private static bool TryExtractTypeDeclarationSyntax(string source, out TypeDeclarationSyntax? typeDeclarationSyntax)
	{
		var syntaxTree = CSharpSyntaxTree.ParseText(source);
		var root = syntaxTree.GetRoot();

		typeDeclarationSyntax = root.DescendantNodes().OfType<TypeDeclarationSyntax>().FirstOrDefault();
		return typeDeclarationSyntax is not null;
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