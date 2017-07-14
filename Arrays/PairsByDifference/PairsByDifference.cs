using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PairsByDifference
{
    public static void Main(string[] args)
    {
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var num = int.Parse(Console.ReadLine());

        var count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (array[i] + num == array[j] || array[i] - num == array[j])
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}

