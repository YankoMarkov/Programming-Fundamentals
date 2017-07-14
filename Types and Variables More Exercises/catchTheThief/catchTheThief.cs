using System;
using System.Collections.Generic;
using System.Linq;

public class catchTheThief
{
    public static void Main(string[] args)
    {
        var numeralType = Console.ReadLine();
        var n = int.Parse(Console.ReadLine());

        long max = 0;

        switch (numeralType)
        {
            case "sbyte":
                max = sbyte.MaxValue;
                break;
            case "int":
                max = int.MaxValue;
                break;
            case "long":
                max = long.MaxValue;
                break;
            default:
                break;
        }

        var thiefId = long.MinValue;

        for (int i = 0; i < n; i++)
        {
            var number = long.Parse(Console.ReadLine());

            if (number > thiefId && number <= max)
            {
                thiefId = number;
            }
        }
        Console.WriteLine(thiefId);
    }
}

