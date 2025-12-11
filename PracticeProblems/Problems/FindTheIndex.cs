namespace PracticeProblems.Problems;

public class FindTheIndex
{
	public int StrStr(string haystack, string needle)
	{
		for (int i = 0; i < haystack.Length; i++)
		{
			for (int j = 0; j < needle.Length; j++)
			{
				if (haystack.Length <= i + j)
				{
					return -1;
				}

				if (needle[j] == haystack[i + j])
				{
					if (j == needle.Length - 1)
					{
						return i;
					}
					continue;
				}
				else
				{
					break;
				}
			}
		}
		return -1;
	}

	public static void Test()
	{
		var solution = new FindTheIndex();

		int result1 = solution.StrStr("sadbutsad", "sad");
		Console.WriteLine($"Test 1: Expected 0, Got {result1}");

		int result2 = solution.StrStr("leetcode", "leeto");
		Console.WriteLine($"Test 2: Expected -1, Got {result2}");

		int result3 = solution.StrStr("hello", "ll");
		Console.WriteLine($"Test 3: Expected 2, Got {result3}");

		int result4 = solution.StrStr("aaa", "aaaa");
		Console.WriteLine($"Test 4: Expected -1, Got {result4}");
	}
}