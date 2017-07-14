using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PizzaIngredients
{
    public static void Main(string[] args)
    {
        var array = Console.ReadLine().Split(' ').ToArray();
        var num = int.Parse(Console.ReadLine());
        var count = 0;
        var ingrediants = "";

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length == num)
            {
                count++;
                Console.WriteLine($"Adding {array[i]}.");
                ingrediants += array[i] + " ";
            }
            if (count == 10)
            {
                break;
            }
        }
        var arr = ingrediants.Trim().Split(' ').ToArray();
        Console.WriteLine($"Made pizza with total of {count} ingredients.");
        Console.WriteLine("The ingredients are: " + string.Join(", ", arr) + ".");
    }
}

