using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GeometryCalculator
{
    public static void Main(string[] args)
    {
        var command = Console.ReadLine();
        var side = 0.0;
        var height = 0.0;

        switch (command)
        {
            case "triangle":
                side = double.Parse(Console.ReadLine());
                height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{GetTriangleArea(side, height):F2}");
                break;
            case "square":
                side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{GetSquareArea(side):F2}");
                break;
            case "rectangle":
                var width = double.Parse(Console.ReadLine());
                height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{GetRectangleArea(width, height):F2}");
                break;
            case "circle":
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{GetCircleArea(radius):F2}");
                break;
            default:
                break;
        }
    }

    public static double GetTriangleArea(double side, double height)
    {
        return (side * height) / 2;
    }

    public static double GetSquareArea(double side)
    {
        return side * side;
    }

    public static double GetRectangleArea(double width, double height)
    {
        return width * height;
    }

    public static double GetCircleArea(double radius)
    {
        return Math.PI * (radius * radius);
    }
}

