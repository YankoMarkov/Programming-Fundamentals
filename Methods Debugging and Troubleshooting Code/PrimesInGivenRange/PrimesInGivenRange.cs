using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PrimesInGivenRange
{
    public static void Main(string[] args)
    {
        var startNum = int.Parse(Console.ReadLine());
        var endNum = int.Parse(Console.ReadLine());

        Console.WriteLine(string.Join(", ", FindPrimesInRange(startNum, endNum)));
    }

    public static List<int> FindPrimesInRange(int from, int to)
    {
        var result = new List<int>();
        for (int num = from; num <= to; num++)
        {
            if (IsPrime(num))
            {
                result.Add(num);
            }
        }
        return result;
    }

    public static bool IsPrime(long num)
    {
        if (num == 0 || num == 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}

