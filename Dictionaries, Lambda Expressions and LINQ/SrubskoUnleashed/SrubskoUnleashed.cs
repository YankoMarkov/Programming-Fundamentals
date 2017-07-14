using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class SrubskoUnleashed
{
    public static void Main(string[] args)
    {
        var result = new Dictionary<string, Dictionary<string, long>>();
        string inputs = null;
        var pattern = @"((?:[a-zA-Z]+\s|[a-zA-Z]+\s+){1,2})@((?:[a-zA-Z]+\s|[a-zA-Z]+\s+){1,2})(\d+)\s(\d+)";

        while ((inputs = Console.ReadLine()) != "End")
        {
            Match match = Regex.Match(inputs, pattern);

            var venue = "";
            var singer = "";
            var ticketsPrice = 0L;
            var ticketsCount = 0L;
            var total = 0L;

            if (match.Success)
            {
                singer = match.Groups[1].ToString().Trim();
                venue = match.Groups[2].ToString().Trim();
                ticketsPrice = long.Parse(match.Groups[3].ToString().Trim());
                ticketsCount = long.Parse(match.Groups[4].ToString().Trim());
                total += ticketsPrice * ticketsCount;
            }
            else
            {
                continue;
            }

            if (!result.ContainsKey(venue))
            {
                result.Add(venue, new Dictionary<string, long>());
            }
            if (!result[venue].ContainsKey(singer))
            {
                result[venue].Add(singer, total);
            }
            else
            {
                result[venue][singer] += total;
            }
        }
        foreach (var venue in result.Keys)
        {
            Console.WriteLine(venue);
            foreach (var singer in result[venue].OrderByDescending(a => a.Value))
            {
                Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
            }
        }
    }

}


