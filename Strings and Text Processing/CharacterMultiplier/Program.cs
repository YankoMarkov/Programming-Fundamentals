using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().ToArray();
        var shortString = "";
        var longString = "";
        var thirdStr = "";

        if (input[0].Length > input[1].Length)
        {
            longString = input[0];
            shortString = input[1];
            thirdStr = longString.Substring(shortString.Length);
        }
        else if(input[0].Length < input[1].Length)
        {
            longString = input[1];
            shortString = input[0];
            thirdStr = longString.Substring(shortString.Length);
        }
        else
        {
            longString = input[0];
            shortString = input[1];
        }
        int sum = 0;
        for (int i = 0; i < shortString.Length; i++)
        {
            sum += ((int)shortString[i] * (int)longString[i]);
        }
        if (thirdStr != "")
        {
            foreach (var item in thirdStr)
            {
                sum += (int)item;
            }
        }
        Console.WriteLine(sum);
    }
}

