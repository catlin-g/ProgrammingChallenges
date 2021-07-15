using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	/// <summary>
	/// 1119. Remove Vowels from a String
	/// https://leetcode.com/problems/remove-vowels-from-a-string/
	/// Difficulty: Easy
	/// </summary>
	class SolutionRemoveVowelsFromAString
	{
		public string RemoveVowels(string s)
		{
			var vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
			var output = new StringBuilder();

			foreach (var letter in s)
			{
				if (!vowels.Contains(letter))
				{
					_ = output.Append(letter);
				}
			}

			return output.ToString();
		}
	}
}
