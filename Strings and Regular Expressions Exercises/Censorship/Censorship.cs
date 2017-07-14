using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var word = Console.ReadLine();
        var text = Console.ReadLine();

        StringBuilder result = new StringBuilder(text);
        result = result.Replace(word, new string('*', word.Length));

        Console.WriteLine(result);
    }
}

