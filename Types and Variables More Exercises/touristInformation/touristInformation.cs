using System;
using System.Collections.Generic;
using System.Linq;

public class touristInformation
{
    public static void Main(string[] args)
    {
        var unitFrom = Console.ReadLine();
        var value = double.Parse(Console.ReadLine());

        var rate = 0.0;
        var unitTo = "";
        switch (unitFrom)
        {
            case "miles":
                rate = 1.6;
                unitTo = "kilometers";
                break;
            case "inches":
                rate = 2.54;
                unitTo = "centimeters";
                break;
            case "feet":
                rate = 30;
                unitTo = "centimeters";
                break;
            case "yards":
                rate = 0.91;
                unitTo = "meters";
                break;
            case "gallons":
                rate = 3.8;
                unitTo = "liters";
                break;
            default:
                break;
        }
        var result = value * rate;
        Console.WriteLine($"{value} {unitFrom} = {result:F2} {unitTo}");
    }
}

