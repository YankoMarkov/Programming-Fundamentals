using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CharityMarathon
{
    static void Main(string[] args)
    {
        var daysOfMaraton = int.Parse(Console.ReadLine());
        var numberOfRunners = int.Parse(Console.ReadLine());
        var numberOfLapsPerRunner = int.Parse(Console.ReadLine());
        var lengthOfTrack = int.Parse(Console.ReadLine());
        var runnerCapacityOfTrack = int.Parse(Console.ReadLine());
        var amountOfMoneyPerKilometer = double.Parse(Console.ReadLine());

        var runnerCapacityForMaraton = runnerCapacityOfTrack * daysOfMaraton;
        if (runnerCapacityForMaraton > numberOfRunners)
        {
            runnerCapacityForMaraton = numberOfRunners;
        }
        long totalMeters = (long)runnerCapacityForMaraton * numberOfLapsPerRunner * lengthOfTrack;
        long totalKilometers = totalMeters / 1000;
        double money = totalKilometers * amountOfMoneyPerKilometer;

        Console.WriteLine($"Money raised: {money:f2}");
    }
}

