using System;
using System.Collections.Generic;
using System.Linq;

public class makeAWord
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var result = "";

        for (int i = 0; i < n; i++)
        {
            var letter = Console.ReadLine();
            result += letter;
        }
        Console.WriteLine($"The word is: {result}");
    }
}

