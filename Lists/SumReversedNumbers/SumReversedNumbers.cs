using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SumReversedNumbers
{
    public static void Main(string[] args)
    {
        var list = Console.ReadLine().Split(' ').ToList();
        var result = new List<int>();
        var number = "";

        for (int i = 0; i < list.Count; i++)
        {
            var num = list[i];
            number = new string(num.ToCharArray().Reverse().ToArray());
            result.Add(int.Parse(number));
        }
        Console.WriteLine(result.Sum());
    }
}

