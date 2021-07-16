using System;

namespace LeetCode
{
	/// <summary>
	/// 243. Shortest Word Distance
	/// https://leetcode.com/problems/shortest-word-distance/
	/// Difficulty: Easy
	/// </summary>

	public class SolutionShortestWordDistance
	{
		public int ShortestDistance(string[] wordsDict, string word1, string word2)
		{
			var distance = wordsDict.Length;
			var index1 = -1;
			var index2 = -1;

			for (var i = 0; i < wordsDict.Length; ++i)
			{
				if (wordsDict[i].Equals(word1))
				{
					index1 = i;
				}
				else if (wordsDict[i].Equals(word2))
				{
					index2 = i;
				}

				if (index1 != -1 && index2 != -1)
				{
					distance = Math.Min(distance, Math.Abs(index1 - index2));
				}

				if (distance == 1)
				{
					return distance;
				}
			}

			return distance;
		}
	}
}