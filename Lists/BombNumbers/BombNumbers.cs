using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BombNumbers
{
    public static void Main(string[] args)
    {
        var listNum = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var command = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var bombNum = command[0];
        var bombRadios = command[1];
        var leftIndex = 0;
        var rightIndex = 0;

        for (int i = 0; i < listNum.Count; i++)
        {
            if (listNum[i] == bombNum)
            {
                leftIndex = Math.Max(i - bombRadios, 0);
                rightIndex = Math.Min(i + bombRadios, listNum.Count - 1);

      //          if (leftIndex < 0)
      //          {
      //              leftIndex = 0;
      //          }
      //          if (rightIndex > listNum.Count - 1)
      //          {
      //              rightIndex = listNum.Count - 1;
      //          }

                listNum.RemoveRange(leftIndex, (rightIndex - leftIndex) + 1);
                i = -1;
            }

        }
        Console.WriteLine(listNum.Sum());
    }
}

