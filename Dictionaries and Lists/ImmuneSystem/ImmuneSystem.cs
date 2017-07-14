using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ImmuneSystem
{
    public static void Main(string[] args)
    {
        var health = int.Parse(Console.ReadLine());
        string viruses = null;
        var virus = new List<string>();
        var maxHealth = health;

        while ((viruses = Console.ReadLine()) != "end")
        {
            var virusStrength = CalculateVirusStrength(viruses);
            var defeatTime = virusStrength * viruses.Length;
            if (virus.Contains(viruses))
            {
                defeatTime = (int)(defeatTime / 3.0);
            }
            else
            {
                virus.Add(viruses);
            }
            health -= defeatTime;
            Console.WriteLine($"Virus {viruses}: {virusStrength} => {defeatTime} seconds");
            if (health <= 0)
            {
                Console.WriteLine("Immune System Defeated.");
                return;
            }
            else
            {
                var minutes = defeatTime / 60;
                var seconds = defeatTime % 60;
                Console.WriteLine($"{viruses} defeated in {minutes}m {seconds}s.");
                Console.WriteLine($"Remaining health: {health}");
            }
            health = Math.Min(maxHealth, (int)(health * 1.2));
        }
        Console.WriteLine($"Final Health: {health}");
    }

    private static int CalculateVirusStrength(string viruses)
    {
        var virusStrength = 0;
        for (int i = 0; i < viruses.Length; i++)
        {
            virusStrength += viruses[i];
        }
        return (int)(virusStrength / 3.0);
    }
}

