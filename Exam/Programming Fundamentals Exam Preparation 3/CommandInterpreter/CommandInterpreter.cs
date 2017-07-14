using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CommandInterpreter
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().ToList();

        string commands = null;
        while ((commands = Console.ReadLine()) != "end")
        {
            var commandLine = commands.Split().ToArray();
            var command = commandLine[0];
            int startIndex = 0;
            int count = 0;

            switch (command)
            {
                case "reverse":
                    startIndex = int.Parse(commandLine[2]);
                    count = int.Parse(commandLine[4]);
                    Reverse(input, startIndex, count);
                    break;
                case "sort":
                    startIndex = int.Parse(commandLine[2]);
                    count = int.Parse(commandLine[4]);
                    Sort(input, startIndex, count);
                    break;
                case "rollLeft":
                    count = int.Parse(commandLine[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }
                    input = RollLeft(input, count);
                    break;
                case "rollRight":
                    count = int.Parse(commandLine[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }
                    input = RollRight(input, count);
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine("[" + string.Join(", ", input) + "]");
    }

    private static void Reverse(List<string> input, int startIndex, int count)
    {
        if (startIndex >= 0 && startIndex <= input.Count - 1 && count >= 0 && startIndex + count <= input.Count)
        {
            input.Reverse(startIndex, count);
        }
        else
        {
            Console.WriteLine("Invalid input parameters.");
        }
    }

    private static void Sort(List<string> input, int startIndex, int count)
    {
        if (startIndex >= 0 && startIndex <= input.Count - 1 && count >= 0 && startIndex + count <= input.Count)
        {
            var temp = input.Skip(startIndex).Take(count).OrderBy(s => s).ToList();
            input.RemoveRange(startIndex, count);
            input.InsertRange(startIndex, temp);
        }
        else
        {
            Console.WriteLine("Invalid input parameters.");
        }
    }

    private static List<string> RollRight(List<string> input, int count)
    {
        var result = new List<string>();
        var index = count % input.Count;
        var startIndex = input.Count - index;
        for (int i = 0; i < input.Count; i++)
        {
            result.Add(input[startIndex % input.Count]);
            startIndex++;
        }
        return result;
    }

    private static List<string> RollLeft(List<string> input, int count)
    {
        var result = new List<string>();
        var startIndex = count % input.Count;
        for (int i = 0; i < input.Count; i++)
        {
            result.Add(input[startIndex % input.Count]);
            startIndex++;
        }
        return result;
    }

}

