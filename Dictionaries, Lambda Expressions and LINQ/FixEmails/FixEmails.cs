using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FixEmails
{
    public static void Main(string[] args)
    {
        string input = null;
        var result = new Dictionary<string, string>();

        while ((input = Console.ReadLine()) != "stop")
        {
            var email = Console.ReadLine();

            if (!(email.EndsWith("us") || email.EndsWith("uk")))
            {
                result.Add(input, email);
            }
        }
        foreach (var item in result)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

