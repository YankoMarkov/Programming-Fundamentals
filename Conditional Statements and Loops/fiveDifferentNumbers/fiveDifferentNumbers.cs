using System;
using System.Collections.Generic;
using System.Linq;

public class fiveDifferentNumbers
{
    public static void Main(string[] args)
    {
        var firsNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());

        var diff = secondNum - firsNum;

        if (diff < 5)
        {
            Console.WriteLine("No");
            return;
        }

        for (int n1 = firsNum; n1 <= secondNum; n1++)
        {
            for (int n2 = firsNum; n2 <= secondNum; n2++)
            {
                for (int n3 = firsNum; n3 <= secondNum; n3++)
                {
                    for (int n4 = firsNum; n4 <= secondNum; n4++)
                    {
                        for (int n5 = firsNum; n5 <= secondNum; n5++)
                        {
                            if (n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5)
                            {
                                Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                            }
                        }
                    }
                }
            }
        }
    }
}

