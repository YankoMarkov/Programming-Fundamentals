using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CenterPoint
{
    public static void Main(string[] args)
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());

        CloserPointDistance(x1, y1, x2, y2);
    }

    public static void CloserPointDistance(double x1, double y1, double x2, double y2)
    {
        var x = 0.0;
        var y = 0.0;

        if (Math.Pow(x1, 2) + Math.Pow(y1, 2) <= Math.Pow(x2, 2) + Math.Pow(y2, 2))
        {
            x = x1;
            y = y1;
        }
        else
        {
            x = x2;
            y = y2;
        }

        Console.WriteLine($"({x}, {y})");
    }
}

