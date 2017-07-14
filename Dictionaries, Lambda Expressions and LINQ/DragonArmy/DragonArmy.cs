using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DragonArmy
{
    public static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());
        var dragonType = new Dictionary<string, double[]>();
        var dragons = new Dictionary<string, SortedDictionary<string, int[]>>();

        for (int i = 0; i < num; i++)
        {
            var input = Console.ReadLine().Split().ToArray();

            var type = input[0];
            var name = input[1];
            var damage = input[2].Equals("null") ? 45 : int.Parse(input[2]);
            var health = input[3].Equals("null") ? 250 : int.Parse(input[3]); ;
            var armor = input[4].Equals("null") ? 10 : int.Parse(input[4]); ;

            if (!dragons.ContainsKey(type))
            {
                dragons.Add(type, new SortedDictionary<string, int[]>());
                dragonType.Add(type, new double[3]);
            }
            if (dragons[type].ContainsKey(name))
            {
                var stat = dragons[type][name].ToArray();
                dragonType[type][0] -= stat[0];
                dragonType[type][1] -= stat[1];
                dragonType[type][2] -= stat[2];
            }
            if (!dragons[type].ContainsKey(name))
            {
                dragons[type].Add(name, new int[3]);
            }
            dragons[type][name][0] = damage;
            dragons[type][name][1] = health;
            dragons[type][name][2] = armor;

            dragonType[type][0] += damage;
            dragonType[type][1] += health;
            dragonType[type][2] += armor;
        }

        foreach (var type in dragons)
        {
            Console.WriteLine($"{type.Key}::({(dragonType[type.Key][0] / type.Value.Count):F2}/" +
                $"{(dragonType[type.Key][1] / type.Value.Count):F2}/" +
                $"{(dragonType[type.Key][2] / type.Value.Count):F2})");
            foreach (var dragon in type.Value)
            {
                Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
            }
        }
    }
}

