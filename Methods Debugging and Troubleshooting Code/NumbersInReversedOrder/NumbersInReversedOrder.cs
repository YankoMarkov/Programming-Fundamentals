using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NumbersInReversedOrder
{
    public static void Main(string[] args)
    {
        var num = Console.ReadLine();

        Console.WriteLine(PrintReverseNumber(num));
    }

    public static string PrintReverseNumber(string num)
    {
        var result = new string(num.ToString().Reverse().ToArray());
        return result;
    }
}

