using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class CameraView
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var length = numbers[0] + numbers[1];
        var inputText = Console.ReadLine();
         var texts = new List<string>();

        Regex regex = new Regex(@"(\|\<)(\w+)");
        Match match = regex.Match(inputText);

        while (match.Success)
        {
            Group txt = match.Groups[2];
            string text = txt.ToString();
            if (text.Length > length)
            {
                text = text.Substring(numbers[0], numbers[1]);
            }
            else
            {
                text = text.Substring(numbers[0]);
            }
            texts.Add(text);
            match = match.NextMatch();
        }
        Console.WriteLine(string.Join(", ", texts));
    }
}

