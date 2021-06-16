using System.Collections.Generic;

namespace LeetCode
{
	/// <summary>
	/// 13. Roman to Integer
	/// https://leetcode.com/problems/roman-to-integer/
	/// Difficulty: Easy
	/// </summary>
	public class SolutionRomanToInteger
	{
		private readonly Dictionary<char, int> symbols = new()
		{
			{ 'I', 1 },
			{ 'V', 5 },
			{ 'X', 10 },
			{ 'L', 50 },
			{ 'C', 100 },
			{ 'D', 500 },
			{ 'M', 1000 }
		};

		public int RomanToInt(string s)
		{
			var result = 0;

			for (var i = 0; i < s.Length; ++i)
			{
				var currSymbol = s[i];
				var currVal = symbols[s[i]];
				var subtractor = currSymbol == 'I' || currSymbol == 'X' || currSymbol == 'C';
				var nextValExists = i + 1 < s.Length;
				var nextVal = nextValExists ? symbols[s[i + 1]] : 0;

				if (subtractor && nextValExists && nextVal > currVal)
				{
					result += nextVal - currVal;
					++i;
				}
				else
				{
					result += currVal;
				}
			}

			return result;
		}
	}
}