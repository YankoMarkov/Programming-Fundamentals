using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class FootballStandings
{
    static void Main(string[] args)
    {
        var key = Regex.Escape(Console.ReadLine());
        var pattern = string.Format(@"^.*(?:{0})(?<team1>[a-zA-Z]*)(?:{0}).*(?:{0})(?<team2>[a-zA-Z]*)(?:{0}).*(?<goals1>\d+):(?<goals2>\d+).*$", key);
        Regex regex = new Regex(pattern);
        var result = new Dictionary<string, Score>();

        string inputs = null;
        while ((inputs = Console.ReadLine()) != "final")
        {
            var matcher = regex.Match(inputs);
            var team1 = new string(matcher.Groups["team1"].Value.ToUpper().Reverse().ToArray());
            var team2 = new string(matcher.Groups["team2"].Value.ToUpper().Reverse().ToArray());
            var goals1 = int.Parse(matcher.Groups["goals1"].Value);
            var goals2 = int.Parse(matcher.Groups["goals2"].Value);

            if (!result.ContainsKey(team1))
            {
                result.Add(team1, new Score());
            }
            if (!result.ContainsKey(team2))
            {
                result.Add(team2, new Score());
            }
            result[team1].Goals += goals1;
            result[team2].Goals += goals2;

            if (goals1 > goals2)
            {
                result[team1].Points += 3;
            }
            else if (goals2 > goals1)
            {
                result[team2].Points += 3;
            }
            else
            {
                result[team1].Points += 1;
                result[team2].Points += 1;
            }
        }
        var n = 1;
        Console.WriteLine("League standings:");
        foreach (var item in result.OrderByDescending(a => a.Value.Points).ThenBy(a => a.Key))
        {
            Console.WriteLine($"{n}. {item.Key} {item.Value.Points}");
            n++;
        }
        Console.WriteLine("Top 3 scored goals:");
        foreach (var item in result.OrderByDescending(a => a.Value.Goals).ThenBy(a => a.Key).Take(3))
        {
            Console.WriteLine($"- {item.Key} -> {item.Value.Goals}");
        }
    }
}

class Score
{
    public int Points { get; set; }
    public int Goals { get; set; }
}
