using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class IndexOfLetters
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            char letter = input[i];
            int num = input[i] - 97;

            Console.WriteLine($"{letter} -> {num}");
        }
    }
}

