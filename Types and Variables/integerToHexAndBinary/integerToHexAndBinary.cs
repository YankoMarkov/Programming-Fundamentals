using System;
using System.Collections.Generic;
using System.Linq;

public class integerToHexAndBinary
{
    public static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());

        var hexadecimal = num.ToString("X");
        var binary = Convert.ToString(num, 2);

        Console.WriteLine(hexadecimal);
        Console.WriteLine(binary);
    }
}

