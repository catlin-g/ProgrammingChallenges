namespace LeetCode
{
	/// <summary>
	/// 700. Search in a Binary Search Tree
	/// https://leetcode.com/problems/search-in-a-binary-search-tree/
	/// Difficulty: Easy
	/// </summary>

	public class SolutionSearchBST
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

		public TreeNode SearchBST(TreeNode root, int val)
		{
			if (root == null || root.val == val)
			{
				return root;
			}
			else
			{
				return val < root.val
					? SearchBST(root.left, val)
					: SearchBST(root.right, val);
			}
		}
	}
}