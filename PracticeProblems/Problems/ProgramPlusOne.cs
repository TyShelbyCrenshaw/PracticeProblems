namespace PracticeProblems.Problems;
public class ProgramPlusOne
{
	// This does not work if the array is long and cannot fit into an Int64
	// public int[] PlusOne(int[] digits) {
	//     //digits -> number
	//     Int64 number = 0;
	//     Int64 place = 1;
	//     for(Int64 i = digits.Length - 1; i >= 0; i--)
	//     {
	//         number += digits[i] * (place);
	//         place *= 10;
	//     }

	//     //number + 1
	//     number += 1;

	//     int howManyDigits = 0;
	//     place = number;
	//     while(place > 0)
	//     {
	//         place /= 10;
	//         howManyDigits++;
	//     }

	//     //number -> digits
	//     int[] retArr = new int[howManyDigits];
	//     for(int i = howManyDigits; i > 0; i--)
	//     {
	//         retArr[i - 1] = (int)(number % 10);
	//         number /= 10;
	//     }

	//     return retArr;
	// }

	// public int[] PlusOne(int[] digits) {
	//     bool carry = true;
	//     int place = digits.Length - 1;

	//     while (carry)
	//     {
	//         if(place < 0)
	//         {
	//             //need to rewrite the array add a 1 to the front
	//             int[] newDigits = new int[digits.Length + 1];
	//             newDigits[0] = 1;
	//             for(int i = 0; i < digits.Length; i++)
	//             {
	//                 newDigits[i + 1] = digits[i] % 10;
	//             }
	//             return newDigits;
	//         }
	//         else
	//         {                
	//             if((digits[place] + 1) % 10 != digits[place] + 1)
	//             {
	//                 carry = true;
	//             }
	//             else
	//             {
	//                 carry = false;
	//             }
	//             digits[place] = (digits[place] + 1) % 10;
	//             place--;
	//         }
	//     }

	//     return digits;
	// }

	// My soluction submitted to leetcode
	// public int[] PlusOne(int[] digits) {
	//     bool carry = true;
	//     int place = digits.Length - 1;

	//     while (carry)
	//     {
	//         if(place < 0)
	//         {
	//             //need to rewrite the array add a 1 to the front
	//             int[] newDigits = new int[digits.Length + 1];
	//             newDigits[0] = 1;
	//             for(int i = 0; i < digits.Length; i++)
	//             {
	//                 newDigits[i + 1] = digits[i] % 10;
	//             }
	//             return newDigits;
	//         }
	//         else
	//         {                
	//             if((digits[place] + 1) % 10 != digits[place] + 1)
	//             {
	//                 carry = true;
	//             }
	//             else
	//             {
	//                 carry = false;
	//             }
	//             digits[place] = (digits[place] + 1) % 10;
	//             place--;
	//         }
	//     }

	//     return digits;
	// }

	//Cluades cleaner soluction
	// public int[] PlusOne(int[] digits) {
	//     for (int i = digits.Length - 1; i >= 0; i--) {
	//         if (digits[i] < 9) {
	//             digits[i]++;
	//             return digits;
	//         }
	//         digits[i] = 0;
	//     }

	//     // If we get here, all digits were 9
	//     int[] result = new int[digits.Length + 1];
	//     result[0] = 1;
	//     return result;
	// }

	//Cluade recursive
	public int[] PlusOne(int[] digits)
	{
		// Base case: empty array means we had all 9s and need to prepend 1
		if (digits.Length == 0)
		{
			return new[] { 1 };
		}

		// Get the last digit
		int lastDigit = digits[^1];

		// If last digit is less than 9, just increment and return
		if (lastDigit < 9)
		{
			digits[^1]++;
			return digits;
		}

		// Last digit is 9, so set it to 0 and recurse on remaining digits
		int[] remaining = digits[..^1];  // All digits except the last one
		int[] result = PlusOne(remaining);

		// Append the 0 to the result
		return result.Concat(new[] { 0 }).ToArray();
	}

	// Test method with the correct test cases for Plus One
	public static void Test()
	{
		var solution = new ProgramPlusOne();

		// Test 1: [1,2,3] -> [1,2,4]
		int[] result1 = solution.PlusOne(new int[] { 1, 2, 3 });
		Console.WriteLine($"Test 1: Expected [1,2,4], Got [{string.Join(",", result1)}]");

		// Test 2: [4,3,2,1] -> [4,3,2,2]
		int[] result2 = solution.PlusOne(new int[] { 4, 3, 2, 1 });
		Console.WriteLine($"Test 2: Expected [4,3,2,2], Got [{string.Join(",", result2)}]");

		// Test 3: [9] -> [1,0]
		int[] result3 = solution.PlusOne(new int[] { 9 });
		Console.WriteLine($"Test 3: Expected [1,0], Got [{string.Join(",", result3)}]");

		// Test 4: [9,9,9] -> [1,0,0,0] (edge case with all 9s)
		int[] result4 = solution.PlusOne(new int[] { 9, 9, 9 });
		Console.WriteLine($"Test 4: Expected [1,0,0,0], Got [{string.Join(",", result4)}]");

		// Test 5: [1,9,9] -> [2,0,0]
		int[] result5 = solution.PlusOne(new int[] { 1, 9, 9 });
		Console.WriteLine($"Test 5: Expected [2,0,0], Got [{string.Join(",", result5)}]");

		// Test 6: [9,8,7,6,5,4,3,2,1,0] -> [9,8,7,6,5,4,3,2,1,1]
		int[] result6 = solution.PlusOne(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
		Console.WriteLine($"Test 5: Expected [9,8,7,6,5,4,3,2,1,1], Got [{string.Join(",", result6)}]");
	}
}