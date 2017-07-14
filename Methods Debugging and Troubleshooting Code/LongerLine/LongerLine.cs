using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LongerLine
{
    public static void Main(string[] args)
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());
        var x3 = double.Parse(Console.ReadLine());
        var y3 = double.Parse(Console.ReadLine());
        var x4 = double.Parse(Console.ReadLine());
        var y4 = double.Parse(Console.ReadLine());

        PrintLongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
    }

    public static double LineLength(double x1, double y1, double x2, double y2)
    {
        var x = Math.Abs(x2 - x1);
        var y = Math.Abs(y2 - y1);
        return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
    }

    public static void CloserPointDistance(double x1, double y1, double x2, double y2)
    {
        if (Math.Pow(x1, 2) + Math.Pow(y1, 2) <= Math.Pow(x2, 2) + Math.Pow(y2, 2))
        {
            Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
        }
    }

    public static void PrintLongestLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        if (LineLength(x1, y1, x2, y2) >= LineLength(x3, y3, x4, y4))
        {
            CloserPointDistance(x1, y1, x2, y2);
        }
        else
        {
            CloserPointDistance(x3, y3, x4, y4);
        }
    }
}

