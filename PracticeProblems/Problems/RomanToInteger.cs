namespace PracticeProblems.Problems;

public class RomanToInteger
{
	/// <summary>
	/// Given a roman numeral string, convert it to an integer.
	/// Roman numerals use symbols: I=1, V=5, X=10, L=50, C=100, D=500, M=1000
	/// Subtraction cases: IV=4, IX=9, XL=40, XC=90, CD=400, CM=900
	/// </summary>
	/// <param name="s">The roman numeral string.</param>
	/// <returns>The integer value of the roman numeral.</returns>
	// public int RomanToInt(string s)
	// {
    //     int count = 0;
	// 	for(int i = 0; i < s.Length; i++)
    //     {
    //         if(s[i] == 'I')
    //         {
    //             if(s.Remove(0,i).Contains('V'))
    //             {
    //                 int j = 1;
    //                 while(s[i + j] != 'V' && i + j < s.Length)
    //                 {
    //                     j++;
    //                 }
    //                 count += 5 - j;
    //                 i += j;
    //             }
    //             else if(s.Remove(0,i).Contains('X'))
    //             {
    //                 int j = 1;
    //                 while(s[i + j] != 'X' && i + j < s.Length)
    //                 {
    //                     j++;
    //                 }
    //                 count += 10 - j;
    //                 i += j;
    //             }
    //             else
    //             {
    //                 count++;
    //             }
    //         }
    //         else if(s[i] == 'V')
    //         {
    //             count += 5;
    //         }
    //         else if(s[i] == 'X')
    //         {
    //             if(s.Remove(0,i).Contains('L'))
    //             {
    //                 int j = 1;
    //                 while(s[i + j] != 'L' && i + j < s.Length)
    //                 {
    //                     j++;
    //                 }
    //                 count += 50 - (j * 10);
    //                 i += j;
    //             }
    //             else if(s.Remove(0,i).Contains('C'))
    //             {
    //                 int j = 1;
    //                 while(s[i + j] != 'C' && i + j < s.Length)
    //                 {
    //                     j++;
    //                 }
    //                 count += 100 - (j * 10);
    //                 i += j;
    //             }
    //             else
    //             {
    //                 count += 10;
    //             }
    //         }
    //         else if(s[i] == 'L')
    //         {
    //             count += 50;
    //         }
    //         else if(s[i] == 'C')
    //         {
    //             if(s.Remove(0,i).Contains('D'))
    //             {
    //                 int j = 1;
    //                 while(s[i + j] != 'D' && i + j < s.Length)
    //                 {
    //                     j++;
    //                 }
    //                 count += 500 - (j * 100);
    //                 i += j;
    //             }
    //             else if(s.Remove(0,i).Contains('M'))
    //             {
    //                 int j = 1;
    //                 while(s[i + j] != 'M' && i + j < s.Length)
    //                 {
    //                     j++;
    //                 }
    //                 count += 1000 - (j * 100);
    //                 i += j;
    //             }
    //             else
    //             {
    //                 count += 100;
    //             }
    //         }
    //         else if(s[i] == 'D')
    //         {
    //             count += 500;
    //         }
    //         else if(s[i] == 'M')
    //         {
    //             count += 1000;
    //         }
    //     }

	// 	return count;
	// }

    // Refactoring and trying again

    Dictionary<char, int> romanInts = new()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
    };
    public int RomanToInt(string s)
    {
        int count = 0;
        int i = 0;
        while(i < s.Length)
        {
            int j = 0;
            //while i am not out of bound count how many of the current letter are the same as me.
            while(i+j < s.Length && s[i+j] == s[i])
            {
                j++;
            }

            if(i+j < s.Length)
            {
                //what is the next char compared to us
                if(romanInts[s[i]] < romanInts[s[i + j]])
                {
                    count += romanInts[s[i + j]] - (j * romanInts[s[i]]);
                    j++;
                }
                else
                {
                    count += j * romanInts[s[i]];
                }
            }
            else
            {
                count += romanInts[s[i]] * j;
            }
            i += j;
        }
        return count;
    }

	// Test method
	public static void Test()
	{
		var solution = new RomanToInteger();

		// --- Example Test Cases ---

		// Test 1: Example - "III" -> 3
		int result1 = solution.RomanToInt("III");
		Console.WriteLine($"Test 1: Input: 'III', Expected: 3, Got: {result1}");

		// Test 2: Example - "LVIII" -> 58 (L=50, V=5, III=3)
		int result2 = solution.RomanToInt("LVIII");
		Console.WriteLine($"Test 2: Input: 'LVIII', Expected: 58, Got: {result2}");

		// Test 3: Example - "MCMXCIV" -> 1994 (M=1000, CM=900, XC=90, IV=4)
		int result3 = solution.RomanToInt("MCMXCIV");
		Console.WriteLine($"Test 3: Input: 'MCMXCIV', Expected: 1994, Got: {result3}");

		// --- Subtraction Cases ---

		// Test 4: "IV" -> 4
		int result4 = solution.RomanToInt("IV");
		Console.WriteLine($"Test 4: Input: 'IV', Expected: 4, Got: {result4}");

		// Test 5: "IX" -> 9
		int result5 = solution.RomanToInt("IX");
		Console.WriteLine($"Test 5: Input: 'IX', Expected: 9, Got: {result5}");

		// Test 6: "XL" -> 40
		int result6 = solution.RomanToInt("XL");
		Console.WriteLine($"Test 6: Input: 'XL', Expected: 40, Got: {result6}");

		// Test 7: "XC" -> 90
		int result7 = solution.RomanToInt("XC");
		Console.WriteLine($"Test 7: Input: 'XC', Expected: 90, Got: {result7}");

		// Test 8: "CD" -> 400
		int result8 = solution.RomanToInt("CD");
		Console.WriteLine($"Test 8: Input: 'CD', Expected: 400, Got: {result8}");

		// Test 9: "CM" -> 900
		int result9 = solution.RomanToInt("CM");
		Console.WriteLine($"Test 9: Input: 'CM', Expected: 900, Got: {result9}");

		// --- Edge Cases and Variations ---

		// Test 10: Single character - "I" -> 1
		int result10 = solution.RomanToInt("I");
		Console.WriteLine($"Test 10: Input: 'I', Expected: 1, Got: {result10}");

		// Test 11: Single character - "M" -> 1000
		int result11 = solution.RomanToInt("M");
		Console.WriteLine($"Test 11: Input: 'M', Expected: 1000, Got: {result11}");

		// Test 12: Simple addition - "XII" -> 12
		int result12 = solution.RomanToInt("XII");
		Console.WriteLine($"Test 12: Input: 'XII', Expected: 12, Got: {result12}");

		// Test 13: "XXVII" -> 27
		int result13 = solution.RomanToInt("XXVII");
		Console.WriteLine($"Test 13: Input: 'XXVII', Expected: 27, Got: {result13}");

		// Test 14: Multiple subtractions - "XLIX" -> 49 (XL=40, IX=9)
		int result14 = solution.RomanToInt("XLIX");
		Console.WriteLine($"Test 14: Input: 'XLIX', Expected: 49, Got: {result14}");

		// Test 15: Complex number - "MMMCMXCIX" -> 3999 (MMM=3000, CM=900, XC=90, IX=9)
		int result15 = solution.RomanToInt("MMMCMXCIX");
		Console.WriteLine($"Test 15: Input: 'MMMCMXCIX', Expected: 3999, Got: {result15}");

		// Test 16: "DCXXI" -> 621 (D=500, C=100, XX=20, I=1)
		int result16 = solution.RomanToInt("DCXXI");
		Console.WriteLine($"Test 16: Input: 'DCXXI', Expected: 621, Got: {result16}");
	}
}