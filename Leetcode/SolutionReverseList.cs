namespace LeetCode
{
	/// <summary>
	/// 206. Reversed Linked List
	/// https://leetcode.com/problems/reverse-linked-list/
	/// Difficulty: Easy
	/// </summary>
	public class SolutionReverseList
	{
		public class ListNode
		{
			public int val;
			public ListNode next;

			public ListNode(int val = 0, ListNode next = null)
			{
				this.val = val;
				this.next = next;
			}
		}

		public ListNode ReverseList(ListNode head)
		{
			var current = head;
			ListNode prev = null;

			while(current != null)
			{
				var nextTemp = current.next;
				current.next = prev;
				prev = current;
				current = nextTemp;
			}

			return prev;
		}
	}
}