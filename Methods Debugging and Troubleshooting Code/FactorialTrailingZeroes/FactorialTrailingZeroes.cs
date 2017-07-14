using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public class FactorialTrailingZeroes
{
    public static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());

        Console.WriteLine(CountZeroInFactorial(GetFactorial(num)));
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

    public static int CountZeroInFactorial(BigInteger num)
    {
        string result = num.ToString();
        char[] reverse = result.ToCharArray();
        Array.Reverse(reverse);
        result = new string(reverse);
        var count = 0;
        var index = 0;

        while (result[index] == '0')
        {
            count++;
            index++;
        }
        return count;
    }
}

