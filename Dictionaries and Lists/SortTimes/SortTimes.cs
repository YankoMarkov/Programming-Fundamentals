using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SortTimes
{
    public static void Main(string[] args)
    {
        List<string> times = Console.ReadLine().Split(' ').ToList();
        times.Sort();
        Console.WriteLine(string.Join(", ", times));
    }
}

