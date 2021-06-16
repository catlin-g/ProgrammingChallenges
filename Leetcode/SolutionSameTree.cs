namespace LeetCode
{
	/// <summary>
	/// 100. Same Tree
	/// https://leetcode.com/problems/same-tree/
	/// Difficulty: Easy
	/// </summary>
	public class SolutionSameTree
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

		public bool IsSameTree(TreeNode p, TreeNode q)
		{
			if (p == null && q == null)
			{
				return true;
			}
			else if (p == null ^ q == null)
			{
				return false;
			}
			else if (p.val != q.val)
			{
				return false;
			}
			else
			{
				return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
			}
		}
	}
}