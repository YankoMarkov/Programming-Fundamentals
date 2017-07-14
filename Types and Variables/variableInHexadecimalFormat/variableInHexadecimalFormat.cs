using System;
using System.Collections.Generic;
using System.Linq;

public class variableInHexadecimalFormat
{
    public static void Main(string[] args)
    {
        var str = Console.ReadLine();
        var res = Convert.ToInt32(str, 16);

        Console.WriteLine(res);
    }
}

