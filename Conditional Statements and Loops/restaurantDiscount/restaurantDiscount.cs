using System;
using System.Collections.Generic;
using System.Linq;

public class restaurantDiscount
{
    public static void Main(string[] args)
    {
        var groupSize = int.Parse(Console.ReadLine());
        var package = Console.ReadLine();

        var hallPrice = 0;

        if (groupSize <= 50)
        {
            hallPrice = 2500;
            Console.WriteLine("We can offer you the Small Hall");
        }
        if (groupSize > 50 && groupSize <= 100)
        {
            hallPrice = 5000;
            Console.WriteLine("We can offer you the Terrace");
        }
        if (groupSize > 100 && groupSize <= 120)
        {
            hallPrice = 7500;
            Console.WriteLine("We can offer you the Great Hall");
        }
        if (groupSize > 120)
        {
            Console.WriteLine("We do not have an appropriate hall.");
            return;
        }

        switch (package)
        {
            case "Normal":
                if (groupSize <= 50)
                {
                    price(0.05, 500, hallPrice, groupSize);
                }
                if (groupSize > 50 && groupSize <= 100)
                {
                    price(0.05, 500, hallPrice, groupSize);
                }
                if (groupSize > 100 && groupSize <= 120)
                {
                    price(0.05, 500, hallPrice, groupSize);
                }
                break;
            case "Gold":
                if (groupSize <= 50)
                {
                    price(0.1, 750, hallPrice, groupSize);
                }
                if (groupSize > 50 && groupSize <= 100)
                {
                    price(0.1, 750, hallPrice, groupSize);
                }
                if (groupSize > 100 && groupSize <= 120)
                {
                    price(0.1, 750, hallPrice, groupSize);
                }
                break;
            case "Platinum":
                if (groupSize <= 50)
                {
                    price(0.15, 1000, hallPrice, groupSize);
                }
                if (groupSize > 50 && groupSize <= 100)
                {
                    price(0.15, 1000, hallPrice, groupSize);
                }
                if (groupSize > 100 && groupSize <= 120)
                {
                    price(0.15, 1000, hallPrice, groupSize);
                }
                break;
            default:
                break;

        }
    }

    private static void price(double discount, int packagePrice, int hallPrice, int groupSize)
    {
        var totalPrice = (packagePrice + hallPrice) - (packagePrice + hallPrice) * discount;
        var pricePerPerson = totalPrice / groupSize;
        Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
    }
}

