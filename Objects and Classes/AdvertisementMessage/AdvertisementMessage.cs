using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AdvertisementMessage
{
    public static void Main(string[] args)
    {
        var input = int.Parse(Console.ReadLine());

        string[] phrases = new string[]
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };

        string[] events = new string[]
        {
            "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
        };

        string[] cities = new string[]
        {
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
        };
        Random random = new Random();
        string result = "";

        for (int i = 0; i < input; i++)
        {
            result = phrases[random.Next(0, phrases.Length)] + " " + events[random.Next(0, events.Length)] + " - " + cities[random.Next(0, cities.Length)];
            Console.WriteLine(result);
        }
    }
}

