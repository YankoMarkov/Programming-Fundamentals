using System;
using System.Collections.Generic;
using System.Linq;

public class decryptingMessage
{
    public static void Main(string[] args)
    {
        var key = int.Parse(Console.ReadLine());
        var n = int.Parse(Console.ReadLine());
        var result = "";

        for (int i = 0; i < n; i++)
        {
            var letter = char.Parse(Console.ReadLine());
            letter += (char)key;
            result += letter;
        }
        Console.WriteLine(result);
    }
}

