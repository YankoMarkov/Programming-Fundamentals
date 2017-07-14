using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GrabAndGo
{
    public static void Main(string[] args)
    {
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var num = int.Parse(Console.ReadLine());
        var index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
            {
                index = i;
            }
        }

        if (index > 0)
        {
            long sum = 0;
            for (int i = 0; i < index; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("No occurrences were found!");
        }
    }
}
