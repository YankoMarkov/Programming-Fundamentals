using System;
using System.Collections.Generic;
using System.Linq;

public class weatherForecast
{
    public static void Main(string[] args)
    {
        var num = decimal.Parse(Console.ReadLine());

        var isSbyteMax = sbyte.MaxValue;
        var isSbyteMin = sbyte.MinValue;
        var isIntMax = int.MaxValue;
        var isIntMin = int.MinValue;
        var isLongMax = long.MaxValue;
        var isLongMin = long.MinValue;

        if (num.ToString().Contains('.'))
        {
            Console.WriteLine("Rainy");
            return;
        }
        if (num <= isSbyteMax && num >= isSbyteMin)
        {
            Console.WriteLine("Sunny");
            return;
        }
        if (num <= isIntMax && num >= isIntMin)
        {
            Console.WriteLine("Cloudy");
            return;
        }
        if (num <= isLongMax && num >= isLongMin)
        {
            Console.WriteLine("Windy");
            return;
        }
    }
}

