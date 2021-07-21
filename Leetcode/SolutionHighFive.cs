using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class SolutionHighFive
	{
		public int[][] HighFive(int[][] items)
		{
			var studentScores = new SortedDictionary<int, Stack<int>>();

			foreach (var score in items)
			{
				var studentID = score[0];
				var studentScore = score[1];

				if (studentScores.ContainsKey(studentID))
				{
					if (studentScores[studentID].Count == 5 && studentScores[studentID].Peek() < studentScore)
					{
						_ = studentScores[studentID].Pop();
					}

					if (studentScores[studentID].Count < 5)
					{
						studentScores[studentID].Push(studentScore);

						var scoreArray = studentScores[studentID].ToArray();
						Array.Sort(scoreArray, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
						studentScores[studentID] = new Stack<int>(scoreArray);
					}
				}
				else
				{
					studentScores.Add(studentID, new Stack<int>());
					studentScores[studentID].Push(studentScore);
				}
			}

			var result = new int[studentScores.Count][];
			var index = 0;

			foreach (var element in studentScores)
			{
				var scoreArray = element.Value.ToArray();
				var average = scoreArray.Sum() / 5;

				result[index] = new int[] { element.Key, average };

				++index;
			}

			return result;
		}
	}
}