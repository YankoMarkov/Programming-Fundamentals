using System;
using System.Collections.Generic;
using System.Linq;

public class hotel
{
    public static void Main(string[] args)
    {
        var month = Console.ReadLine();
        var nights = int.Parse(Console.ReadLine());

        var studio = 0.0;
        var dvoino = 0.0;
        var suite = 0.0;
        var studioPrice = 0.0;
        var doublePrice = 0.0;
        var suitePrice = 0.0;

        switch (month)
        {
            case "May":
            case "October":
                if (nights > 7)
                {
                    studio = 50 * 0.95;
                }
                else
                {
                    studio = 50;
                }
                dvoino = 65;
                suite = 75;
                break;
            case "June":
            case "September":
                if (nights > 14)
                {
                    dvoino = 72 * 0.90;
                }
                else
                {
                    dvoino = 72;
                }
                studio = 60;
                suite = 82;
                break;
            case "July":
            case "August":
            case "December":
                if (nights > 14)
                {
                    suite = 89 * 0.85;
                }
                else
                {
                    suite = 89;
                }
                studio = 68;
                dvoino = 77;
                break;
            default:
                break;
        }
        if ((month == "September" && nights > 7) || (month == "October" && nights > 7))
        {
            studioPrice = (nights - 1) * studio;
        }
        else
        {
            studioPrice = nights * studio;
        }
        doublePrice = nights * dvoino;
        suitePrice = nights * suite;

        Console.WriteLine($"Studio: {studioPrice:F2} lv.");
        Console.WriteLine($"Double: {doublePrice:F2} lv.");
        Console.WriteLine($"Suite: {suitePrice:F2} lv.");
    }
}

