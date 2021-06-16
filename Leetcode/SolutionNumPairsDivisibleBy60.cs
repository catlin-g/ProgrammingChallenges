using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	/// <summary>
	/// 1010. Pairs of Songs With Total Durations Divisible by 60
	/// https://leetcode.com/problems/pairs-of-songs-with-total-durations-divisible-by-60/
	/// Difficulty: Medium
	/// </summary>
	/// *Doesn't work for cases like [60, 60. 60]

	public class SolutionNumPairsDivisibleBy60
	{
		public int NumPairsDivisibleBy60(int[] time)

		{
			var storage = new HashSet<(int, int)>();
			if (time.Length < 2)
			{
				return 0;
			} else
			{
				_ = GetValidPermutations(time.ToList(), new List<int>(), storage);

				return storage.Count;
			}
		}

		public HashSet<(int, int)> GetValidPermutations(List<int> songs, List<int> validPermutation, HashSet<(int, int)> storage)
		{
			if (validPermutation.Count == 2)
			{
				if(validPermutation.Take(2).Sum() % 60 == 0)
				{
					_ = new List<int>(validPermutation.Take(2));
					var tuple = (validPermutation.Min(), validPermutation.Max());
					_ = storage.Add(tuple);
				}
			}
			else
			{
				for(var i = 0; i < songs.Count; i++)
				{
					var currentVal = songs[0];

					validPermutation.Add(currentVal);
					_ = songs.Remove(currentVal);

					_ = GetValidPermutations(songs, validPermutation, storage);

					songs.Add(currentVal);
					_ = validPermutation.Remove(currentVal);
				}
			}

			return storage;
		}
	}
}