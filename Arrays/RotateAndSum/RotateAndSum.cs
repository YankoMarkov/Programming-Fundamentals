using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RotateAndSum
{
    public static void Main(string[] args)
    {
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var rotateTimes = int.Parse(Console.ReadLine());

        var tempArray = new int[array.Length];
        var sumArray = new int[array.Length];

        for (int i = 0; i < rotateTimes; i++)
        {
            for (int j = 1; j <= array.Length; j++)
            {
                tempArray[j % tempArray.Length] = array[j - 1];
            }
            for (int k = 0; k < sumArray.Length; k++)
            {
                sumArray[k] += tempArray[k];
                array[k] = tempArray[k];
            }
        }
        foreach (var item in sumArray)
        {
            Console.Write(item + " ");
        }
    }
}

