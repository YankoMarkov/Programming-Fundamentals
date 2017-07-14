using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SafeManipulation
{
    public static void Main(string[] args)
    {
        var array = Console.ReadLine().Split(' ').ToArray();
        string commands = null;

        while ((commands = Console.ReadLine()) != "END")
        {
            var command = commands.Split(' ').ToArray();

            switch (command[0])
            {
                case "Reverse":
                    array = ReverseArray(array);
                    break;
                case "Distinct":
                    array = DistinctItemsInArray(array);
                    break;
                case "Replace":
                    var index = int.Parse(command[1]);
                    if (index < 0 || index >= array.Length)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        array = ReplaceItemsInArray(array, index, command[2]);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }
        Console.WriteLine(string.Join(", ", array));
    }

    private static string[] ReverseArray(string[] arr)
    {
        var array = arr.Reverse().ToArray();
        return array;
    }

    private static string[] DistinctItemsInArray(string[] arr)
    {
        var array = arr.Distinct().ToArray();
        return array;
    }

    private static string[] ReplaceItemsInArray(string[] arr, int index, string word)
    {
        var array = new string[arr.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (i == index)
            {
                array[i] = word;
            }
            else
            {
                array[i] = arr[i];
            }
        }
        return array;
    }
}

