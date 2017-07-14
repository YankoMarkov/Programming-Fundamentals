using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserLogs
{
    public static void Main(string[] args)
    {
        string inputs = null;
        var result = new Dictionary<string, Dictionary<string, int>>();

        while ((inputs = Console.ReadLine()) != "end")
        {
            var input = inputs.Split().ToArray();
            var first = input[0].Split('=');
            var ip = first[1];
            var third = input[2].Split('=');
            var user = third[1];

            if (!result.ContainsKey(user))
            {
                result.Add(user, new Dictionary<string, int>());
            }
            if (!result[user].ContainsKey(ip))
            {
                result[user].Add(ip, 1);
            }
            else
            {
                result[user][ip] += 1;
            }
        }
        foreach (var users in result.Keys.OrderBy(p => p))
        {
            Console.WriteLine($"{users}: ");
            var temp = new List<string>();
            foreach (var ips in result[users])
            {
                temp.Add(string.Format($"{ips.Key} => {ips.Value}"));
            }
            Console.WriteLine(string.Join(", ", temp) + ".");
        }
    }
}

