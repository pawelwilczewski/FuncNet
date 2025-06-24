using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;

namespace FuncNet.Analyzers.Config;

internal sealed record class FuncNetConfigFile
{
	public const string FILE_NAME = "FuncNetConfig.cs";

	private FuncNetConfigFile

	private CompilationUnitSyntax SyntaxRoot
	{
		get
		{
			if (!Document.TryGetSyntaxTree(out var syntaxTree))
			{
				throw new Exception("Unreachable: should always have syntax tree cached");
			}

			return (CompilationUnitSyntax)syntaxTree.GetRoot();
		}
	}

	private FuncNetConfigFile(Document document) =>
		Document = document;

	public FuncNetConfigFile WithUnionRegistration(string unionTypeName, Workspace workspace)
	{
		
		
		if (HasSingleComment(unionTypeName)) return this;

		var newCommentTriviaWithLineEnding = SyntaxFactory.TriviaList(
			SyntaxFactory.Comment(unionTypeName),
			SyntaxFactory.CarriageReturnLineFeed);

		var funcNetNamespace = SyntaxRoot.DescendantNodes()
			.OfType<NamespaceDeclarationSyntax>()
			.FirstOrDefault(n => n.Name.ToString() == nameof(FuncNet));

		var result = this;
		if (funcNetNamespace != null)
		{
			var closeBrace = funcNetNamespace.CloseBraceToken;
			var newLeadingTrivia = closeBrace.LeadingTrivia.AddRange(newCommentTriviaWithLineEnding);
			var newCloseBrace = closeBrace.WithLeadingTrivia(newLeadingTrivia);
			var updatedNamespace = funcNetNamespace.WithCloseBraceToken(newCloseBrace);
			result = result.WithSyntaxRoot(root =>
				root.ReplaceNode(funcNetNamespace, updatedNamespace));
		}
		else
		{
			funcNetNamespace = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(nameof(FuncNet)))
				.WithOpenBraceToken(SyntaxFactory.Token(SyntaxKind.OpenBraceToken))
				.WithCloseBraceToken(
					SyntaxFactory.Token(SyntaxKind.CloseBraceToken)
						.WithLeadingTrivia(newCommentTriviaWithLineEnding));
			result = result.WithSyntaxRoot(root =>
				root.AddMembers(funcNetNamespace));
		}

		result = result.WithSyntaxRoot(root =>
			(CompilationUnitSyntax)Formatter.Format(root, workspace, workspace.Options));

		return result;
	}

	public static FuncNetConfigFile GetOrCreate(Project configFileProject)
	{
		var document = configFileProject.Documents.FirstOrDefault(doc =>
			doc.Name.Equals(FILE_NAME, StringComparison.OrdinalIgnoreCase));

		if (document is null)
		{
			var config = new FuncNetConfig();
			var projectDirectory = Path.GetDirectoryName(configFileProject.FilePath)!;
			var newFilePath = Path.Combine(projectDirectory, FILE_NAME);
			document = configFileProject.AddDocument(FILE_NAME, config.ToSyntaxRoot(), filePath: newFilePath);
		}

		return new FuncNetConfigFile(document);
	}
}