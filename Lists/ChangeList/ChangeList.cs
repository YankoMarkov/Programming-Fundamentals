using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ChangeList
{
    public static void Main(string[] args)
    {
        var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        
        while (true)
        {
            var command = Console.ReadLine().Split(' ').ToArray();
            var element = 0;

            switch (command[0])
            {
                case "Delete":
                    element = int.Parse(command[1]);
                    list = new List<int>(DeleteElementsInList(list, element));
                    break;
                case "Insert":
                    element = int.Parse(command[1]);
                    var index = int.Parse(command[2]);
                    list = new List<int>(InsertElementInList(list, element, index));
                    break;
                default:
                    break;
            }
            if (command[0] == "Odd")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0)
                    {
                        Console.Write(list[i] + " ");
                    }
                }
                break;
            }
            if (command[0] == "Even")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        Console.Write(list[i] + " ");
                    }
                }
                break;
            }
        }
    }

    private static List<int> DeleteElementsInList(List<int> list, int element)
    {
        while (list.Contains(element))
        {
            list.Remove(element);
        }
        var result = new List<int>(list);
        return result;
    }

    private static List<int> InsertElementInList(List<int> list, int element, int index)
    {
        list.Insert(index, element);
        var result = new List<int>(list);
        return result;
    }
}

