using System.Collections.Generic;

namespace LeetCode
{
	public class SolutionValidWordSquare
	{
		public bool ValidWordSquare(IList<string> words)
		{
			for (var i = 0; i < words.Count; ++i)
			{
				var current = words[i];

				if (current.Length > words.Count)
				{
					return false;
				}

				for (var j = 0; j < current.Length; ++j)
				{
					if (i >= words[j].Length || current[j] != words[j][i])
					{
						return false;
					}
				}
			}

			return true;
		}
	}
}