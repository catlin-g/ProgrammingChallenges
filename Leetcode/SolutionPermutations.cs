using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	/// <summary>
	/// 46. Permutations
	/// https://leetcode.com/problems/permutations/
	/// Difficulty: Medium
	/// </summary>
	public class SolutionPermutations
	{
		public IList<IList<int>> Permute(int[] nums)
		{
			IList<IList<int>> result = new List<IList<int>>();
			_ = Permutations(nums.ToList(), new List<int>(), result);

			return result;
		}

		public IList<IList<int>> Permutations(List<int> originalList, List<int> tempList, IList<IList<int>> output)
		{
			if (originalList.Count == 0)
			{
				output.Add(new List<int>(tempList));
			}
			else
			{
				for (var i = 0; i < originalList.Count; ++i)
				{
					var currentVal = originalList[0];
					Console.WriteLine(currentVal);
					tempList.Add(currentVal);
					_ = originalList.Remove(currentVal);

					_ = Permutations(originalList, tempList, output);

					originalList.Add(currentVal);
					_ = tempList.Remove(currentVal);
				}
			}
			return output;
		}
	}
}