using System;
using System.Collections.Generic;
using System.Linq;

public class MilesToKilometers
{
    public static void Main()
    {
        var miles = double.Parse(Console.ReadLine());
        var rate = 1.60934;

        var kilometers = miles * rate;
        Console.WriteLine($"{kilometers:F2}");
    }
}

