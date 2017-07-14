using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Circle
{
    public Point Center { get; set; }
    public int Radius { get; set; }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

class IntersectionOfCircles
{
    static void Main(string[] args)
    {
        Circle c1 = CreateCircle();
        Circle c2 = CreateCircle();

        var distance = CalculateDistanceBetweenCircleCenters(c1, c2);

        if (distance <= c1.Radius + c2.Radius)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    private static Circle CreateCircle()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Point point = new Point() { X = input[0], Y = input[1] };
        Circle circle = new Circle() { Center = point, Radius = input[2] };

        return circle;
    }

    private static int CalculateDistanceBetweenCircleCenters(Circle c1, Circle c2)
    {
        var x = Math.Abs(c1.Center.X - c2.Center.X);
        var y = Math.Abs(c1.Center.Y - c2.Center.Y);

        var distance = (int)(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
        return distance;
    }
}

