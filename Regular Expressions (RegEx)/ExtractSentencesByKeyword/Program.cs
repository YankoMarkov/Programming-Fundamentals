using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var word = Console.ReadLine();
        var text = Console.ReadLine().Split(".,!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

        foreach (var item in text)
        {
            item.Trim();
            var sentence = item.Split().ToArray();
            if (sentence.Contains(word))
            {
                Console.WriteLine(item);
            }
        }
    }
}

