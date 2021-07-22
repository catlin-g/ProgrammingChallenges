using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class SolutionHighFive
	{
		/// <summary>
		/// 1086. High Five
		/// https://leetcode.com/problems/high-five/
		/// Difficulty: Easy
		/// </summary>

		public int[][] HighFive(int[][] items)
		{
			var studentScores = new SortedDictionary<int, List<int>>();

			foreach (var score in items)
			{
				var (studentID, studentScore) = (score[0], score[1]);

				if (!studentScores.ContainsKey(studentID))
				{
					studentScores[studentID] = new List<int>();
				}

				studentScores[studentID].Add(studentScore);
			}

			var result = new int[studentScores.Count][];
			var index = 0;

			foreach (var element in studentScores)
			{
				element.Value.Sort((e1, e2) => e2.CompareTo(e1));
				var average =  element.Value.Take(5).Sum() / 5;

				result[index++] = new int[] { element.Key, average };
			}

			return result;
		}
	}
}