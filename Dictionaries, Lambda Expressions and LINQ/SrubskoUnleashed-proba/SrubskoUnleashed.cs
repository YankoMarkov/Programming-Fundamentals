using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SrubskoUnleashed
{
    public static void Main(string[] args)
    {
        var result = new Dictionary<string, Dictionary<string, int>>();
        string inputs = null;

        while ((inputs = Console.ReadLine()) != "End")
        {
            var input = inputs.Split('@').ToArray();
            var name = input[0];

            if (!name.EndsWith(" "))
            {
                continue;
            }
            var rightSide = input[1].Split().ToArray();

            if (rightSide.Length < 3)
            {
                continue;
            }
            var ticketPrice = 0;
            var ticketCount = 0;

            try
            {
                ticketCount = int.Parse(rightSide[rightSide.Length - 1]);
                ticketPrice = int.Parse(rightSide[rightSide.Length - 2]);
            }
            catch (Exception)
            {
                continue;
            }
            var venue = "";
            for (int i = 0; i < rightSide.Length - 2; i++)
            {
                venue += rightSide[i] + " ";
            }
            venue = venue.Trim();
            var total = ticketCount * ticketPrice;

            if (!result.ContainsKey(venue))
            {
                result.Add(venue, new Dictionary<string, int>());
            }
            if (!result[venue].ContainsKey(name))
            {
                result[venue].Add(name, total);
            }
            else
            {
                result[venue][name] += total;
            }

        }

        foreach (var venue in result.Keys)
        {
            Console.WriteLine(venue);
            foreach (var singer in result[venue].OrderByDescending(a => a.Value))
            {
                Console.WriteLine($"#  {singer.Key.Trim()} -> {singer.Value}");
            }
        }
    }
}

