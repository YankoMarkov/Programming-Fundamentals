﻿using System;
using System.Collections.Generic;
using System.Linq;

public class chooseADrink
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();

        switch (input)
        {
            case "Athlete":
                Console.WriteLine("Water");
                break;
            case "Businessman":
            case "Businesswoman":
                Console.WriteLine("Coffee");
                break;
            case "SoftUni Student":
                Console.WriteLine("Beer");
                break;
            default:
                Console.WriteLine("Tea");
                break;
        }
    }
}


