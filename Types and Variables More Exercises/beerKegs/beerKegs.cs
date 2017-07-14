using System;
using System.Collections.Generic;
using System.Linq;

public class beerKegs
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var result = 0.0;
        var tempRes = 0.0;
        var names = "";
        var models = "";

        for (int i = 0; i < n; i++)
        {
            var model = Console.ReadLine();
            var radius = double.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            tempRes = Math.PI * Math.Pow(radius, 2) * height;
            if (result <= tempRes)
            {
                result = tempRes;
                models = model;
            }
        }
        Console.WriteLine(models);
    }
}

