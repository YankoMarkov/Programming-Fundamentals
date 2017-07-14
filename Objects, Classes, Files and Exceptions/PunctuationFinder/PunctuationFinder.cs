using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PunctuationFinder
{
    static void Main(string[] args)
    {
        var text = File.ReadAllText("sample_text.txt");
        List<char> result = new List<char>();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '.' || text[i] == ',' || text[i] == '!' || text[i] == '?' || text[i] == ':')
            {
                result.Add(text[i]);
            }
        }
        Console.WriteLine(string.Join(", ", result));
    }
}

