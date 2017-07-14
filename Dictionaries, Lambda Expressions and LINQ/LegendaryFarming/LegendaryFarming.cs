using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LegendaryFarming
{
    public static void Main(string[] args)
    {
        var special = new Dictionary<string, int>();
        var junk = new Dictionary<string, int>();

        special.Add("shards", 0);
        special.Add("fragments", 0);
        special.Add("motes", 0);

        string legendary = null;
        while (legendary == null)
        {
            var input = Console.ReadLine().Split().ToArray();
            var lengths = input.Length;
            for (int i = 0; i < lengths; i += 2)
            {
                var quantity = int.Parse(input[i]);
                var material = input[i + 1].ToLower();
                
                if (special.ContainsKey(material))
                {
                    special[material] += quantity;
                    if (special[material] >= 250)
                    {
                        special[material] -= 250;

                        switch (material)
                        {
                            case "shards":
                                legendary = "Shadowmourne";
                                break;
                            case "fragments":
                                legendary = "Valanyr";
                                break;
                            case "motes":
                                legendary = "Dragonwrath";
                                break;
                            default:
                                break;
                        }
                    }
                }
                else
                {
                    if (junk.ContainsKey(material))
                    {
                        junk[material] += quantity;
                    }
                    else
                    {
                        junk.Add(material, quantity);
                    }
                }
                if (legendary != null)
                {
                    break;
                }
            }
        }
        Console.WriteLine($"{legendary} obtained!");
        foreach (var item in special.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        foreach (var item in junk.OrderBy(a => a.Key))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}

