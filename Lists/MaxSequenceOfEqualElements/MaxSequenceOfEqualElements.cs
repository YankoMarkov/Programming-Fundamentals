using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MaxSequenceOfEqualElements
{
    public static void Main(string[] args)
    {
        var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var count = 0;
        var index = 0;
        var bestCount = 0;
        var bestIndex = 0;

        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] == list[i - 1])
            {
                count++;
            }
            else
            {
                count = 0;
                index = i;
            }
            if (count > bestCount)
            {
                bestCount = count;
                bestIndex = index;
            }
        }
        for (int i = bestIndex; i <= bestIndex + bestCount; i++)
        {
            Console.Write($"{list[i]} ");
        }
    }
}

