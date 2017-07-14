using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ladybug
{
    static void Main(string[] args)
    {
        var fieldSize = int.Parse(Console.ReadLine());
        var ladybugsIndex = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(s => s >= 0 && s < fieldSize)
            .ToArray();
        var ladyBugs = new int[fieldSize];

        foreach (var item in ladybugsIndex)
        {
            ladyBugs[item] = 1;
        }

        string inputs = null;

        while ((inputs = Console.ReadLine()) != "end")
        {
            var input = inputs.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            var index = int.Parse(input[0]);
            var direction = input[1];
            var count = int.Parse(input[2]);

            if (index < 0 || index > ladyBugs.Length - 1)
            {
                continue;
            }
            if (ladyBugs[index] != 1)
            {
                continue;
            }
            MoveDestination(ladyBugs, index, direction, count);
        }
        Console.WriteLine(string.Join(" ", ladyBugs));
    }

    private static void MoveDestination(int[] ladyBug, int index, string direction, int count)
    {
        if (direction == "left")
        {
            count = -count;
        }
        var nextIndex = index + count;
        ladyBug[index] = 0;

        var isFoundPlace = false;
        while (!isFoundPlace)
        {
            if (nextIndex < 0 || nextIndex > ladyBug.Length - 1)
            {
                isFoundPlace = true;
                continue;
            }
            if (ladyBug[nextIndex] == 1)
            {
                nextIndex += count;
                continue;
            }
            ladyBug[nextIndex] = 1;
            isFoundPlace = true;
        }
    }
}

