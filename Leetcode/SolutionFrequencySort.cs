using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	/// <summary>
	/// 1636. Sort Array by Increasing Frequency
	/// https://leetcode.com/problems/sort-array-by-increasing-frequency/
	/// Difficulty: Easy
	/// </summary>

	public class SolutionFrequencySort
	{
		public int[] FrequencySort(int[] nums)
		{
			var frequencies = new SortedDictionary<int, int>();

			for (var i = 0; i < nums.Length; ++i)
			{
				if(!frequencies.ContainsKey(nums[i]))
				{
					frequencies.Add(nums[i], GetFrequency(nums, nums[i]));
				}
			}

			var sortedFrequencies = frequencies.OrderBy(pair => pair.Value).ThenByDescending(pair => pair.Key).ToDictionary(t => t.Key, t => t.Value);
			var count = sortedFrequencies.First().Value;
			var result = new int[nums.Length];

			for(var i = 0; i < result.Length; ++i)
			{
				if(count == i)
				{
					var current = sortedFrequencies.First().Key;
					_ = sortedFrequencies.Remove(current);
					count += sortedFrequencies.First().Value;
				}

				result[i] = sortedFrequencies.First().Key;
			}

			return result;
		}

		public int GetFrequency(int[] nums, int num) => nums.Count(x => x == num);
	}
}