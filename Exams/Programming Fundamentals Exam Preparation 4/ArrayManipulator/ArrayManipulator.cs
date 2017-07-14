using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayManipulator
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string commands = null;

        while ((commands = Console.ReadLine()) != "end")
        {
            var commandLine = commands.Split().ToArray();
            var command = commandLine[0];
            int index = 0;
            int count = 0;
            string evenOrOdd = "";

            switch (command)
            {
                case "exchange":
                    index = int.Parse(commandLine[1]);
                    input = Exchange(input, index);
                    break;
                case "max":
                case "min":
                    evenOrOdd = commandLine[1];
                    MaxAndMin(input, evenOrOdd, command, index);
                    break;
                case "first":
                case "last":
                    count = int.Parse(commandLine[1]);
                    evenOrOdd = commandLine[2];
                    FirstAndLast(input, count, evenOrOdd, command);
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine("[" + string.Join(", ", input) + "]");
    }

    private static void FirstAndLast(int[] input, int count, string evenOrOdd, string command)
    {
        if (count > input.Length)
        {
            Console.WriteLine("Invalid count");
        }
        else
        {
            var filter = input.Where(a => evenOrOdd == "even" ? a % 2 == 0 : a % 2 == 1).ToArray();

            var result = command == "first" ? filter.Take(count).ToArray() : filter.Skip(filter.Length - count).ToArray();
            Console.WriteLine("[" + string.Join(", ", result) + "]");
        }
    }

    private static void MaxAndMin(int[] input, string evenOrOdd, string command, int index)
    {
        var filter = input.Where(a => evenOrOdd == "even" ? a % 2 == 0 : a % 2 == 1).ToArray();

        if (filter.Any())
        {
            var result = command == "max" ? filter.Max() : filter.Min();
            index = Array.LastIndexOf(input, result);
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }

    private static int[] Exchange(int[] input, int index)
    {
        if (index < 0 || index > input.Length - 1)
        {
            Console.WriteLine("Invalid index");
            return input;
        }
        else
        {
            var left = input.Take(index + 1).ToArray();
            var right = input.Skip(index + 1).ToArray();

            var result = right.Concat(left).ToArray();
            return result;
        }
    }
}

