using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

public class Factorial
{
    public static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());

        Console.WriteLine(GetFactorial(num));
    }

    public static BigInteger GetFactorial(int num)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}

