using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ByteFlip
{
    public static void Main(string[] args)
    {
        var inputs = Console.ReadLine()
            .Split()
            .Where(x => x.Length == 2).ToList();

        for (int i = 0; i < inputs.Count; i++)
        {
            inputs[i] = new string(inputs[i].ToCharArray().Reverse().ToArray());
        }
        inputs.Reverse();

        var result = "";
        for (int i = 0; i < inputs.Count; i++)
        {
            var value = Convert.ToInt32(inputs[i], 16);
            var charValue = (char)value;
            result += charValue;
        }
        Console.WriteLine(result);
    }
}

