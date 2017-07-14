using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PlayCatch
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToList();
        var count = 0;

        while (true)
        {
            var command = Console.ReadLine().Split().ToArray();

            switch (command[0])
            {
                case "Replace":
                    try
                    {
                        var index = int.Parse(command[1]);
                        var element = int.Parse(command[2]);
                        input[index] = element;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("The index does not exist!");
                        count++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        count++;
                    }
                    break;
                case "Print":
                    try
                    {
                        var startIndex = int.Parse(command[1]);
                        var endIndex = int.Parse(command[2]);
                        var temp = new List<int>();
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            temp.Add(input[i]);
                        }
                        Console.WriteLine(string.Join(", ", temp));
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("The index does not exist!");
                        count++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        count++;
                    }
                    break;
                case "Show":
                    try
                    {
                        var index = int.Parse(command[1]);
                        Console.WriteLine(input[index]);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("The index does not exist!");
                        count++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        count++;
                    }
                    break;
                default:
                    break;
            }
            if (count >= 3)
            {
                Console.WriteLine(string.Join(", ", input));
                return;
            }
        }
    }
}

