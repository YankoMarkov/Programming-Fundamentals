using System;
using System.Collections.Generic;
using System.Linq;

public class BeverageLabels
{
    public static void Main()
    {
        var name = Console.ReadLine();
        var volume = int.Parse(Console.ReadLine());
        var energy = int.Parse(Console.ReadLine());
        var sugar = int.Parse(Console.ReadLine());

        var energyPerMl = energy / 100.0;
        var sugarPerMl = sugar / 100.0;

        var totalEnergy = energyPerMl * volume;
        var totalSugar = sugarPerMl * volume;

        Console.WriteLine($"{volume}ml {name}:");
        Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
    }
}

