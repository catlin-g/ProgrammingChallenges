namespace LeetCode
{
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