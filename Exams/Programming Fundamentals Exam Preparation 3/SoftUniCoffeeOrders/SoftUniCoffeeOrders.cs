using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SoftUniCoffeeOrders
{
    static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());
        decimal totalSum = 0;

        for (int i = 0; i < num; i++)
        {
            var pricePerCapsule = decimal.Parse(Console.ReadLine());
            var date = Console.ReadLine().Split('/').ToArray();
            var capsulesCount = int.Parse(Console.ReadLine());
            var year = int.Parse(date[2]);
            var month = int.Parse(date[1]);
            var daysOfMonth = DateTime.DaysInMonth(year, month);

            var price = (daysOfMonth * (long)capsulesCount) * pricePerCapsule;
            totalSum += price;
            Console.WriteLine($"The price for the coffee is: ${price:f2}");
        }
        Console.WriteLine($"Total: ${totalSum:f2}");
    }
}

