using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PopulationCounter
{
    public static void Main(string[] args)
    {
        string inputs = null;
        var result = new Dictionary<string, Dictionary<string, long>>();
        var countryPopulation = new Dictionary<string, long>();

        while ((inputs = Console.ReadLine()) != "report")
        {
            var input = inputs.Split('|').ToArray();
            var city = input[0];
            var country = input[1];
            var population = long.Parse(input[2]);

            if (!result.ContainsKey(country))
            {
                result.Add(country, new Dictionary<string, long>());
                countryPopulation.Add(country, 0);
            }
            countryPopulation[country] += population;
            if (!result[country].ContainsKey(city))
            {
                result[country].Add(city, population);
            }
        }
        foreach (var country in result.Keys.OrderByDescending(p => countryPopulation[p]))
        {
            Console.WriteLine($"{country} (total population: {countryPopulation[country]})");
            foreach (var city in result[country].OrderByDescending(p => p.Value))
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }
        }
    }
}

