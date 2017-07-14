using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MostFrequentNumber
{
    public static void Main(string[] args)
    {
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var bestCount = 0;
        var result = 0;

        for (int i = 0; i < array.Length; i++)
        {
            var count = 0;
            for (int j = i; j < array.Length; j++)
            {
                if (array[j] == array[i])
                {
                    count++;
                }
            }
            if (count > bestCount)
            {
                bestCount = count;
                result = array[i];
            }
        }
        Console.WriteLine(result);
    }
}

