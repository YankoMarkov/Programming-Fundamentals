using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RoliTheCoder
{
    static void Main(string[] args)
    {
        string inputs = null;
        var idToName = new Dictionary<int, string>();
        var result = new Dictionary<string, HashSet<string>>();

        while ((inputs = Console.ReadLine()) != "Time for Code")
        {
            var input = inputs.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (input.Length < 2 || !input[1].StartsWith("#"))
            {
                continue;
            }
            var id = int.Parse(input[0]);
            var eventName = input[1].Substring(1);
            HashSet<string> participants;

            if (idToName.ContainsKey(id))
            {
                if (idToName[id] != eventName)
                {
                    continue;
                }
                else
                {
                    participants = result[eventName];
                }
            }
            else
            {
                idToName.Add(id, eventName);
                participants = new HashSet<string>();
                result.Add(eventName, participants);
            }

            foreach (var participant in input.Skip(2))
            {
                if (participant.StartsWith("@"))
                {
                    participants.Add(participant);
                }
            }
        }
        foreach (var item in result.OrderByDescending(s => s.Value.Count).ThenBy(s => s.Key))
        {
            Console.WriteLine($"{item.Key} - {item.Value.Count}");
            foreach (var participant in item.Value.OrderBy(s => s))
            {
                Console.WriteLine(participant);
            }
        }
    }
}

