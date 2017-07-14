using System;
using System.Collections.Generic;
using System.Linq;


public class EnduranceRally
{
    public static void Main()
    {
        var names = Console.ReadLine().Split(new[] { ' ' }).ToArray();
        var track = Console.ReadLine().Split(new[] { ' ' }).Select(double.Parse).ToArray();
        var checkpoint = Console.ReadLine().Split(new[] { ' ' }).Select(int.Parse).ToArray();

        foreach (var name in names)
        {
            double fuel = name.First();
            for (int i = 0; i < track.Length; i++)
            {
                if (checkpoint.Contains(i))
                {
                    fuel += track[i];
                }
                else
                {
                    fuel -= track[i];
                }
                if (fuel <= 0)
                {
                    Console.WriteLine($"{name} - reached {i}");
                    break;
                }
            }
            if (fuel > 0)
            {
                Console.WriteLine($"{name} - fuel left {fuel:F2}");
            }
        }
    }
}

