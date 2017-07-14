using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ArrayStatistics
{
    public static void Main(string[] args)
    {
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine($"Min = {MinimumNumber(array)}");
        Console.WriteLine($"Max = {MaximumNumber(array)}");
        Console.WriteLine($"Sum = {SumOfNumbers(array)}");
        Console.WriteLine($"Average = {AverageValueOfNumbers(array)}");
    }

    private static int MinimumNumber(int[] arr)
    {
        var min = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] <= min)
            {
                min = arr[i];
            }
        }
        return min;
    }

    private static int MaximumNumber(int[] arr)
    {
        var max = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    private static int SumOfNumbers(int[] arr)
    {
        var sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    private static double AverageValueOfNumbers(int[] arr)
    {
        var sum = 0;
        var count = 0;
        var average = 0.0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            count++;
        }
        return average = (double)sum / count;
    }
}

