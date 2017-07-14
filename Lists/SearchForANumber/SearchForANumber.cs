using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SearchForANumber
{
    public static void Main(string[] args)
    {
        var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        if (list.Count >= array[0])
        {
            list = TakeElementsFromList(list, array[0]);
        }
        else
        {
            Console.WriteLine("NO!");
            return;
        }

        if (list.Count >= array[1])
        {
            list = DeleteElementsFromList(list, array[1]);
        }
        else
        {
            Console.WriteLine("NO!");
            return;
        }

        if (SearchElementInList(list, array[2]))
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }
    }

    private static List<int> TakeElementsFromList(List<int> list, int num)
    {
        var result = new List<int>();
        for (int i = 0; i < num; i++)
        {
            result.Add(list[i]);
        }
        return result;
    }

    private static List<int> DeleteElementsFromList(List<int> list, int num)
    {
        var result = new List<int>();
        for (int i = num; i < list.Count; i++)
        {
            result.Add(list[i]);
        }
        return result;
    }

    private static bool SearchElementInList(List<int> list, int num)
    {
        var isContains = false;
        if (list.Contains(num))
        {
            isContains = true;
        }
        return isContains;
    }
}

