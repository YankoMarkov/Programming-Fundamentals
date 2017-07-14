using System;
using System.Collections.Generic;
using System.Linq;

public class houseBuilder
{
    public static void Main(string[] args)
    {
        var firstNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());

        var sbytes = 0;
        var ints = 0;

        if (firstNum <= sbyte.MaxValue)
        {
            sbytes = firstNum;
            ints = secondNum;
        }
        else
        {
            sbytes = secondNum;
            ints = firstNum;
        }
        int totalByte = sbytes * 4;
        long totalInt = (long)ints * 10;
        long totalPrice = totalByte + totalInt;
        
        Console.WriteLine(totalPrice);
    }
}

