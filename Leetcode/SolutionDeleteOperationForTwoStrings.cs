namespace LeetCode
{
	/// <summary>
	/// 583. Delete Operation for Two Strings
	/// https://leetcode.com/problems/delete-operation-for-two-strings/
	/// Difficulty: Medium
	/// * Runtime error *
	/// </summary>

	class SolutionDeleteOperationForTwoStrings
	{
		public int MinDistance(string word1, string word2)
		{
			var distance = GetDistance(word1, word2);

			return distance;
		}


		public int GetDistance(string w1, string w2)
		{
			var distance = 0;
			var pointer1 = 0;
			var pointer2 = 0;

			while(pointer1 < w1.Length || pointer2 < w2.Length)
			{

				if (!w1.Substring(pointer1).Contains(w2[pointer2]))
				{
					distance++;
					pointer2++;
				}
				else if (!w2.Substring(pointer2).Contains(w1[pointer1]))
				{
					distance++;
					pointer1++;
				}
				else if (w1[pointer1].Equals(w2[pointer2]))
				{
					pointer1++;
					pointer2++;
				}

			}


			return distance;
		}
	}
}
