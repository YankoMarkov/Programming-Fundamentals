using System;
using System.Collections.Generic;
using System.Linq;

public class CharacterStats
{
    public static void Main()
    {
        var name = Console.ReadLine();
        var currentHealth = int.Parse(Console.ReadLine());
        var maximumHealth = int.Parse(Console.ReadLine());
        var currentEnergy = int.Parse(Console.ReadLine());
        var maximumEnergy = int.Parse(Console.ReadLine());

        var health = maximumHealth - currentHealth;
        var energy = maximumEnergy - currentEnergy;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', health));
        Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', energy));
    }
}

