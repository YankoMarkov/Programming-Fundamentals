using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HandsOfCards
{
    public static void Main(string[] args)
    {
        string inputs = null;
        var result = new Dictionary<string, HashSet<string>>();
        var powers = new List<char> { '2', '3', '4', '5', '6', '7', '8', '9', '1', 'J', 'Q', 'K', 'A' };
        var tipes = new List<char> { 'C', 'D', 'H', 'S' };

        while ((inputs = Console.ReadLine()) != "JOKER")
        {
            var input = inputs.Split(':').ToArray();
            var name = input[0];
            var cards = input[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (!result.ContainsKey(name))
            {
                result.Add(name, new HashSet<string>());
            }
            foreach (var item in cards)
            {
                result[name].Add(item);
            }
        }
        foreach (var name in result.Keys)
        {
            Console.Write($"{name}: ");
            var sum = 0;
            foreach (var card in result[name])
            {
                var power = powers.IndexOf(card[0]) + 2;
                var tipe = tipes.IndexOf(card[card.Length - 1]) + 1;
                sum += power * tipe;
            }
            Console.WriteLine(sum);
        }
    }
}

