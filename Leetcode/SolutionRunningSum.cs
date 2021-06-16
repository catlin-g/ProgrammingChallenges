namespace LeetCode
{
	/// <summary>
	/// 1480. Running Sum of 1d Array
	/// https://leetcode.com/problems/running-sum-of-1d-array/
	/// Difficulty: Easy
	/// </summary>

	public class SolutionRunningSum
	{
		public int[] RunningSum(int[] nums)
		{
		var output = new int[nums.Length];
		var sum = 0;

		for (var i = 0; i < nums.Length; ++i)
		{
			sum += nums[i];
			output[i] = sum;
		}

		return output;
		}
	}
}