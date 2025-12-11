namespace PracticeProblems.Problems;


public class Sqrt
{
	public int MySqrt(int x)
	{
		if (x == 1) return 1;
		Int64 guess = x / 2;
		if (guess * guess <= x && (guess + 1) * (guess + 1) >= x)
		{
			return (int)guess;
		}
		while (!(guess * guess <= x) || !((guess + 1) * (guess + 1) >= x) && guess > 0)
		{
			if (guess * guess > x)
			{
				Int64 tempGuess = guess / 2;
				if ((tempGuess * tempGuess) > x)
				{
					guess /= 2;
				}
				else
				{
					guess--;
				}
			}
			else
			{
				Int64 tempGuess = guess * 2;
				if ((tempGuess * tempGuess) < x)
				{
					guess *= 2;
				}
				else
				{
					guess++;
				}
			}
		}

		return (int)guess;
	}

	// Test method
	public static void Test()
	{
		var solution = new Sqrt();

		// Test 1: sqrt(4) = 2
		int result1 = solution.MySqrt(4);
		Console.WriteLine($"Test 1: Expected 2, Got {result1}");

		// Test 2: sqrt(8) = 2
		int result2 = solution.MySqrt(8);
		Console.WriteLine($"Test 2: Expected 2, Got {result2}");

		// Test 3: sqrt(0) = 0
		int result3 = solution.MySqrt(0);
		Console.WriteLine($"Test 3: Expected 0, Got {result3}");

		// Test 4: sqrt(16) = 4
		int result4 = solution.MySqrt(16);
		Console.WriteLine($"Test 4: Expected 4, Got {result4}");

		// Test 5: sqrt(1) = 1
		int result5 = solution.MySqrt(1);
		Console.WriteLine($"Test 5: Expected 1, Got {result5}");

		// Test 6: sqrt(2147395600) = 46340
		int result6 = solution.MySqrt(2147395600);
		Console.WriteLine($"Test 6: Expected 46340, Got {result6}");

		// Test 7: sqrt(2147483647) = 46340 (max int32)
		int result7 = solution.MySqrt(2147483647);
		Console.WriteLine($"Test 7: Expected 46340, Got {result7}");

		// Test 8: sqrt(1000000) = 1000
		int result8 = solution.MySqrt(1000000);
		Console.WriteLine($"Test 8: Expected 1000, Got {result8}");

		// Test 9: sqrt(999999999) = 31622
		int result9 = solution.MySqrt(999999999);
		Console.WriteLine($"Test 9: Expected 31622, Got {result9}");

		// Test 10: sqrt(2147395601) = 46340
		int result10 = solution.MySqrt(2147395601);
		Console.WriteLine($"Test 10: Expected 46340, Got {result10}");
	}
}