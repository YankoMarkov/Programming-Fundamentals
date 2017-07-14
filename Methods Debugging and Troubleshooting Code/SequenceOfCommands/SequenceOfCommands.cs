using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceOfCommands
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string commands = null;

        while ((commands = Console.ReadLine()) != "stop")
        {
            string[] command = commands.Split(' ').ToArray();
            int[] args = new int[2];

            if (command[0].Equals("add") ||
                command[0].Equals("subtract") ||
                command[0].Equals("multiply"))
            {
                args[0] = int.Parse(command[1]);
                args[1] = int.Parse(command[2]);
            }
            
            PrintArray(PerformAction(array, command[0], args));
        }
    }

    static long[] PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr;
        int pos = args[0] - 1;
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(array);
                break;
            case "rshift":
                ArrayShiftRight(array);
                break;
        }
        return array;
    }

    private static void ArrayShiftRight(long[] array)
    {
        long num = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = num;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long num = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = num;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

