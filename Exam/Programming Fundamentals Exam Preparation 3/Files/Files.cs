using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Files
{
    static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());
        var result = new Dictionary<string, Dictionary<string, long>>();
        for (int i = 0; i < num; i++)
        {
            var input = Console.ReadLine().Split('\\').ToArray();
            var root = input[0];
            var file = input[input.Length - 1].Split(';');
            var filename = file[0];
            var filesize = long.Parse(file[1]);

            if (!result.ContainsKey(root))
            {
                result.Add(root, new Dictionary<string, long>());
            }
            if (!result[root].ContainsKey(filename))
            {
                result[root].Add(filename, filesize);
            }
            else
            {
                result[root][filename] = filesize;
            }
        }
        var commands = Console.ReadLine().Split();
        var extension = commands[0];
        var roots = commands[2];
        var check = false;

        foreach (var item in result)
        {
            if (item.Key == roots)
            {
                foreach (var items in item.Value.Where(a => a.Key.EndsWith(extension)).OrderByDescending(a => a.Value).ThenBy(a => a.Key))
                {
                    Console.WriteLine($"{items.Key} - {items.Value} KB ");
                    check = true;
                }
            }
        }
        if (!check)
        {
            Console.WriteLine("No");
        }
    }
}

