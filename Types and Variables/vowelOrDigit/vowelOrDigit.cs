using System;
using System.Collections.Generic;
using System.Linq;

public class vowelOrDigit
{
    public static void Main(string[] args)
    {
        var input = char.Parse(Console.ReadLine());

        if (char.IsDigit(input))
        {
            Console.WriteLine("digit");
        }
        else
        {
            switch (input)
            {
                case 'a':
                    Console.WriteLine("vowel");
                    break;
                case 'e':
                    Console.WriteLine("vowel");
                    break;
                case 'i':
                    Console.WriteLine("vowel");
                    break;
                case 'o':
                    Console.WriteLine("vowel");
                    break;
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("other");
                    break;

            }
        }

    }
}

