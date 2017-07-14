using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PrimeChecker
{
    public static void Main(string[] args)
    {
        var num = long.Parse(Console.ReadLine());

        if (IsPrime(num))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
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

