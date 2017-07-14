using System;
using System.Collections.Generic;
using System.Linq;

public class cakeIngredients
{
    public static void Main(string[] args)
    {
        string input = null;
        var count = 0;

        while (!(input = Console.ReadLine()).Equals("Bake!"))
        {
            Console.WriteLine($"Adding ingredient {input}.");
            count++;
        }
        Console.WriteLine($"Preparing cake with {count} ingredients.");
    }
}

