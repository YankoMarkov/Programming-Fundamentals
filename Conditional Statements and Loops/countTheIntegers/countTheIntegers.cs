using System;
using System.Collections.Generic;
using System.Linq;

public class countTheIntegers
{
    public static void Main(string[] args)
    {
        var count = 0;
        
        try
        {
            var input = int.Parse(Console.ReadLine());
            while (true)
            {
                int temp = input;
                count++;
                input = int.Parse(Console.ReadLine());
            }
        }
        catch
        {
            Console.WriteLine(count);
        }
    }
}

