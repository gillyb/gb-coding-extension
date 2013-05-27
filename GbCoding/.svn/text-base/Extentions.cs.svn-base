using System.Text;
using System.Collections.Generic;

namespace GbCoding
{
	public static class Extentions
	{
		public static List<string> SplitToWords(this string varName)
		{
			var text = varName.Trim();
			if (string.IsNullOrEmpty(text)) return null;
			if (text.Length <= 2) return null;

			var varPieces = text.Split('_');
			foreach (var piece in varPieces)
			{
				if (string.IsNullOrEmpty(piece)) continue;
				if (piece.Length <= 2) continue;

				var wordList = new List<string>();
				var word = string.Empty;
				foreach (var letter in piece)
				{
					if (word == string.Empty)
					{
						word += letter;
						continue;
					}

					if (char.IsUpper(letter))
					{
						if (word.Length >= 1)
						{
							wordList.Add(word);
							word = string.Empty + letter;
						}
						continue;
					}

					word += letter;
				}

				if (word.Length >= 2)
					wordList.Add(word);

				return wordList;
			}

			return null;
		}
	}
}