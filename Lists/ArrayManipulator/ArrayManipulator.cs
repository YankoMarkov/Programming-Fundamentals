using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ArrayManipulator
{
    public static void Main(string[] args)
    {
        var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        string commands = null;

        while ((commands = Console.ReadLine()) != "print")
        {
            var command = commands.Split(' ').ToArray();
            var index = 0;
            var element = 0;
            var tempList = new List<int>();

            if (command[0] == "add")
            {
                index = int.Parse(command[1]);
                element = int.Parse(command[2]);
                list.Insert(index, element);
            }
            else if (command[0] == "addMany")
            {
                index = int.Parse(command[1]);
                for (int i = 2; i < command.Length; i++)
                {
                    tempList.Add(int.Parse(command[i]));
                }
                list.InsertRange(index, tempList);
            }
            else if (command[0] == "contains")
            {
                element = int.Parse(command[1]);
                Console.WriteLine(list.IndexOf(element));
            }
            else if (command[0] == "remove")
            {
                index = int.Parse(command[1]);
                list.RemoveAt(index);
            }
            else if (command[0] == "shift")
            {
                index = int.Parse(command[1]) % list.Count;
                for (int i = 0; i < index; i++)
                {
                    list.Add(list[0]);
                    list.RemoveAt(0);
                }
            }
            else if (command[0] == "sumPairs")
            {
                for (int i = 0; i < list.Count; i += 2)
                {
                    var currentElement = list[i];
                    var nextElement = 0;

                    if (i < list.Count - 1)
                    {
                        nextElement = list[i + 1];
                    }
                    var sumPairs = currentElement + nextElement;
                    tempList.Add(sumPairs);
                }
                list = tempList;
            }
        }
        Console.WriteLine("[" + string.Join(", ", list) + "]");
    }
}

