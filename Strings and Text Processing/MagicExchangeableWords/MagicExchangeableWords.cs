using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicExchangeableWords
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().ToArray();
        Console.WriteLine(MagicExchangeableWord(input[0], input[1]).ToString().ToLower());
    }

    private static bool MagicExchangeableWord(string shortStr, string longStr)
    {
        var letters = new Dictionary<char, char>();
        string shortest = "";
        string longest = "";

        if (shortStr.Length <= longStr.Length)
        {
            shortest = shortStr;
            longest = longStr;
        }
        else
        {
            shortest = longStr;
            longest = shortStr;
        }
        for (int i = 0; i < shortest.Length; i++)
        {
            if (!letters.ContainsKey(longest[i]))
            {
                letters.Add(longest[i], shortest[i]);
            }
            if (letters[longest[i]] != shortest[i])
            {
                return false;
            }
        }
        for (int i = shortest.Length; i < longest.Length; i++)
        {
            if (!letters.ContainsKey(longest[i]))
            {
                return false;
            }
        }
        return true;
    }
}