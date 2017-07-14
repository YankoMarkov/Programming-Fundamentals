using System;
using System.Collections.Generic;
using System.Linq;

public class vaporStore
{
    public static void Main(string[] args)
    {
        var currentBalance = double.Parse(Console.ReadLine());
        string games = null;
        var totalSpend = 0.0;

        while (!(games = Console.ReadLine()).Equals("Game Time"))
        {
            var price = 0.0;
            switch (games)
            {
                case "OutFall 4":
                    price = 39.99;
                    break;
                case "CS: OG":
                    price = 15.99;
                    break;
                case "Zplinter Zell":
                    price = 19.99;
                    break;
                case "Honored 2":
                    price = 59.99;
                    break;
                case "RoverWatch":
                    price = 29.99;
                    break;
                case "RoverWatch Origins Edition":
                    price = 39.99;
                    break;
                default:
                    Console.WriteLine("Not Found");
                    continue;
                    break;
            }
            if (price > 0)
            {
                if (currentBalance >= price)
                {
                    Console.WriteLine($"Bought {games}");
                    currentBalance -= price;
                    totalSpend += price;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
            }
            if (currentBalance <= 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
        }
        Console.WriteLine($"Total spent: ${totalSpend:F2}. Remaining: ${currentBalance:F2}");
    }
}

