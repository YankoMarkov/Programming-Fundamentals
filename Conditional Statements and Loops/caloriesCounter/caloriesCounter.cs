using System;
using System.Collections.Generic;
using System.Linq;

public class caloriesCounter
{
    public static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());

        var cheese = 500;
        var tomatoSauce = 150;
        var salami = 600;
        var peper = 50;
        var totalCalories = 0;

        for (int i = 0; i < num; i++)
        {
            var input = Console.ReadLine().ToLower();
            if (input == "cheese")
            {
                totalCalories += cheese;
            }
            if (input == "tomato sauce")
            {
                totalCalories += tomatoSauce;
            }
            if (input == "salami")
            {
                totalCalories += salami;
            }
            if (input == "pepper")
            {
                totalCalories += peper;
            }
        }
        Console.WriteLine($"Total calories: {totalCalories}");
    }
}

