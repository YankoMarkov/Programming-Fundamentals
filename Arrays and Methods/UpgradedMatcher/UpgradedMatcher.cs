using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UpgradedMatcher
{
    public static void Main(string[] args)
    {
        var productsName = Console.ReadLine().Split(' ').ToArray();
        var productsQuantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        var productsPrice = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        string products = null;

        while ((products = Console.ReadLine()) != "done")
        {
            var product = products.Split(' ').ToArray();
            var productName = product[0];
            var productQuantity = long.Parse(product[1]);

            for (int i = 0; i < productsName.Length; i++)
            {
                if (productsName[i] == productName)
                {
                    if (i > productsQuantities.Length - 1)
                    {
                        Console.WriteLine($"We do not have enough {productName}");
                        continue;
                    }
                    if (productQuantity > productsQuantities[i])
                    {
                        Console.WriteLine($"We do not have enough {productName}");
                        continue;
                    }
                    var costs = productQuantity * productsPrice[i];
                    productsQuantities[i] -= productQuantity;
                    Console.WriteLine($"{productName} x {productQuantity} costs {costs:F2}");
                }
            }
        }
    }
}

