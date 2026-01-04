namespace PracticeProblems.Problems;

public class FourDivisors
{
	public int SumFourDivisors(int[] nums)
	{
        int sum = 0;
        //for each number in nums find how many devisors
        foreach(int num in nums)
        {
            int divisorCount = 0;
            List<int> divisors = new();
            //if divisor has 4
                //add to sum
            for(int i = 0; i < num + 1; i++)
            {
                if(divisorCount > 4)
                    break;
                if(i == 0)
                    continue;
                if(((double)num / (double)i) == Math.Floor((double)num / (double)i))
                {
                    divisorCount++;
                    divisors.Add(i);
                }
            }
            if(divisorCount == 4)
            {
                sum += divisors.Aggregate((total, next) => total + next);
            }
        }
		return sum;
	}

	public static void Tests()
	{
		var solution = new FourDivisors();

		int result1 = solution.SumFourDivisors(new int[] { 21, 4, 7 });
		Console.WriteLine($"Test 1: Expected 32, Got {result1}");

		int result2 = solution.SumFourDivisors(new int[] { 21, 21 });
		Console.WriteLine($"Test 2: Expected 64, Got {result2}");

		int result3 = solution.SumFourDivisors(new int[] { 1, 2, 3, 4, 5 });
		Console.WriteLine($"Test 3: Expected 0, Got {result3}");
	}
}