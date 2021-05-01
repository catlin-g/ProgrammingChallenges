using System;

namespace Problem1
{
	/// <summary>
	/// Multiples of 3 and 5
	/// Problem 1
	///
	/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
	/// The sum of these multiples is 23.
	///
	/// Find the sum of all the multiples of 3 or 5 below 1000.
	/// </summary>
	class Problem1
	{
		private const int MinNum = 0;
		private const int MaxNum = 999;

		public static void CalculateSum()
		{
			var totalSum = 0;

			for (var iter = MinNum; iter <= MaxNum; iter++)
			{
				if (iter % 3 == 0 || iter % 5 == 0)
				{
					totalSum += iter;
				}
			}

			Console.WriteLine(totalSum);
		}
	}
}
