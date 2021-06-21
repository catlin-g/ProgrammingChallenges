namespace LeetCode
{
	/// <summary>
	/// 1455. Check If a Word Occurs As a Prefix of Any Word in a Sentence
	/// https://leetcode.com/problems/check-if-a-word-occurs-as-a-prefix-of-any-word-in-a-sentence/
	/// Difficulty: Easy
	/// </summary>
	internal class SolutionIsPrefixOfWord
	{
		public int IsPrefixOfWord(string sentence, string searchWord)
		{
			var currentIndex = 1;

			foreach (var word in sentence.Split(' '))
			{
				if (word.StartsWith(searchWord))
				{
					return currentIndex;
				}

				++currentIndex;
			}

			return -1;
		}
	}
}