using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EnglishNameOfLastDigit
{
    public static void Main(string[] args)
    {
        var num = long.Parse(Console.ReadLine());

        ReturnNameOfLastDigit(num);
    }

    public static void ReturnNameOfLastDigit(long num)
    {
        var digit = Math.Abs(num) % 10;

        switch (digit)
        {
            case 0:
                Console.WriteLine("zero");
                break;
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            case 6:
                Console.WriteLine("six");
                break;
            case 7:
                Console.WriteLine("seven");
                break;
            case 8:
                Console.WriteLine("eight");
                break;
            case 9:
                Console.WriteLine("nine");
                break;
            default:
                break;
        }
    }
}

