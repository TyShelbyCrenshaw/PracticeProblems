using System.Drawing;

namespace PracticeProblems.Problems;

/**
 * Definition for singly-linked list.
 */
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

public class RemoveDuplicatesSortedList
{
	/// <summary>
	/// Given the head of a sorted linked list, delete all duplicates such that each element appears only once.
	/// Return the linked list sorted as well.
	/// </summary>
	/// <param name="head">The head of the sorted linked list.</param>
	/// <returns>The head of the linked list with duplicates removed.</returns>
	public ListNode DeleteDuplicates(ListNode head)
	{
        ListNode returnHead = head;

        while(head != null)
        {
            if(head.next != null)
            {
                while(head.next.val == head.val)
                {
                    head.next = head.next.next;
                    if(head.next == null)
                    {
                        break;
                    }
                }
            }
            head = head.next;
        }
		return returnHead;
	}

	// Helper method to create a linked list from an array
	private static ListNode CreateList(int[] values)
	{
		if (values.Length == 0) return null;

		ListNode head = new ListNode(values[0]);
		ListNode current = head;
		for (int i = 1; i < values.Length; i++)
		{
			current.next = new ListNode(values[i]);
			current = current.next;
		}
		return head;
	}

	// Helper method to convert linked list to array for easy comparison
	private static int[] ListToArray(ListNode head)
	{
		var result = new List<int>();
		while (head != null)
		{
			result.Add(head.val);
			head = head.next;
		}
		return result.ToArray();
	}

	// Helper method to print array
	private static string ArrayToString(int[] arr)
	{
		return "[" + string.Join(",", arr) + "]";
	}

	// Test method
	public static void Test()
	{
		var solution = new RemoveDuplicatesSortedList();

		// --- Example Test Cases ---

		// Test 1: Example 1 - [1,1,2] -> [1,2]
		ListNode head1 = CreateList(new int[] { 1, 1, 2 });
		ListNode result1 = solution.DeleteDuplicates(head1);
		int[] output1 = ListToArray(result1);
		Console.WriteLine($"Test 1: Input: [1,1,2], Expected: [1,2], Got: {ArrayToString(output1)}");

		// Test 2: Example 2 - [1,1,2,3,3] -> [1,2,3]
		ListNode head2 = CreateList(new int[] { 1, 1, 2, 3, 3 });
		ListNode result2 = solution.DeleteDuplicates(head2);
		int[] output2 = ListToArray(result2);
		Console.WriteLine($"Test 2: Input: [1,1,2,3,3], Expected: [1,2,3], Got: {ArrayToString(output2)}");

		// --- Edge Cases ---

		// Test 3: Empty list - [] -> []
		ListNode head3 = CreateList(new int[] { });
		ListNode result3 = solution.DeleteDuplicates(head3);
		int[] output3 = ListToArray(result3);
		Console.WriteLine($"Test 3: Input: [], Expected: [], Got: {ArrayToString(output3)}");

		// Test 4: Single element - [1] -> [1]
		ListNode head4 = CreateList(new int[] { 1 });
		ListNode result4 = solution.DeleteDuplicates(head4);
		int[] output4 = ListToArray(result4);
		Console.WriteLine($"Test 4: Input: [1], Expected: [1], Got: {ArrayToString(output4)}");

		// Test 5: All duplicates - [1,1,1,1] -> [1]
		ListNode head5 = CreateList(new int[] { 1, 1, 1, 1 });
		ListNode result5 = solution.DeleteDuplicates(head5);
		int[] output5 = ListToArray(result5);
		Console.WriteLine($"Test 5: Input: [1,1,1,1], Expected: [1], Got: {ArrayToString(output5)}");

		// Test 6: No duplicates - [1,2,3,4] -> [1,2,3,4]
		ListNode head6 = CreateList(new int[] { 1, 2, 3, 4 });
		ListNode result6 = solution.DeleteDuplicates(head6);
		int[] output6 = ListToArray(result6);
		Console.WriteLine($"Test 6: Input: [1,2,3,4], Expected: [1,2,3,4], Got: {ArrayToString(output6)}");

		// Test 7: Two elements same - [1,1] -> [1]
		ListNode head7 = CreateList(new int[] { 1, 1 });
		ListNode result7 = solution.DeleteDuplicates(head7);
		int[] output7 = ListToArray(result7);
		Console.WriteLine($"Test 7: Input: [1,1], Expected: [1], Got: {ArrayToString(output7)}");

		// Test 8: Two elements different - [1,2] -> [1,2]
		ListNode head8 = CreateList(new int[] { 1, 2 });
		ListNode result8 = solution.DeleteDuplicates(head8);
		int[] output8 = ListToArray(result8);
		Console.WriteLine($"Test 8: Input: [1,2], Expected: [1,2], Got: {ArrayToString(output8)}");

		// Test 9: Multiple groups of duplicates - [1,1,1,2,2,3,4,4,4,4,5] -> [1,2,3,4,5]
		ListNode head9 = CreateList(new int[] { 1, 1, 1, 2, 2, 3, 4, 4, 4, 4, 5 });
		ListNode result9 = solution.DeleteDuplicates(head9);
		int[] output9 = ListToArray(result9);
		Console.WriteLine($"Test 9: Input: [1,1,1,2,2,3,4,4,4,4,5], Expected: [1,2,3,4,5], Got: {ArrayToString(output9)}");

		// Test 10: Duplicates at end - [1,2,3,3,3] -> [1,2,3]
		ListNode head10 = CreateList(new int[] { 1, 2, 3, 3, 3 });
		ListNode result10 = solution.DeleteDuplicates(head10);
		int[] output10 = ListToArray(result10);
		Console.WriteLine($"Test 10: Input: [1,2,3,3,3], Expected: [1,2,3], Got: {ArrayToString(output10)}");

		// Test 11: Negative numbers - [-3,-3,-1,0,0,0,1] -> [-3,-1,0,1]
		ListNode head11 = CreateList(new int[] { -3, -3, -1, 0, 0, 0, 1 });
		ListNode result11 = solution.DeleteDuplicates(head11);
		int[] output11 = ListToArray(result11);
		Console.WriteLine($"Test 11: Input: [-3,-3,-1,0,0,0,1], Expected: [-3,-1,0,1], Got: {ArrayToString(output11)}");

		// Test 12: All same negative number - [-1,-1,-1] -> [-1]
		ListNode head12 = CreateList(new int[] { -1, -1, -1 });
		ListNode result12 = solution.DeleteDuplicates(head12);
		int[] output12 = ListToArray(result12);
		Console.WriteLine($"Test 12: Input: [-1,-1,-1], Expected: [-1], Got: {ArrayToString(output12)}");
	}
}