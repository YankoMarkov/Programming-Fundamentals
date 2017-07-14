using System;
using System.Collections.Generic;
using System.Linq;

public class waterOverflow
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var capacity = 255;
        var tankCapacity = capacity;

        for (int i = 0; i < n; i++)
        {
            var literForPour = int.Parse(Console.ReadLine());

            if (tankCapacity - literForPour >= 0)
            {
                tankCapacity -= literForPour;
            }
            else
            {
                Console.WriteLine("Insufficient capacity!");
            }
        }
        var total = capacity - tankCapacity;
        Console.WriteLine(total);
    }
}

