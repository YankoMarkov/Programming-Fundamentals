using System;
using System.Collections.Generic;
using System.Linq;

public class exchangeVariableValues
{
    public static void Main(string[] args)
    {
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Before:");
        Console.WriteLine($"a = {num1}");
        Console.WriteLine($"b = {num2}");

        var temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("After:");
        Console.WriteLine($"a = {num1}");
        Console.WriteLine($"b = {num2}");
    }
}

