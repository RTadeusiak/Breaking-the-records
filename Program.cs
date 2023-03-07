using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static List<int> breakingRecords(List<int> scores)
    {
        int max = scores[0];
        int min = scores[0];
        int maxChanges = 0;
        int minChanges = 0;

        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i] > max)
            {
                max = scores[i];
                maxChanges++;
            }
            else if (scores[i] < min)
            {
                min = scores[i];
                minChanges++;
            }
        }

        List<int> result = new List<int>();
        result.Add(maxChanges);
        result.Add(minChanges);
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        Console.WriteLine(String.Join(" ", result));

    }
}
