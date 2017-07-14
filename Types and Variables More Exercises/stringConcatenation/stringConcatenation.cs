using System;
using System.Collections.Generic;
using System.Linq;

public class stringConcatenation
{
    public static void Main(string[] args)
    {
        var delimiter = char.Parse(Console.ReadLine());
        var evenOrOdd = Console.ReadLine();
        var n = int.Parse(Console.ReadLine());
        var result = "";

        for (int i = 1; i <= n; i++)
        {
            var input = Console.ReadLine();

            if (evenOrOdd == "even")
            {
                if (i % 2 == 0)
                {
                    result += input + delimiter;
                }
            }
            else if (evenOrOdd == "odd")
            {
                if (i % 2 != 0)
                {
                    result += input + delimiter;
                }
            }
        }
        result = result.Remove(result.Length - 1, 1);
        Console.WriteLine(result);
    }
}

