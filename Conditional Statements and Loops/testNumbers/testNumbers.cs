using System;
using System.Collections.Generic;
using System.Linq;

public class testNumbers
{
    public static void Main(string[] args)
    {
        var firsNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());
        var maxSum = int.Parse(Console.ReadLine());

        var sum = 0;
        var count = 0;

        for (int i = firsNum; i >= 1; i--)
        {
            for (int j = 1; j <= secondNum; j++)
            {
                sum += (i * j) * 3;
                count++;
                if (sum >= maxSum)
                {
                    break;
                }
            }
            if (sum >= maxSum)
            {
                break;
            }
        }
        if (sum >= maxSum)
        {
            Console.WriteLine($"{count} combinations");
            Console.WriteLine($"Sum: {sum} >= {maxSum}");
        }
        else
        {
            Console.WriteLine($"{count} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

