using System.Collections.Generic;

namespace LeetCode
{
	/// <summary>
	/// 938. Range Sum of BST
	/// https://leetcode.com/problems/range-sum-of-bst/
	/// Difficulty: Easy
	/// </summary>

	internal class SolutionRangeSumOfBST
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;

			public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
			{
				this.val = val;
				this.left = left;
				this.right = right;
			}
		}

		public int RangeSumBST(TreeNode root, int low, int high)
		{
			var sum = 0;
			var stack = new Stack<TreeNode>();
			stack.Push(root);

			while (stack.Count > 0)
			{
				var current = stack.Pop();

				if(current != null)
				{
					if (low <= current.val && current.val <= high)
					{
						sum += current.val;
					}
					if (low < current.val)
					{
						stack.Push(current.left);
					}
					if (high > current.val)
					{
						stack.Push(current.right);
					}
				}

			}


			return sum;
		}
	}
}