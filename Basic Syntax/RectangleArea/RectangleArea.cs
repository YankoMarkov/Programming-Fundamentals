using System;
using System.Collections.Generic;
using System.Linq;

public class RectangleArea
{
    public static void Main()
    {
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        var area = width * height;
        Console.WriteLine($"{area:F2}");
    }
}

