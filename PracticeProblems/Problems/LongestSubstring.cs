namespace PracticeProblems.Problems;

public class LongestSubstring
{
	/// <summary>
	/// Given a string s, find the length of the longest substring without duplicate characters.
	/// </summary>
	/// <param name="s">The input string.</param>
	/// <returns>The length of the longest substring without repeating characters.</returns>
	public int LengthOfLongestSubstring(string s)
	{
		var currentList = "";
		var longestList = "";

		//loop though the string if we are a new character
		for(int i = 0; i < s.Length; i++)
		{
			if(currentList.Contains(s[i]))
			{
				if(currentList.Length > longestList.Length)
				{
					longestList = currentList;
				}
				//how many character can we keep
				//basically we need to start removing character from the front till we are a string
				while(currentList.Contains(s[i]) && currentList.Length > 0)
				{
					currentList = currentList.Remove(0, 1);
				}
				currentList += s[i];
			}
			else
			{
				currentList += s[i];
			}
		}

		if(currentList.Length > longestList.Length)
		{
			longestList = currentList;
		}
		return longestList.Length;
	}

	// Test method
	public static void Test()
	{
		var solution = new LongestSubstring();

		// --- Example Test Cases ---

		// Test 1: Example 1 - "abcabcbb" -> "abc" (3)
		int result1 = solution.LengthOfLongestSubstring("abcabcbb");
		Console.WriteLine($"Test 1: Input: 'abcabcbb', Expected: 3, Got: {result1}");

		// Test 2: Example 2 - "bbbbb" -> "b" (1)
		int result2 = solution.LengthOfLongestSubstring("bbbbb");
		Console.WriteLine($"Test 2: Input: 'bbbbb', Expected: 1, Got: {result2}");

		// Test 3: Example 3 - "pwwkew" -> "wke" or "kew" (3)
		int result3 = solution.LengthOfLongestSubstring("pwwkew");
		Console.WriteLine($"Test 3: Input: 'pwwkew', Expected: 3, Got: {result3}");

		// --- Edge Cases and Variations ---

		// Test 4: Empty string
		int result4 = solution.LengthOfLongestSubstring("");
		Console.WriteLine($"Test 4: Input: '', Expected: 0, Got: {result4}");

		// Test 5: Single character string
		int result5 = solution.LengthOfLongestSubstring("a");
		Console.WriteLine($"Test 5: Input: 'a', Expected: 1, Got: {result5}");

		// Test 6: All unique characters - "abcdef" (6)
		int result6 = solution.LengthOfLongestSubstring("abcdef");
		Console.WriteLine($"Test 6: Input: 'abcdef', Expected: 6, Got: {result6}");

		// Test 7: Repeating characters at the start - "aab" -> "ab" (2)
		int result7 = solution.LengthOfLongestSubstring("aab");
		Console.WriteLine($"Test 7: Input: 'aab', Expected: 2, Got: {result7}");

		// Test 8: Repeating characters in the middle - "dvdf" -> "vdf" (3)
		int result8 = solution.LengthOfLongestSubstring("dvdf");
		Console.WriteLine($"Test 8: Input: 'dvdf', Expected: 3, Got: {result8}");

		// Test 9: Repeating characters at the end - "cdd" -> "cd" (2)
		int result9 = solution.LengthOfLongestSubstring("cdd");
		Console.WriteLine($"Test 9: Input: 'cdd', Expected: 2, Got: {result9}");

		// Test 10: Mixed case and numbers - "AbcdeFg123A" -> "bcdeFg123A" (10)
		int result10 = solution.LengthOfLongestSubstring("AbcdeFg123A");
		Console.WriteLine($"Test 10: Input: 'AbcdeFg123A', Expected: 10, Got: {result10}");

		// Test 11: "jbpnbwwd" -> "jbpnbwwd" (4)
		int result11 = solution.LengthOfLongestSubstring("jbpnbwwd");
		Console.WriteLine($"Test 11: Input: 'jbpnbwwd', Expected: 4, Got: {result11}");
	}
}
