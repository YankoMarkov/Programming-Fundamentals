using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TakeSkipRope
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine().ToCharArray();

        var digit = input.Where(a => char.IsDigit(a)).Select(a => int.Parse(a.ToString())).ToArray();
        var letter = input.Where(a => !char.IsDigit(a)).ToArray();

        var take = new List<int>();
        var skip = new List<int>();

        for (int i = 0; i < digit.Length; i++)
        {
            if (i % 2 == 0)
            {
                take.Add(digit[i]);
            }
            else
            {
                skip.Add(digit[i]);
            }
        }
        var totalSkip = 0;
        var finalMessage = "";
        for (int i = 0; i < take.Count; i++)
        {
            var takeCount = take[i];
            var skipCount = skip[i];

            finalMessage += new string(letter.Skip(totalSkip).Take(takeCount).ToArray());
            totalSkip += takeCount + skipCount;
        }
        Console.WriteLine(finalMessage);
    }
}

