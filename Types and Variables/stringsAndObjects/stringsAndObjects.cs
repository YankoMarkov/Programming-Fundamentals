using System;
using System.Collections.Generic;
using System.Linq;

public class stringsAndObjects
{
    public static void Main(string[] args)
    {
        var str1 = "Hello";
        var str2 = "World";
        object str = str1 + " " + str2;
        var res = (string) str;

        Console.WriteLine(res);
    }
}

