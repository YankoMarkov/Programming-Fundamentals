using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FoldAndSum
{
    public static void Main(string[] args)
    {
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var sumArray = new int[array.Length / 2];
        var firstArray = new int[array.Length / 2];
        var secondArray = new int[array.Length / 2];
        var secondIndex = array.Length / 4;
        var firstIndex = secondIndex - 1;

        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = array[secondIndex];
            secondIndex++;
        }

        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = array[firstIndex];
            if (firstIndex == 0)
            {
                firstIndex = array.Length;
            }
            firstIndex--;
        }

        for (int i = 0; i < sumArray.Length; i++)
        {
            sumArray[i] = firstArray[i] + secondArray[i];
        }

        foreach (var item in sumArray)
        {
            Console.Write(item + " ");
        }
    }
}

