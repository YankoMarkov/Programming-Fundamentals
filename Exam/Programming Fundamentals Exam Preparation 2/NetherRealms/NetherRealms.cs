using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class NetherRealms
{
    static void Main(string[] args)
    {
        var inputs = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

        Regex regex = new Regex(@"(?<numbers>-?\d+(?:\.\d+)?)|(?<exclusive>[\-+\.])|(?<multiply>[*])|(?<divide>[\/])|(?<letters>[^\d\-+*\/\.])");
        List<String> results = new List<string>();

        foreach (var input in inputs)
        {
            Match matcher = regex.Match(input);
            StringBuilder letters = new StringBuilder();
            StringBuilder multiply = new StringBuilder();
            StringBuilder divide = new StringBuilder();
            double number = 0;

            while (matcher.Success)
            {
                if (matcher.Groups["letters"].Value != "")
                {
                    letters.Append(matcher.Groups["letters"].Value);
                }
                if (matcher.Groups["numbers"].Value != "")
                {
                    number += double.Parse(matcher.Groups["numbers"].Value);
                }
                if (matcher.Groups["multiply"].Value != "")
                {
                    multiply.Append(matcher.Groups["multiply"].Value);
                }
                if (matcher.Groups["divide"].Value != "")
                {
                    divide.Append(matcher.Groups["divide"].Value);
                }
                matcher = matcher.NextMatch();
            }
            decimal health = 0;
            foreach (var letter in letters.ToString())
            {
                health += letter;
            }
            foreach (var multiplys in multiply.ToString())
            {
                number *= 2;
            }
            foreach (var divides in divide.ToString())
            {
                number /= 2;
            }
            string result = string.Format($"{input} - {health} health, {number:f2} damage");
            results.Add(result);
        }
        foreach (var item in results.OrderBy(s => s))
        {
            Console.WriteLine(item);
        }
    }
}

