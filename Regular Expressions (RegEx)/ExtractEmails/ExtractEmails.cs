using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractEmails
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        
        Regex regex = new Regex(@"(?:(?<=\s)|^)([a-zA-Z0-9]+[\-\\._]?[a-zA-Z0-9]+)@([a-zA-Z]+[\-]?[a-zA_Z]+)(\.[a-z]{2,})+");
        MatchCollection matches = regex.Matches(input);

        foreach (var item in matches)
        {
            Console.WriteLine(item);
        }
    }
}