using System;
using System.Collections.Generic;
using System.Linq;
public class megapixels
{
    public static void Main(string[] args)
    {
        var widthResolution = int.Parse(Console.ReadLine());
        var heightResolution = int.Parse(Console.ReadLine());

        var multiply = (double)(widthResolution * heightResolution);
        var result = multiply / 1000000;

        Console.WriteLine($"{widthResolution}x{heightResolution} => {Math.Round(result, 1)}MP");
    }
}

