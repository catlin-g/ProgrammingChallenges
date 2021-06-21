namespace LeetCode
{
	internal class SolutionIsPrefixOfWord
	{
		public int IsPrefixOfWord(string sentence, string searchWord)
		{
			var words = sentence.Split(' ');
			var minimumIndex = -1;
			var currentIndex = 0;

			while (minimumIndex == -1 && currentIndex < words.Length)
			{
				if (searchWord.Length <= words[currentIndex].Length)
				{
					var comparer = words[currentIndex].Substring(0, searchWord.Length);
					if (searchWord.Equals(comparer))
					{
						minimumIndex = currentIndex + 1;
					}
				}

				++currentIndex;
			}

			return minimumIndex;
		}
	}
}