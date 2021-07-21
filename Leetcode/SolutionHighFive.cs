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
				var currentStudentID = score[0];
				var currentStudentScore = score[1];

				if (studentScores.ContainsKey(currentStudentID))
				{
					if (studentScores[currentStudentID].Count == 5 && studentScores[currentStudentID].Peek() < currentStudentScore)
					{
						_ = studentScores[currentStudentID].Pop();
					}

					if (studentScores[currentStudentID].Count < 5)
					{
						studentScores[currentStudentID].Push(currentStudentScore);

						var scoreArray = studentScores[currentStudentID].ToArray();
						Array.Sort(scoreArray, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
						studentScores[currentStudentID] = new Stack<int>(scoreArray);
					}
				}
				else
				{
					studentScores.Add(currentStudentID, new Stack<int>());
					studentScores[currentStudentID].Push(currentStudentScore);
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