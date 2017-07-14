using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SweetDessert
{
    static void Main(string[] args)
    {
        var cash = decimal.Parse(Console.ReadLine());
        var guests = int.Parse(Console.ReadLine());
        var bananasPrice = decimal.Parse(Console.ReadLine());
        var eggsPrice = decimal.Parse(Console.ReadLine());
        var berriesPrice = decimal.Parse(Console.ReadLine());

        var sets = Math.Ceiling((decimal)guests / 6);
        var setsPrice = (2 * bananasPrice) + (4 * eggsPrice) + (berriesPrice * (decimal)0.2);
        var totalPrice = sets * setsPrice;

        if (totalPrice <= cash)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
        }
        else
        {
            var cashNeeded = totalPrice - cash;
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {cashNeeded:f2}lv more.");
        }
    }
}

