using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EmailMe
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split('@').ToArray();

        var firstPart = input[0];
        var secondPart = input[1];
        var firstSum = 0;
        var secondSum = 0;

        foreach (var item in firstPart)
        {
            firstSum += (int)item;
        }
        foreach (var item in secondPart)
        {
            secondSum += (int)item;
        }
        if (firstSum - secondSum >= 0)
        {
            Console.WriteLine("Call her!");
        }
        else
        {
            Console.WriteLine("She is not the one.");
        }
    }
}

