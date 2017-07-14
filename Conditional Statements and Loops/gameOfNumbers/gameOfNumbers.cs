using System;
using System.Collections.Generic;
using System.Linq;

public class gameOfNumbers
{
    public static void Main(string[] args)
    {
        var firstNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());
        var magicNum = int.Parse(Console.ReadLine());
        var combination = 0;
        var first = Math.Min(firstNum, secondNum);
        var second = Math.Max(firstNum, secondNum);
        var check = false;

        for (int i = second; i >= first; i--)
        {
            for (int j = second; j >= first; j--)
            {
                combination++;

                if ((i + j) == magicNum)
                {
                    Console.WriteLine($"Number found! {i} + {j} = {magicNum}");
                    check = true;
                    break;
                }
            }

            if (check)
            {
                break;
            }
        }

        if (!check)
        {
            Console.WriteLine($"{combination} combinations - neither equals {magicNum}");
        }
    }
}

