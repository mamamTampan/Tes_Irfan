using System;
using System.Collections.Generic;

class WeightedStrings
{
    static void Main()
    {
        string s = "abbcccd";
        List<int> queries = new List<int> { 1, 3, 9, 8 };

        List<string> substrings = GenerateSubstrings(s);
        List<int> weights = CalculateWeights(substrings);

        List<string> results = CheckQueries(queries, weights);

        Console.WriteLine("Output: [" + string.Join(", ", results) + "]");
    }

    static List<string> GenerateSubstrings(string s)
    {
        List<string> substrings = new List<string>();
        for (int i = 0; i < s.Length; i++)
        {
            char currentChar = s[i].ToString()[0];
            string substring = currentChar.ToString();

            for (int j = i + 1; j < s.Length; j++)
            {
                if (s[j] == currentChar)
                {
                    substring += currentChar;
                }
                else
                {
                    break;
                }
            }

            substrings.Add(substring);
        }

        return substrings;
    }

    static List<int> CalculateWeights(List<string> substrings)
    {
        List<int> weights = new List<int>();
        foreach (string substring in substrings)
        {
            int weight = 0;
            foreach (char c in substring)
            {
                weight += (int)(c - 'a') + 1;
            }
            weights.Add(weight);
        }

        return weights;
    }

    static List<string> CheckQueries(List<int> queries, List<int> weights)
    {
        List<string> results = new List<string>();
        foreach (int query in queries)
        {
            if (weights.Contains(query))
            {
                results.Add("Yes");
            }
            else
            {
                results.Add("No");
            }
        }

        return results;
    }
}
