using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FibonacciNumbers
{
    public static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());

        Console.WriteLine(FibonacciRecursion(num));
    }

    public static long FibonacciRecursion(int num)
    {
        if (num == 0 || num == 1)
        {
            return 1;
        }
        return FibonacciRecursion(num - 1) + FibonacciRecursion(num - 2);
    }
}
