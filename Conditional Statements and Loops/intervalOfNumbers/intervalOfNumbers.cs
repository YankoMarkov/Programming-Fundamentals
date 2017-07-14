using System;
using System.Collections.Generic;
using System.Linq;

public class intervalOfNumbers
{
    public static void Main(string[] args)
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());
        var firstNum = Math.Min(firstNumber, secondNumber);
        var secondNum = Math.Max(firstNumber, secondNumber);

        for (int i = firstNum; i <= secondNum; i++)
        {
            Console.WriteLine(i);
        }
    }
}

