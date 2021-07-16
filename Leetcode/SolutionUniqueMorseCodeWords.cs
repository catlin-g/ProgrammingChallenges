using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	/// <summary>
	/// 804. Unique Morse Code Words
	/// https://leetcode.com/problems/prime-number-of-set-bits-in-binary-representation/
	/// Difficulty: Easy
	/// </summary>

	public class SolutionUniqueMorseCodeWords
	{
		public int UniqueMorseRepresentations(string[] words)
		{
			var result = new HashSet<string>();

			var morseCode = new string[] {
				".-", "-...", "-.-.", "-..", ".",
				"..-.", "--.", "....", "..", ".---",
				"-.-", ".-..", "--", "-.", "---",
				".--.", "--.-", ".-.", "...", "-",
				"..-", "...-", ".--", "-..-", "-.--", "--.."};

			foreach (var word in words)
			{
				var morse = new StringBuilder();

				if (!string.IsNullOrWhiteSpace(word))
				{
					foreach (var letter in word)
					{
						_ = morse.Append(morseCode[letter - 'a']);
					}

					_ = result.Add(morse.ToString());
				}
			}

			return result.Count;
		}
	}
}