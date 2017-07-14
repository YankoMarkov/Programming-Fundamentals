using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TeamworkProjects
{
    static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());
        var teams = new Dictionary<string, string>();

        for (int i = 0; i < num; i++)
        {
            var input = Console.ReadLine().Split('-').ToArray();
            var user = input[0];
            var team = input[1];

            if (!teams.ContainsKey(team))
            {
                if (!teams.ContainsValue(user))
                {
                    teams.Add(team, user);
                    Console.WriteLine($"Team {team} has been created by {user}!");
                }
                else
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }
            }
            else
            {
                Console.WriteLine($"Team {team} was already created!");
            }
        }
        Dictionary<string, string> usersToJoin = users;
        string input = null;
        string result = "";

        while ((input = Console.ReadLine()) != "end of assignment")
        {
            var userToJoin = input.Split("->".ToCharArray()).ToArray();
            var user = userToJoin[0];
            var team = userToJoin[1];

            if (usersToJoin.ContainsKey(team))
            {
                if (!usersToJoin.ContainsValue(user))
                {
                    usersToJoin[team] += user;
                }
                else
                {
                    result = string.Format($"Member {user} cannot join team {team}!");
                }
            }
            else
            {
                result = string.Format($"Team {team} does not exist!");
            }
        }
    }

    private static string AddUsers(Dictionary<string, string> users)
    {
        Dictionary<string, string> usersToJoin = users;
        string input = null;
        string result = "";

        while ((input = Console.ReadLine()) != "end of assignment")
        {
            var userToJoin = input.Split("->".ToCharArray()).ToArray();
            var user = userToJoin[0];
            var team = userToJoin[1];

            if (usersToJoin.ContainsKey(team))
            {
                if (!usersToJoin.ContainsValue(user))
                {
                    usersToJoin[team] += user;
                }
                else
                {
                    result = string.Format($"Member {user} cannot join team {team}!");
                }
            }
            else
            {
                result = string.Format($"Team {team} does not exist!");
            }
        }
        return result;
    }

    private static Dictionary<string, string> Addteam()
    {
        var num = int.Parse(Console.ReadLine());
        var teams = new Dictionary<string, string>();

        for (int i = 0; i < num; i++)
        {
            var input = Console.ReadLine().Split('-').ToArray();
            var user = input[0];
            var team = input[1];

            if (!teams.ContainsKey(team))
            {
                if (!teams.ContainsValue(user))
                {
                    teams.Add(team, user);
                    Console.WriteLine($"Team {team} has been created by {user}!");
                }
                else
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }
            }
            else
            {
                Console.WriteLine($"Team {team} was already created!");
            }
        }
        return teams;
    }
}

