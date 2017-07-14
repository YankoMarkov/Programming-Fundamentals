using System;
using System.Collections.Generic;
using System.Linq;

public class sentenceTheThief
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
        double result = 0.0;

        for (int i = 0; i < n; i++)
        {
            var number = long.Parse(Console.ReadLine());

            if (number > thiefId && number <= max)
            {
                thiefId = number;
            }
            if (thiefId > 0)
            {
                result = thiefId / 127.0;
            }
            else
            {
                result = thiefId / -128.0;
            }
        }
        if (result > 1)
        {
            Console.WriteLine($"Prisoner with id {thiefId} is sentenced to {Math.Ceiling(result)} years");
        }
        else
        {
            Console.WriteLine($"Prisoner with id {thiefId} is sentenced to {Math.Ceiling(result)} year");
        }

    }
}

