using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class JumpAround
{
    public static void Main(string[] args)
    {
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var sum = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            var index = 0;
            if (array[i] <= (array.Length - 1) - i)
            {
                index = array[i] + i;
                sum += array[index];
                i = index - 1;
                continue;
            }
            if (array[i] <= i)
            {
                index = i - array[i];
                sum += array[index];
                i = index - 1;
            }
            else
            {
                Console.WriteLine(sum);
                return;
            }
        }
    }
}

