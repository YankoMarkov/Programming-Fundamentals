using System;
using System.Collections.Generic;
using System.Linq;

public class chooseADrink2
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var cuantity = int.Parse(Console.ReadLine());

        switch (input)
        {
            case "Athlete":
                var waterPrice = 0.70;
                Console.WriteLine($"The {input} has to pay {cuantity * waterPrice:F2}.");
                break;
            case "Businessman":
            case "Businesswoman":
                var coffeePrice = 1.00;
                Console.WriteLine($"The {input} has to pay {cuantity * coffeePrice:F2}.");
                break;
            case "SoftUni Student":
                var beerPrice = 1.70;
                Console.WriteLine($"The {input} has to pay {cuantity * beerPrice:F2}.");
                break;
            default:
                var teaPrice = 1.20;
                Console.WriteLine($"The {input} has to pay {cuantity * teaPrice:F2}.");
                break;
        }
    }
}

