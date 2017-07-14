using System;
using System.Collections.Generic;
using System.Linq;

public class balancedBrackets
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var bracket = "";
        var balanced = "BALANCED";

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            if (input == "(")
            {
                if (bracket == "(")
                {
                    balanced = "UNBALANCED";
                    break;
                }
                bracket = input;
            }
            if (input == ")")
            {
                if (bracket != "(")
                {
                    balanced = "UNBALANCED";
                    break;
                }
                bracket = input;
            }
        }
        if (bracket == "(")
        {
            balanced = "UNBALANCED";
        }
        Console.WriteLine(balanced);
    }
}


