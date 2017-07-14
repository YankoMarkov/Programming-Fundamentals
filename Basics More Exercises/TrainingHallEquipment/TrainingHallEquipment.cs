using System;
using System.Collections.Generic;
using System.Linq;

public class trainingHallEquipment
{
    public static void Main(string[] args)
    {
        var budget = double.Parse(Console.ReadLine());
        var numberOfItems = int.Parse(Console.ReadLine());

        var subTotal = 0.0;
        var money = 0.0;

        for (int i = 0; i < numberOfItems; i++)
        {
            var itemName = Console.ReadLine();
            var itemPrice = double.Parse(Console.ReadLine());
            var itemCount = int.Parse(Console.ReadLine());
            subTotal += itemPrice * itemCount;
            if (itemCount > 1)
            {
                Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
            }
            else
            {
                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
            }
        }
        Console.WriteLine($"Subtotal: ${subTotal:F2}");
        if (budget >= subTotal)
        {
            money = budget - subTotal;
            Console.WriteLine($"Money left: ${money:F2}");
        }
        else
        {
            money = subTotal - budget;
            Console.WriteLine($"Not enough. We need ${money:F2} more.");
        }
    }
}

