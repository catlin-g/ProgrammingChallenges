using System;

/// <summary>
/// 476. Number Complement
/// https://leetcode.com/problems/number-complement/
/// Difficulty: Easy
/// </summary>

namespace LeetCode
{
	public class SolutionFindComplement
	{
		public int FindComplement(int num)
		{
			var complement = 0;

			for (var i = 0; num > 0; ++i)
			{
				if ((num & 1) == 0)
				{
					complement += (int)Math.Pow(2, i);
				}

				num >>= 1;
			}

			return complement;
		}
	}
}