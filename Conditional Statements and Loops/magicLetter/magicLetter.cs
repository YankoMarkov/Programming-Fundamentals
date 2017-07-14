using System;
using System.Collections.Generic;
using System.Linq;

public class magicLetter
{
    public static void Main(string[] args)
    {
        var first = char.Parse(Console.ReadLine());
        var second = char.Parse(Console.ReadLine());
        var exclusive = char.Parse(Console.ReadLine());

        for (char i = first; i <= second; i++)
        {
            for (char j = first; j <= second; j++)
            {
                for (char k = first; k <= second; k++)
                {
                    if (i != exclusive && j != exclusive && k != exclusive)
                    {
                        Console.Write($"{i}{j}{k} ");
                    }
                }
            }
        }
    }
}

