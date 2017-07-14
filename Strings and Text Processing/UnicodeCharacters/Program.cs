using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        var result = "";
        foreach (var item in input)
        {
            result += @"\u";
            result += (string.Format("{0:x4}", (int)item));
        }
        Console.WriteLine(result);
    }
}

