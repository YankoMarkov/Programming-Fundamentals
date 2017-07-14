using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Strudent
{
    string Name { get; set; }
    List<string> Comments { get; set; }
    List<DateTime> Dates { get; set; }
}

class MentorGroup
{
    static void Main(string[] args)
    {
        var userAndDate = AddUsersAndDate();
        var userAndComment = AddUserAndComment(userAndDate);

        foreach (var userDate in userAndDate.OrderBy(s => s.Key))
        {
            Console.WriteLine($"{userDate.Key}\nComments:");
            foreach (var userComment in userAndComment)
            {
                if (userComment.Key == userDate.Key)
                {
                    foreach (var item in userComment.Value)
                    {
                        Console.WriteLine($"- {item}");
                    }
                }
            }
            Console.WriteLine("Dates attended:");
            foreach (var item in userDate.Value.OrderBy(s => s.Date))
            {
                Console.WriteLine($"-- {item.ToString("dd/MM/yyyy")}");
            }
        }
    }

    private static Dictionary<string, List<string>> AddUserAndComment(Dictionary<string, List<DateTime>> AddUsersAndDate)
    {
        string inputs = null;
        var userAndComment = new Dictionary<string, List<string>>();
        while ((inputs = Console.ReadLine()) != "end of comments")
        {
            var input = inputs.Split('-').ToArray();
            var user = input[0];
            if (!AddUsersAndDate.Keys.Contains(user))
            {
                continue;
            }
            if (!userAndComment.ContainsKey(user))
            {
                userAndComment.Add(user, AddComments(input));
            }
            else
            {
                userAndComment[user].AddRange(AddComments(input));
            }
        }
        return userAndComment;
    }

    private static Dictionary<string, List<DateTime>> AddUsersAndDate()
    {
        string inputs = null;
        var userAndDate = new Dictionary<string, List<DateTime>>();

        while ((inputs = Console.ReadLine()) != "end of dates")
        {
            var input = inputs.Split(' ', ',').ToArray();
            var user = input[0];
            if (!userAndDate.ContainsKey(user))
            {
                userAndDate.Add(user, AddDates(input));
            }
            else
            {
                userAndDate[user].AddRange(AddDates(input));
            }
        }
        return userAndDate;
    }

    private static List<DateTime> AddDates(string[] input)
    {
        List<DateTime> dates = new List<DateTime>();
        for (int i = 1; i < input.Length; i++)
        {
            dates.Add(DateTime.ParseExact(input[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
        }
        return dates;
    }

    private static List<string> AddComments(string[] input)
    {
        List<string> comments = new List<string>();
        for (int i = 1; i < input.Length; i++)
        {
            comments.Add(input[i]);
        }
        return comments;
    }
}

