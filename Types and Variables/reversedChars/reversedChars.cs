using System;
using System.Collections.Generic;
using System.Linq;

public class reversedChars
{
    public static void Main(string[] args)
    {
        var chr1 = char.Parse(Console.ReadLine());
        var chr2 = char.Parse(Console.ReadLine());
        var chr3 = char.Parse(Console.ReadLine());

        var str1 = Convert.ToString(chr1);
        var str2 = Convert.ToString(chr2);
        var str3 = Convert.ToString(chr3);
        
        Console.WriteLine(str3 + str2 + str1);
    }
}

