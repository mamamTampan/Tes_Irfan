using System;

class Program
{
	static void Main()
	{
		string inputString = "3943";
		int k = 1;

		string result = HighestPalindrome(inputString, k);

		Console.WriteLine("Output: " + result);
	}

	static string HighestPalindrome(string str, int k)
	{
		char[] arr = str.ToCharArray();
		return FindHighestPalindrome(arr, 0, arr.Length - 1, k).ToString();
	}

	static long FindHighestPalindrome(char[] arr, int left, int right, int k)
	{
		if (k < 0)
			return -1;

		if (left >= right)
			return Convert.ToInt64(new string(arr));

		if (arr[left] != arr[right])
		{
			arr[left] = arr[right] = (char)Math.Max(arr[left], arr[right]);
			return FindHighestPalindrome(arr, left + 1, right - 1, k - 1);
		}

		return FindHighestPalindrome(arr, left + 1, right - 1, k);
	}
}
