using System;
using System.Collections.Generic;
using System.Linq;

public class triangleOfNumbers
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}

