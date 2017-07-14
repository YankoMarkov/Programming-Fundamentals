using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ParkingValidation
{
    public static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());
        var users = new Dictionary<string, string>();

        for (int i = 0; i < num; i++)
        {
            var input = Console.ReadLine().Split().ToArray();
            var registration = input[0];
            var username = input[1];

            if (registration == "register")
            {
                var licensePlate = input[2];
                Print(Register(users, username, licensePlate));
            }
            if (registration == "unregister")
            {
                Print(Unregister(users, username));
            }
        }
        foreach (var item in users)
        {
            Console.WriteLine($"{item.Key} => {item.Value}");
        }
    }

    private static string Unregister(Dictionary<string, string> users, string username)
    {
        if (!users.ContainsKey(username))
        {
            return $"ERROR: user {username} not found";
        }
        users.Remove(username);
        return $"user {username} unregistered successfully";
    }

    private static void Print(string input)
    {
        Console.WriteLine(input);
    }

    private static string Register(Dictionary<string, string> users, string username, string licensePlate)
    {
        if (users.ContainsKey(username))
        {
            return $"ERROR: already registered with plate number {users[username]}";
        }
        if (users.ContainsValue(licensePlate))
        {
            return $"ERROR: license plate {licensePlate} is busy";
        }
        if (!IsValidLicencePlate(licensePlate))
        {
            return $"ERROR: invalid license plate {licensePlate}";
        }
        users.Add(username, licensePlate);
        return $"{username} registered {licensePlate} successfully";
    }

    private static bool IsValidLicencePlate(string licensePlate)
    {
        var firstPart = licensePlate.Substring(0, 2);
        var middlePart = licensePlate.Substring(2, 4);
        var lastPart = licensePlate.Substring(6, 2);

        bool first = firstPart[0] >= 'A' && firstPart[0] <= 'Z' &&
                     firstPart[1] >= 'A' && firstPart[1] <= 'Z';
        bool last = lastPart[0] >= 'A' && lastPart[0] <= 'Z' &&
                    lastPart[1] >= 'A' && lastPart[1] <= 'Z';
        bool middle = middlePart[0] >= '0' && middlePart[0] <= '9' &&
                      middlePart[1] >= '0' && middlePart[1] <= '9' &&
                      middlePart[2] >= '0' && middlePart[2] <= '9' &&
                      middlePart[3] >= '0' && middlePart[3] <= '9';

        return licensePlate.Length == 8 && first && middle && last;
    }
}

