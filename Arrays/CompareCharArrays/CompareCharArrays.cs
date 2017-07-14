using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CompareCharArrays
{
    public static void Main(string[] args)
    {
        var firstArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        var secondArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

        if (firstArr.Length < secondArr.Length)
        {
            Console.WriteLine(string.Join("", firstArr));
            Console.WriteLine(string.Join("", secondArr));
        }
        else if (secondArr.Length < firstArr.Length)
        {
            Console.WriteLine(string.Join("", secondArr));
            Console.WriteLine(string.Join("", firstArr));
        }
        else if (firstArr.Length == secondArr.Length)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] <= secondArr[i])
                {
                    Console.WriteLine(string.Join("", firstArr));
                    Console.WriteLine(string.Join("", secondArr));
                    break;
                }
                else
                {
                    Console.WriteLine(string.Join("", secondArr));
                    Console.WriteLine(string.Join("", firstArr));
                    break;
                }
            }
        }
    }
}

