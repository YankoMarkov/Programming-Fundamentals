using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class NetherRealms
{
    static void Main(string[] args)
    {
        var inputs = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(Deamon.Parse).OrderBy(s => s.Name).ToArray();

        foreach (var input in inputs)
        {
            Console.WriteLine($"{input.Name} - {input.Health} health, {input.Damage:f2} damage");
        }
    }
}

class Deamon
{
    public string Name { get; set; }
    public int Health { get; set; }
    public double Damage { get; set; }

    public static Deamon Parse(string deamonStr)
    {
        var name = deamonStr;
        Regex healthRegex = new Regex(@"[^\d\-+*\/\.]");
        Regex damageRegex = new Regex(@"-?\d+(?:\.\d+)?");
        MatchCollection healthMatch = healthRegex.Matches(deamonStr);
        MatchCollection damageMatch = damageRegex.Matches(deamonStr);

        var health = healthMatch.Cast<Match>().Select(s => (int)char.Parse(s.Value)).Sum();
        var damage = damageMatch.Cast<Match>().Select(s => double.Parse(s.Value)).Sum();

        var multiplyCount = deamonStr.Count(s => s == '*');
        var divideCount = deamonStr.Count(s => s == '/');

        damage *= (int)Math.Pow(2, multiplyCount);
        damage /= (int)Math.Pow(2, divideCount);

        Deamon deamon = new Deamon();
        deamon.Name = name;
        deamon.Health = health;
        deamon.Damage = damage;
        return deamon;
    }
}
