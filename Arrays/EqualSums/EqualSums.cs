using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EqualSums
{
    public static void Main(string[] args)
    {
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < array.Length; i++)
        {
            if (LeftIndexSum(array, i) == rightIndexSum(array, i))
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine("no");
    }

    private static int LeftIndexSum(int[] arr, int index)
    {
        var sum = 0;
        for (int i = index; i >= 0; i--)
        {
            if (i == 0)
            {
                sum += 0;
                break;
            }
            else
            {
                sum += arr[i - 1];
            }
        }
        return sum;
    }

    private static int rightIndexSum(int[] arr, int index)
    {
        var sum = 0;
        for (int i = index; i <= arr.Length; i++)
        {
            var nextIndex = (i + 1) % arr.Length;
            if (arr.Length == 1 || nextIndex == 0)
            {
                sum += 0;
                break;
            }
            else
            {
                sum += arr[nextIndex];
            }
        }
        return sum;
    }
}

