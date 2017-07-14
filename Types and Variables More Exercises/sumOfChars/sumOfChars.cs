using System;
using System.Collections.Generic;
using System.Linq;

public class sumOfChars
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var sum = 0;

        for (int i = 0; i < n; i++)
        {
            var input = char.Parse(Console.ReadLine());

            var letter = (int)input;
            sum += letter;
        }
        Console.WriteLine($"The sum equals: {sum}");
    }
}

