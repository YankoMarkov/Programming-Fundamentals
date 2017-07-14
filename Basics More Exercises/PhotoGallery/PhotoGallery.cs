using System;
using System.Collections.Generic;
using System.Linq;

public class photoGallery
{
    public static void Main(string[] args)
    {
        var photoNumber = int.Parse(Console.ReadLine());
        var day = int.Parse(Console.ReadLine());
        var month = int.Parse(Console.ReadLine());
        var year = int.Parse(Console.ReadLine());
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());
        var photoByteSize = double.Parse(Console.ReadLine());
        var widthResolution = int.Parse(Console.ReadLine());
        var heightResolution = int.Parse(Console.ReadLine());
        
        var size = "B";
        var orientation = "";

        if (photoByteSize > 999 && photoByteSize < 1000000)
        {
            photoByteSize /= 1000;
            size = "KB";
        }
        if (photoByteSize > 999999)
        {
            photoByteSize /= 1000000;
            size = "MB";
        }
        if (widthResolution > heightResolution)
        {
            orientation = "landscape";
        }
        if (widthResolution < heightResolution)
        {
            orientation = "portrait";
        }
        if (widthResolution == heightResolution)
        {
            orientation = "square";
        }

        Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
        Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year:D4} {hours:D2}:{minutes:D2}");
        Console.WriteLine($"Size: {Math.Round(photoByteSize, 1)}{size}");
        Console.WriteLine($"Resolution: {widthResolution}x{heightResolution} ({orientation})");
    }
}

