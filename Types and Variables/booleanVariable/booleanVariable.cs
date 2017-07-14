using System;
using System.Collections.Generic;
using System.Linq;

public class booleanVariable
{
    public static void Main(string[] args)
    {
        var str = Console.ReadLine();
        var res = Convert.ToBoolean(str);

        if (res)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}

