using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InventoryMatcher
{
    public static void Main(string[] args)
    {
        var productsName = Console.ReadLine().Split(' ').ToArray();
        var productsQuantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        var productsPrice = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        string products = null;

        while ((products = Console.ReadLine()) != "done")
        {
            for (int i = 0; i < productsName.Length; i++)
            {
                if (productsName[i] == products)
                {
                    Console.WriteLine($"{productsName[i]} costs: {productsPrice[i]}; Available quantity: {productsQuantities[i]}");
                }
            }
        }
    }
}

