using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class WinningTicket
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(t => t.Trim()).ToArray();

        foreach (var ticket in input)
        {
            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }
            string leftSide = ticket.Substring(0, 10);
            string rightSide = ticket.Substring(10);

            var winingSimbol = new string[] { "@", "#", "\\$", "\\^" };
            var winTicket = false;
            foreach (var simbol in winingSimbol)
            {
                Regex regex = new Regex($"{simbol}{{6,}}");
                Match leftMatch = regex.Match(leftSide);
                if (leftMatch.Success)
                {
                    Match rightMatch = regex.Match(rightSide);
                    if (rightMatch.Success)
                    {
                        winTicket = true;
                        var leftSimbolLength = leftMatch.Value.Length;
                        var rightSimbolLength = rightMatch.Value.Length;
                        var jackpot = leftSimbolLength == 10 && rightSimbolLength == 10 ? " Jackpot!" : string.Empty;
                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftSimbolLength, rightSimbolLength)}{simbol.Trim('\\')}{jackpot}");
                        break;
                    }
                }
            }
            if (!winTicket)
            {
                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }
    }
}

