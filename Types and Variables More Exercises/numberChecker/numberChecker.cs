using System;
using System.Collections.Generic;
using System.Linq;
public class numberChecker
{
    public static void Main(string[] args)
    {
        var number = Console.ReadLine();

        if (number.Contains('.'))
        {
            Console.WriteLine("floating-point");
        }
        else
        {
            Console.WriteLine("integer");
        }
    }
}

