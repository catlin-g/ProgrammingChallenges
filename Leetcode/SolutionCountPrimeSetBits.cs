using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 762. Prime Number of Set Bits in Binary Representation
/// https://leetcode.com/problems/prime-number-of-set-bits-in-binary-representation/
/// Difficulty: Easy
/// </summary>

namespace LeetCode
{
	class SolutionCountPrimeSetBits
	{
		public int CountPrimeSetBits(int left, int right)
		{
			var count = 0;

			for(var i = left; i <= right; ++i)
			{
				var temp = CountSetBits(i);

				if (IsPrime(temp))
				{
					count++;
				}
			}

			return count;
		}

		public int CountSetBits(int num)
		{
			var result = 0;

			while(num > 0)
			{
				if ((num & 1) == 1)
				{
					result++;
				}

				num >>= 1;
			}
			return result;
		}


		public bool IsPrime(int num)
		{
			if (num <= 1)
			{
				return false;
			}

			if (num == 2)
			{
				return true;
			}

			for (var i = 2; i < num; ++i)
			{
				if (num % i == 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}
