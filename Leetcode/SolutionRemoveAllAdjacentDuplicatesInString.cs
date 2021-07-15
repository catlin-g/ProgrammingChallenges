using System.Text;

namespace LeetCode
{
	/// <summary>
	/// 1047. Remove All Adjacent Duplicates in String
	/// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/submissions/
	/// Difficulty: Easy
	/// </summary>
	class SolutionRemoveAllAdjacentDuplicatesInString
	{
		public string RemoveDuplicates(string s)
		{
			if (s.Length < 2)
			{
				return s;
			}

			var sb = new StringBuilder();

			foreach (var letter in s)
			{
				if (sb.Length == 0 || !letter.Equals(sb[sb.Length - 1]))
				{
					_ = sb.Append(letter);
				}
				else
				{
					--sb.Length;
				}
			}

			return sb.ToString();
		}
	}
}