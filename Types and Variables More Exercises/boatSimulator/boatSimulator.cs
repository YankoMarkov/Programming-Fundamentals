using System;
using System.Collections.Generic;
using System.Linq;

public class boatSimulator
{
    public static void Main(string[] args)
    {
        var firstBoat = char.Parse(Console.ReadLine());
        var secondBoat = char.Parse(Console.ReadLine());
        var n = int.Parse(Console.ReadLine());
        var firstBoatLength = 0;
        var secondBoathLength = 0;

        for (int i = 1; i <= n; i++)
        {
            var input = Console.ReadLine();

            if (input == "UPGRADE")
            {
                firstBoat += (char)3;
                secondBoat += (char)3;
                continue;
            }
            if (i % 2 != 0)
            {
                firstBoatLength += input.Length;
            }
            else
            {
                secondBoathLength += input.Length;
            }
            if (firstBoatLength >= 50 || secondBoathLength >= 50)
            {
                if (firstBoatLength > secondBoathLength)
                {
                    Console.WriteLine(firstBoat);
                    return;
                }
                else
                {
                    Console.WriteLine(secondBoat);
                    return;
                }
            }
        }
        if (firstBoatLength > secondBoathLength)
        {
            Console.WriteLine(firstBoat);
        }
        else
        {
            Console.WriteLine(secondBoat);
        }
    }
}

