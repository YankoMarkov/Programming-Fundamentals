using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AMinerTask
{
    public static void Main(string[] args)
    {
        string inputs = null;
        var result = new Dictionary<string, int>();

        while ((inputs = Console.ReadLine()) != "stop")
        {
            var num = int.Parse(Console.ReadLine());

            if (!result.ContainsKey(inputs))
            {
                result.Add(inputs, num);
            }
            else
            {
                result[inputs] += num;
            }
        }
        foreach (var item in result)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

