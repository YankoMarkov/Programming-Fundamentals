using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxMethod
{
    static void Main(string[] args)
    {
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());
        var num3 = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Max(GetMaxNum(num1, num2), num3));
    }

    public static int GetMaxNum(int num1, int num2)
    {
       return Math.Max(num1, num2);
    }
}

