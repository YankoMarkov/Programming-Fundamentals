using System;
using System.Collections.Generic;
using System.Linq;

public class x
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var a = 0;
        var b = n - 2;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write("{0}x{1}x{2}", new string(' ', a), new string(' ', b), new string(' ', a));
            a++;
            b -= 2;
            Console.WriteLine();
        }
        Console.WriteLine("{0}x{1}", new string(' ', (n - 1) / 2), new string(' ', (n - 1) / 2));
        a = (n - 3) / 2;
        b = 1;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write("{0}x{1}x{2}", new string(' ', a), new string(' ', b), new string(' ', a));
            a--;
            b += 2;
            Console.WriteLine();
        }
    }
}

