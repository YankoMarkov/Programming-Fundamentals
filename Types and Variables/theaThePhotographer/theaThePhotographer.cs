using System;
using System.Collections.Generic;
using System.Linq;

public class theaThePhotographer
{
    public static void Main(string[] args)
    {
        decimal numberOfPictures = decimal.Parse(Console.ReadLine());
        decimal filterTimePerPicture = decimal.Parse(Console.ReadLine());
        decimal percentageOfPictures = decimal.Parse(Console.ReadLine());
        decimal uploadedTimePerPicture = decimal.Parse(Console.ReadLine());

        decimal percent = percentageOfPictures / 100;
        decimal filteredPictures = numberOfPictures * percent;
        decimal timeForFilter = numberOfPictures * filterTimePerPicture;
        decimal uploadTime = Math.Ceiling(filteredPictures) * uploadedTimePerPicture;
        decimal totalTme = uploadTime + timeForFilter;

        var days = (int)(totalTme / (60 * 60 * 24));
        var hours = (int)((totalTme / (60 * 60)) % 24);
        var minutes = (int)((totalTme / 60) % 60);
        var seconds = (int)(totalTme % 60);

        Console.WriteLine($"{days:D1}:{hours:D2}:{minutes:D2}:{seconds:D2}");
    }
}

