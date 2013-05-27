using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using NHunspell;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;
using Roslyn.Compilers.Common;
using Roslyn.Services;
using Roslyn.Services.Editor;

namespace GbCoding
{
	[ExportSyntaxNodeCodeIssueProvider("GbCoding", LanguageNames.CSharp, typeof(VariableDeclarationSyntax))]
	public class SpellCheckCodeIssueProvider : ICodeIssueProvider
	{
		private readonly ICodeActionEditFactory editFactory;

		[ImportingConstructor]
		public SpellCheckCodeIssueProvider(ICodeActionEditFactory editFactory)
		{
			this.editFactory = editFactory;
		}

		public IEnumerable<CodeIssue> GetIssues(IDocument document, CommonSyntaxNode node, CancellationToken cancellationToken = new CancellationToken())
		{
			var variable = node as VariableDeclarationSyntax;
			if (variable != null)
			{
				var nodes = variable.ChildNodes().Where(x => x.Kind == SyntaxKind.VariableDeclarator);
				
				foreach (var syntaxNode in nodes)
				{
					var fullVariableName = syntaxNode.GetFirstToken().ValueText;

					var wordsInVariableName = fullVariableName.SplitToWords();

					if (wordsInVariableName != null)
					{
						var correctSpelling = CheckAndCorrectSpelling(wordsInVariableName);

						if (correctSpelling != null)
							yield return new CodeIssue(CodeIssue.Severity.Info, syntaxNode.GetFirstToken().Span, "Possible Typo ?\nMaybe you meant : " + correctSpelling);
					}
				}
			}
		}

		private string CheckAndCorrectSpelling(List<string> wordsInVariableName)
		{
			var affFile = RetrieveEmbeddedResourceFile("en_US.aff");
			var dicFile = RetrieveEmbeddedResourceFile("en_US.dic");

			using (var hunspell = new Hunspell(affFile, dicFile))
			{
				foreach (var word in wordsInVariableName)
				{
					if (hunspell.Spell(word)) continue;

					var suggestions = hunspell.Suggest(word);
					if (suggestions == null || suggestions.Count == 0)
						return "<No suggestions>";

					return suggestions[0];
				}

				return null;
			}
		}

		private byte[] RetrieveEmbeddedResourceFile(string fileName)
		{
			var resourceAssemblyName = "GbCoding._3rdParty.DictionaryFiles.";
			using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceAssemblyName + fileName))
			{
				if (stream == null) return null;

				var fileData = new byte[stream.Length];
				stream.Read(fileData, 0, fileData.Length);
				return fileData;
			}
		}

		public IEnumerable<CodeIssue> GetIssues(IDocument document, CommonSyntaxToken token, CancellationToken cancellationToken = new CancellationToken())
		{
			throw new NotImplementedException();
		}

		public IEnumerable<CodeIssue> GetIssues(IDocument document, CommonSyntaxTrivia trivia, CancellationToken cancellationToken = new CancellationToken())
		{
			throw new NotImplementedException();
		}
	}
}
