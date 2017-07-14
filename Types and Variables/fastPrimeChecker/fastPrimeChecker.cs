using System;
using System.Collections.Generic;
using System.Linq;

public class fastPrimeChecker
{
    public static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());
        for (int i = 2; i <= num; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"{i} -> {isPrime}");
        }
    }
}

