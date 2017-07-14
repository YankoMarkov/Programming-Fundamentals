using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class KeyReplacer
{
    static void Main(string[] args)
    {
        var keys = Console.ReadLine().Split(@"|<\".ToCharArray()).ToArray();
        var text = Console.ReadLine();

        var startKey = keys[0];
        var endKey = keys[keys.Length - 1];
        StringBuilder newText = new StringBuilder(text);
        newText = newText.Replace(startKey, "%");
        newText = newText.Replace(endKey, "#");
        startKey = "%";
        endKey = "#";
        

        Regex regex = new Regex("(%)([^%#]+?)(#)");
        Match matcher = regex.Match(newText.ToString());
        string result = "";

        while (matcher.Success)
        {
            result += matcher.Groups[2].Value;

            matcher = matcher.NextMatch();
        }
        if (result == "")
        {
            Console.WriteLine("Empty result");
        }
        else
        {
            Console.WriteLine(result);
        }

    }
}

