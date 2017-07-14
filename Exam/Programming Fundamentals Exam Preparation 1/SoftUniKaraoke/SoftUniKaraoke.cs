using System;
using System.Collections.Generic;
using System.Linq;

public class SoftUniKaraoke
{
    public static void Main()
    {
        var participants = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToArray();
        var songs = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToArray();
        var result = new Dictionary<String, List<String>>();

        string input = null;
        while (!(input = Console.ReadLine()).Equals("dawn"))
        {
            var inputs = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToArray();
            var participant = inputs[0];
            var song = inputs[1];
            var award = inputs[2];

            if (participants.Contains(participant) && songs.Contains(song))
            {
                if (!result.ContainsKey(participant))
                {
                    result[participant] = new List<string>();
                }
                if (!result[participant].Contains(award))
                {
                    result[participant].Add(award);
                }
            }
        }
        if (result.Any())
        {
            foreach (var kvp in result.OrderByDescending(e => e.Value.Count).ThenBy(e => e.Key))
            {
                var participant = kvp.Key;
                var awards = kvp.Value;
                Console.WriteLine($"{participant}: {awards.Count} awards");
                foreach (var award in awards.OrderBy(e => e))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
        else
        {
            Console.WriteLine("No awards");
        }
    }
}

