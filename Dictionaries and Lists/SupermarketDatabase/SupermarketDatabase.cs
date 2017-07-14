using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SupermarketDatabase
{
    public static void Main(string[] args)
    {
        var productPrice = new Dictionary<string, double>();
        var productQuantity = new Dictionary<string, int>();

        string inputs = null;

        while ((inputs = Console.ReadLine()) != "stocked")
        {
            var input = inputs.Split().ToArray();
            var product = input[0];
            var price = double.Parse(input[1]);
            var quantity = int.Parse(input[2]);

            if (!productPrice.ContainsKey(product))
            {
                productPrice.Add(product, price);
                productQuantity.Add(product, quantity);
            }
            else
            {
                productQuantity[product] += quantity;
                productPrice[product] = price;
            }
        }
        var totalSum = 0.0;
        foreach (var item in productPrice)
        {
            var prices = item.Value;
            var quantityes = productQuantity[item.Key];
            var sum = prices * quantityes;
            totalSum += sum;
            Console.WriteLine($"{item.Key}: ${prices:F2} * {quantityes} = ${sum:F2}");
        }
        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Grand Total: ${totalSum:F2}");
    }
}

