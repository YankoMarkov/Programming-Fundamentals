using System;
using System.Collections.Generic;
using System.Linq;

public class dnaSequences
{
    public static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());

        var count = 0;

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    count++;

                    if ((i + j + k) >= num)
                    {
                        Console.Write("O" + ("" + i + j + k).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "O ");
                    }
                    else
                    {
                        Console.Write("X" + ("" + i + j + k).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "X ");
                    }
                    if (count % 4 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}

