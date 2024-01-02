using System;
using System.Collections.Generic;

class BalancedBracket
{
	static string IsBalanced(string expression)
	{
		Stack<char> stack = new Stack<char>();
		Dictionary<char, char> brackets = new Dictionary<char, char>
		{
			{'(', ')'},
			{'[', ']'},
			{'{', '}'}
		};

		foreach (char c in expression)
		{
			if (brackets.ContainsKey(c))
			{
				stack.Push(c);
			}
			else if (brackets.ContainsValue(c))
			{
				if (stack.Count == 0 || brackets[stack.Pop()] != c)
				{
					return "NO";
				}
			}
		}

		return stack.Count == 0 ? "YES" : "NO";
	}

	static void Main()
	{
		string sample1 = "{[()]}";
		string sample2 = "{ [ ( ] ) }";
		string sample3 = "{( ( [] ) [] ) []}";

		Console.WriteLine($"Sample 1:\nInput: {sample1}\nOutput: {IsBalanced(sample1)}");
		Console.WriteLine($"Sample 2:\nInput: {sample2}\nOutput: {IsBalanced(sample2)}");
		Console.WriteLine($"Sample 3:\nInput: {sample3}\nOutput: {IsBalanced(sample3)}");
	}
}