using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder input = new StringBuilder(Console.ReadLine());
        var delete = 0;
        var index = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '>')
            {
                index = i + 1;
                delete += int.Parse(input[i + 1].ToString());

                while (delete > 0)
                {
                    if (input[index] != '>')
                    {
                        input = input.Remove(index, 1);
                        delete--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        Console.WriteLine(input.ToString());
    }
}

