using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WriteToFile
{
    static void Main(string[] args)
    {
        var text = File.ReadAllText("sample_text.txt");
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            if (!(text[i] == '.' || text[i] == ',' || text[i] == '!' || text[i] == '?' || text[i] == ':'))
            {
                result = result.Append(text[i]);
            }
        }
        File.WriteAllText("output_text.txt", result.ToString());
    }
}

