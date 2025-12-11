namespace PracticeProblems.Problems;
public class ShortestPalindrome
{
	public string FindShortestPalindrome(string s)
	{
		string buildString = s;

		while (!isPalindrome(buildString))
		{
			string letter = firstNonMatch(buildString);
			buildString = letter + buildString;
		}
		return buildString;
	}

	public bool isPalindrome(string s)
	{
		int frontPointer = 0;
		int endPointer = s.Length - 1;

		while (frontPointer < endPointer)
		{
			if (s[frontPointer] != s[endPointer])
			{
				return false;
			}
			frontPointer++;
			endPointer--;
		}
		return true;
	}

	public string firstNonMatch(string s)
	{


		//flip abc
		//      cba -> connect
		//      find how far we need to push in

		//build reverse string.
		// string rev = "";
		// for(int i = 0; i < s.Length; i++)
		// {
		//     rev = s[s.Length - 1 - i] + rev;
		// }
		string rev = new string(s.Reverse().ToArray());

		//abcd
		//dcba
		//make dcba/abcd

		//smoosh
		int howMany = 1;
		bool valid = true;
		while (valid)
		{
			int frontPointer = howMany;
			int endPointer = s.Length - 1;
			for (int i = 0; i < howMany; i++)
			{
				if (s[frontPointer] == rev[endPointer])
				{
					frontPointer--;
					endPointer--;
				}
				else
				{
					valid = false;
				}
			}
			howMany++;
		}

		howMany--;
		rev.Remove(rev.Length - howMany);

		return rev;
	}

	public static void Test()
	{
		var solution = new ShortestPalindrome();

		string result1 = solution.FindShortestPalindrome("aacecaaa");
		Console.WriteLine($"Test 1: Expected 'aaacecaaa', Got '{result1}'");

		string result2 = solution.FindShortestPalindrome("abcd");
		Console.WriteLine($"Test 2: Expected 'dcbabcd', Got '{result2}'");

		string result3 = solution.FindShortestPalindrome("abcabc");
		Console.WriteLine($"Test 3: Expected 'cbacbabcabc', Got '{result3}'");
	}
}