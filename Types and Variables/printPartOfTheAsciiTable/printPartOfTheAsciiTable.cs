using System;
using System.Collections.Generic;
using System.Linq;

public class printPartOfTheAsciiTable
{
    public static void Main(string[] args)
    {
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());

        for (int i = num1; i <= num2; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}

