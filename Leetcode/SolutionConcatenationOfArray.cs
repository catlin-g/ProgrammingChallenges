namespace LeetCode
{
	/// <summary>
	/// 1929. Concatenation of Array
	/// https://leetcode.com/problems/prime-number-of-set-bits-in-binary-representation/
	/// Difficulty: Easy
	/// </summary>

	public class SolutionConcatenationOfArray
	{
		public int[] GetConcatenation(int[] nums)
		{
			var numsLength = nums.Length;
			var result = new int[numsLength * 2];

			for (var i = 0; i < numsLength; ++i)
			{
				result[i] = nums[i];
				result[i + numsLength] = nums[i];
			}

			return result;
		}
	}
}