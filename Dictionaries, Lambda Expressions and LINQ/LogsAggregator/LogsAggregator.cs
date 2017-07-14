using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LogsAggregator
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var users = new SortedDictionary<string, SortedSet<string>>();
        var count = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split().ToArray();
            var ip = input[0];
            var user = input[1];
            var duration = int.Parse(input[2]);

            if (!users.ContainsKey(user))
            {
                users.Add(user, new SortedSet<string>());
                count.Add(user, 0);
            }
            count[user] += duration;
            users[user].Add(ip);
        }

        foreach (var user in users.Keys)
        {
            Console.Write($"{user}: {count[user]} ");
            Console.WriteLine("[" + string.Join(", ", users[user]) + "]");
        }
    }
}

