using System;
using System.Collections.Generic;
using System.Linq;

public class neighbourWars
{
    public static void Main(string[] args)
    {
        var peshoDamage = int.Parse(Console.ReadLine());
        var goshoDamage = int.Parse(Console.ReadLine());

        var peshoHealth = 100;
        var goshoHealth = 100;
        var count = 0;
        var pesho = "Pesho";
        var gosho = "Gosho";

        for (int i = 1; ; i++)
        {
            count++;
            if (i % 2 == 0)
            {
                peshoHealth -= goshoDamage;
                if (peshoHealth > 0)
                {
                    Console.WriteLine($"{gosho} used Thunderous fist and reduced {pesho} to {peshoHealth} health.");
                }
            }
            else
            {
                goshoHealth -= peshoDamage;
                if (goshoHealth > 0)
                {
                    Console.WriteLine($"{pesho} used Roundhouse kick and reduced {gosho} to {goshoHealth} health.");
                }
            }

            if (count % 3 == 0)
            {
                if (peshoHealth > 0 && goshoHealth > 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
            }

            if (peshoHealth <= 0 || goshoHealth <= 0)
            {
                if (goshoHealth > peshoHealth)
                {
                    Console.WriteLine($"{gosho} won in {count}th round.");
                    break;
                }
                else
                {
                    Console.WriteLine($"{pesho} won in {count}th round.");
                    break;
                }

            }

        }
    }
}

