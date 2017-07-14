using System;
using System.Collections.Generic;
using System.Linq;

public class wordInPlural
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();

        if (input.EndsWith("y"))
        {
            input = input.Remove(input.Length - 1, 1);
            input = input + "ies";
        }
        else if (input.EndsWith("o") || input.EndsWith("ch") || input.EndsWith("s") || input.EndsWith("sh") || input.EndsWith("x") || input.EndsWith("z"))
        {
            input = input + "es";
        }
        else
        {
            input = input + "s";
        }
        Console.WriteLine(input);
    }
}

