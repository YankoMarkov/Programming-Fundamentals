using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PhonebookUpgrade
{
    public static void Main(string[] args)
    {
        string inputs = null;
        var phonebook = new SortedDictionary<string, string>();

        while ((inputs = Console.ReadLine()) != "END")
        {
            var input = inputs.Split().ToArray();
            string name = "";

            if (input[0] == "A")
            {
                name = input[1];
                var phone = input[2];

                if (phonebook.ContainsKey(name))
                {
                    phonebook[name] = phone;
                }
                else
                {
                    phonebook[name] = phone;
                }
            }
            if (input[0] == "S")
            {
                name = input[1];

                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} -> {phonebook[name]}");
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
            }
            if (input[0] == "ListAll")
            {
                foreach (var item in phonebook)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}

