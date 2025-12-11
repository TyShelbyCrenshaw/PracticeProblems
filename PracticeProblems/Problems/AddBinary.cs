namespace PracticeProblems.Problems;

public class AddBinary
{
	public string MyAddBinary(string a, string b)
	{
		var length = a.Length >= b.Length ? a.Length : b.Length;

		byte[] aArr = new byte[length];
		byte[] bArr = new byte[length];

		for (int i = a.Length - 1; i >= 0; i--)
		{
			if (a[i] == '1')
			{
				aArr[length - a.Length + i] = 1;
			}
		}

		for (int i = b.Length - 1; i >= 0; i--)
		{
			if (b[i] == '1')
			{
				bArr[length - b.Length + i] = 1;
			}
		}


		byte[] retArr = new byte[length];
		byte carry = new byte();

		for (int i = length - 1; i >= 0; i--)
		{
			byte val = (byte)(aArr[i] + bArr[i] + carry);
			retArr[i] = (byte)(val % 2);
			carry = (byte)(val / 2);
		}
		if (carry > 0)
		{
			retArr = new byte[] { 1 }.Concat(retArr).ToArray();
		}


		string retString = "";
		for (int i = 0; i < retArr.Length; i++)
		{
			retString += retArr[i];
		}

		return retString;
	}

	public static void Test()
	{
		var solution = new AddBinary();

		// Test 1: "11" + "1" = "100"
		string result1 = solution.MyAddBinary("11", "1");
		Console.WriteLine($"Test 1: Expected \"100\", Got \"{result1}\"");

		// Test 2: "1010" + "1011" = "10101"
		string result2 = solution.MyAddBinary("1010", "1011");
		Console.WriteLine($"Test 2: Expected \"10101\", Got \"{result2}\"");

		// Test 3: "0" + "0" = "0"
		string result3 = solution.MyAddBinary("0", "0");
		Console.WriteLine($"Test 3: Expected \"0\", Got \"{result3}\"");

		// Test 4: "1111" + "1111" = "11110"
		string result4 = solution.MyAddBinary("1111", "1111");
		Console.WriteLine($"Test 4: Expected \"11110\", Got \"{result4}\"");

		// Test 5: "1" + "111" = "1000"
		string result5 = solution.MyAddBinary("1", "111");
		Console.WriteLine($"Test 5: Expected \"1000\", Got \"{result5}\"");
	}
}