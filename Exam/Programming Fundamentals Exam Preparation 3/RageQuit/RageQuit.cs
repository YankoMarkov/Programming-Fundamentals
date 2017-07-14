using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class RageQuit
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().ToUpper();

        Regex regex = new Regex(@"(?<symbol>\D+)(?<number>\d+)");
        MatchCollection matcher = regex.Matches(input);
        StringBuilder result = new StringBuilder();

        foreach (Match match in matcher)
        {
            string symbol = match.Groups["symbol"].Value;
            int number = int.Parse(match.Groups["number"].Value);
            for (int i = 0; i < number; i++)
            {
                result.Append(symbol);
            }
        }
        Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
        Console.WriteLine(result.ToString());
    }
}

