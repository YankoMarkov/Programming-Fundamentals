using System;
using System.Collections.Generic;
using System.Linq;

public class comparingFloats
{
    public static void Main(string[] args)
    {
        var num1 = double.Parse(Console.ReadLine());
        var num2 = double.Parse(Console.ReadLine());

        var eps = 0.000001;
        var difference = Math.Abs(num1 - num2);

        if (difference >= eps)
        {
            Console.WriteLine("False");
        }
        else
        {
            Console.WriteLine("True");
        }
    }
}

