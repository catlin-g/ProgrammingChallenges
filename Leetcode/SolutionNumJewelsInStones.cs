using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	/// <summary>
	/// 771. Jewels and Stones
	/// https://leetcode.com/problems/jewels-and-stones/
	/// Difficulty: Easy
	/// </summary>
	class SolutionNumJewelsInStones
	{
		public int NumJewelsInStones(string jewels, string stones)
		{
			var result = 0;

			foreach(var stone in stones)
			{
				if (jewels.Contains(stone))
				{
					result++;
				}
			}

			return result;
		}
	}
}
