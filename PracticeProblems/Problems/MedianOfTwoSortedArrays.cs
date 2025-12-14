namespace PracticeProblems.Problems;

public class MedianTwoSortedArrays
{	/// <summary>
	/// Given two sorted arrays nums1 and nums2 of size m and n respectively,
	/// return the median of the two sorted arrays.
	/// The overall run time complexity should be O(log (m+n)).
	/// </summary>
	/// <param name="nums1">First sorted array.</param>
	/// <param name="nums2">Second sorted array.</param>
	/// <returns>The median of the two sorted arrays.</returns>
    
	// Works
    // public double FindMedianSortedArrays(int[] nums1, int[] nums2)
	// {
    //     //is even or odd
    //     bool even = ((nums1.Length + nums2.Length) % 2) == 0;
    //     if(nums1.Length == 0 || nums2.Length == 0 )
    //     {
    //         if(nums1.Length == 0)
    //         {
    //             if(even)
    //             {
    //                 return (nums2[nums2.Length / 2 - 1] + nums2[(nums2.Length / 2)]) / 2.0;
    //             }
    //             return nums2[nums2.Length / 2];

    //         }
    //         else if(nums2.Length == 0)
    //         {
    //             if(even)
    //             {
    //                 return (nums1[nums1.Length / 2 - 1] + nums1[(nums1.Length / 2)]) / 2.0;
    //             }
    //             return nums1[nums1.Length / 2];
    //         }
    //     }
    //     else if(nums1.Length + nums2.Length == 1)
    //     {
    //         if(nums1.Length == 1)
    //         {
    //             return nums1[0];
    //         }
    //         else
    //         {
    //             return nums2[0];
    //         }
    //     }
    //     else if(nums1.Length + nums2.Length == 2)
    //     {
    //         int count = 0;
    //         for(int i = 0; i < nums1.Length; i++)
    //         {
    //             count += nums1[i];
    //         }
    //         for(int i = 0; i < nums2.Length; i++)
    //         {
    //             count += nums2[i];
    //         }
    //         return count / 2.0;
    //     }


    //     if(!even)
    //     {
    //         int howfar = (int)Math.Ceiling((double)((nums1.Length + nums2.Length)/2));
    //         int walk = 0;
    //         int i = 0;
    //         int j = 0;
    //         int lastNum = 0;
    //         bool num1Ended = false;
    //         bool num2Ended = false;
    //         //only look at the longer list
    //         while(walk < howfar)
    //         {
    //             walk++;
    //             if(nums1[i] < nums2[j] && num1Ended == false)
    //             {
    //                 if(nums1.Length - 1 > i)
    //                 {
    //                     i++;
    //                 }
    //                 else
    //                 {
    //                     if(num1Ended)
    //                     {
    //                         j++;
    //                     }
    //                     num1Ended = true;
    //                 }
    //             }
    //             else
    //             {                    
    //                 if(nums2.Length - 1 > j)
    //                 {
    //                     j++;
    //                 }
    //                 else
    //                 {
    //                     if(num2Ended)
    //                     {
    //                         i++;
    //                     }
    //                     num2Ended = true;
    //                 }
    //             }

    //             if(num1Ended)
    //             {
    //                 lastNum = nums2[j];
    //             }
    //             else if(num2Ended)
    //             {
    //                 lastNum = nums1[i];
    //             }
    //             else
    //             {
    //                 lastNum = nums1[i] < nums2[j] ? nums1[i] : nums2[j];
    //             }
    //         }
    //         if(num1Ended)
    //         {
    //             return nums2[j];
    //         }
    //         else if(num2Ended)
    //         {
    //             return nums1[i];
    //         }
    //         return (double)lastNum;
    //     }
    //     else
    //     {
    //         int howfar = (int)Math.Ceiling((double)((nums1.Length + nums2.Length)/2));
    //         int walk = 0;
    //         int i = 0;
    //         int j = 0;
    //         Queue<int> lastNum = new ();
    //         bool num1Ended = false;
    //         bool num2Ended = false;
    //         while(walk < howfar)
    //         {
    //             walk++;
    //             if(nums1[i] < nums2[j] && num1Ended == false)
    //             {
    //                 if(nums1.Length - 1 > i)
    //                 {
    //                     i++;
    //                 }
    //                 else 
    //                 {
    //                     if(num1Ended)
    //                     {
    //                         j++;
    //                     }
    //                     num1Ended = true;
    //                 }
    //             }
    //             else
    //             {                    
    //                 if(nums2.Length - 1 > j)
    //                 {
    //                     j++;
    //                 }
    //                 else
    //                 {
    //                     if(num2Ended)
    //                     {
    //                         i++;
    //                     }
    //                     num2Ended = true;
    //                 }
    //             }


    //             if(lastNum.Count < 2)
    //             {
    //                 if(num1Ended)
    //                 {
    //                     lastNum.Enqueue(nums2[j]);
    //                 }
    //                 else if(num2Ended)
    //                 {
    //                     lastNum.Enqueue(nums1[i]);
    //                 }
    //                 else
    //                 {
    //                     lastNum.Enqueue(nums1[i] < nums2[j] ? nums1[i] : nums2[j]);
    //                 }

    //             }
    //             else
    //             {
    //                 lastNum.Dequeue();
    //                 if(num1Ended)
    //                 {
    //                     lastNum.Enqueue(nums2[j]);
    //                 }
    //                 else if(num2Ended)
    //                 {
    //                     lastNum.Enqueue(nums1[i]);
    //                 }
    //                 else
    //                 {
    //                     lastNum.Enqueue(nums1[i] < nums2[j] ? nums1[i] : nums2[j]);
    //                 }
    //             }
    //         }
    //         return (lastNum.Dequeue() + lastNum.Dequeue()) / 2.0;
    //     }
	// }

    //Do it not in O(log (m+n))
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
	{
        bool even = ((nums1.Length + nums2.Length) % 2) == 0;
        List<int> list = new();
        list.AddRange(nums1);
        list.AddRange(nums2);
        list.Sort();
        if(even)
        {
            return (list[(list.Count / 2) - 1] + list[(list.Count / 2)]) / 2.0;
        }
        else
        {
            return list[(list.Count / 2)];
        }
    }

	// Test method
	public static void Test()
	{
		var solution = new MedianTwoSortedArrays();

		// --- Example Test Cases ---

		// Test 1: Example 1 - nums1 = [1,3], nums2 = [2] -> 2.0
		double result1 = solution.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 });
		Console.WriteLine($"Test 1: Input: nums1=[1,3], nums2=[2], Expected: 2.0, Got: {result1}");

		// Test 2: Example 2 - nums1 = [1,2], nums2 = [3,4] -> 2.5
		double result2 = solution.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 });
		Console.WriteLine($"Test 2: Input: nums1=[1,2], nums2=[3,4], Expected: 2.5, Got: {result2}");

		// --- Edge Cases ---

		// Test 3: One empty array - nums1 = [], nums2 = [1] -> 1.0
		double result3 = solution.FindMedianSortedArrays(new int[] { }, new int[] { 1 });
		Console.WriteLine($"Test 3: Input: nums1=[], nums2=[1], Expected: 1.0, Got: {result3}");

		// Test 4: One empty array - nums1 = [2], nums2 = [] -> 2.0
		double result4 = solution.FindMedianSortedArrays(new int[] { 2 }, new int[] { });
		Console.WriteLine($"Test 4: Input: nums1=[2], nums2=[], Expected: 2.0, Got: {result4}");

		// Test 5: Both arrays have one element - nums1 = [1], nums2 = [2] -> 1.5
		double result5 = solution.FindMedianSortedArrays(new int[] { 1 }, new int[] { 2 });
		Console.WriteLine($"Test 5: Input: nums1=[1], nums2=[2], Expected: 1.5, Got: {result5}");

		// Test 6: Equal length arrays - nums1 = [1,3,5], nums2 = [2,4,6] -> 3.5
		double result6 = solution.FindMedianSortedArrays(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 });
		Console.WriteLine($"Test 6: Input: nums1=[1,3,5], nums2=[2,4,6], Expected: 3.5, Got: {result6}");

		// Test 7: Different length arrays - nums1 = [1,2,3,4,5], nums2 = [6,7] -> 4.0
		double result7 = solution.FindMedianSortedArrays(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7 });
		Console.WriteLine($"Test 7: Input: nums1=[1,2,3,4,5], nums2=[6,7], Expected: 4.0, Got: {result7}");

		// Test 8: Different length arrays - nums1 = [1], nums2 = [2,3,4,5,6] -> 3.5
		double result8 = solution.FindMedianSortedArrays(new int[] { 1 }, new int[] { 2, 3, 4, 5, 6 });
		Console.WriteLine($"Test 8: Input: nums1=[1], nums2=[2,3,4,5,6], Expected: 3.5, Got: {result8}");

		// Test 9: All elements in nums1 smaller than nums2 - nums1 = [1,2], nums2 = [3,4,5] -> 3.0
		double result9 = solution.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4, 5 });
		Console.WriteLine($"Test 9: Input: nums1=[1,2], nums2=[3,4,5], Expected: 3.0, Got: {result9}");

		// Test 10: All elements in nums2 smaller than nums1 - nums1 = [4,5,6], nums2 = [1,2,3] -> 3.5
		double result10 = solution.FindMedianSortedArrays(new int[] { 4, 5, 6 }, new int[] { 1, 2, 3 });
		Console.WriteLine($"Test 10: Input: nums1=[4,5,6], nums2=[1,2,3], Expected: 3.5, Got: {result10}");

		// Test 11: Arrays with negative numbers - nums1 = [-5,-3,-1], nums2 = [0,2,4] -> -0.5
		double result11 = solution.FindMedianSortedArrays(new int[] { -5, -3, -1 }, new int[] { 0, 2, 4 });
		Console.WriteLine($"Test 11: Input: nums1=[-5,-3,-1], nums2=[0,2,4], Expected: -0.5, Got: {result11}");

		// Test 12: Arrays with duplicate values - nums1 = [1,1,1], nums2 = [1,1,1] -> 1.0
		double result12 = solution.FindMedianSortedArrays(new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 });
		Console.WriteLine($"Test 12: Input: nums1=[1,1,1], nums2=[1,1,1], Expected: 1.0, Got: {result12}");

		// Test 13: Larger arrays - nums1 = [1,3,5,7,9], nums2 = [2,4,6,8,10,12] -> 6.0
		double result13 = solution.FindMedianSortedArrays(new int[] { 1, 3, 5, 7, 9 }, new int[] { 2, 4, 6, 8, 10, 12 });
		Console.WriteLine($"Test 13: Input: nums1=[1,3,5,7,9], nums2=[2,4,6,8,10,12], Expected: 6.0, Got: {result13}");

		// Test 14: One element each, same value - nums1 = [5], nums2 = [5] -> 5.0
		double result14 = solution.FindMedianSortedArrays(new int[] { 5 }, new int[] { 5 });
		Console.WriteLine($"Test 14: Input: nums1=[5], nums2=[5], Expected: 5.0, Got: {result14}");

		// Test 15: Interleaved values - nums1 = [1,3,8,9,15], nums2 = [7,11,18,19,21,25] -> 11.0
		double result15 = solution.FindMedianSortedArrays(new int[] { 1, 3, 8, 9, 15 }, new int[] { 7, 11, 18, 19, 21, 25 });
		Console.WriteLine($"Test 15: Input: nums1=[1,3,8,9,15], nums2=[7,11,18,19,21,25], Expected: 11.0, Got: {result15}");

        double result16 = solution.FindMedianSortedArrays(new int[] { 1, 3, 8, 9, 15, 16, 17, 18, 19, 20 }, new int[] { 7 });
		Console.WriteLine($"Test 16: Input: nums1=[ 1, 3, 8, 9, 15, 16, 17, 18, 19, 20 ], nums2=[ 7 ], Expected: 15.0, Got: {result16}");

        double result17 = solution.FindMedianSortedArrays(new int[] { 1, 3, 8, 9, 15, 16, 17, 18, 19 }, new int[] { 7 });
		Console.WriteLine($"Test 17: Input: nums1=[ 1, 3, 8, 9, 15, 16, 17, 18, 19 ], nums2=[ 7 ], Expected: 12.0, Got: {result17}");

        double result18 = solution.FindMedianSortedArrays(new int[] { }, new int[] { 1, 2, 3, 4 });
		Console.WriteLine($"Test 18: Input: nums1=[ ], nums2=[ 1, 2, 3, 4  ], Expected: 2.5, Got: {result18}");
	}
}