using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Heists
{
    public static void Main(string[] args)
    {
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string inputs = null;
        var TotalEarnings = 0;
        var totalExpenses = 0;

        while ((inputs = Console.ReadLine()) != "Jail Time")
        {
            var input = inputs.Split(' ').ToArray();
            var word = input[0];
            var num = int.Parse(input[1]);

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '%')
                {
                    TotalEarnings += array[0];
                }
                if (word[i] == '$')
                {
                    TotalEarnings += array[1];
                }
            }
            totalExpenses += num;
        }
        var result = 0;
        if (TotalEarnings >= totalExpenses)
        {
            result = TotalEarnings - totalExpenses;
            Console.WriteLine($"Heists will continue. Total earnings: {result}.");
        }
        else
        {
            result = totalExpenses - TotalEarnings;
            Console.WriteLine($"Have to find another job. Lost: {result}.");
        }
    }
}

