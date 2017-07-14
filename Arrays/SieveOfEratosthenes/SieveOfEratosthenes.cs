using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SieveOfEratosthenes
{
    public static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());

        bool[] isPrime = new bool[num + 1];

        for (int i = 2; i <= num; i++)
        {
            if (!isPrime[i])
            {
                Console.Write(i + " ");
                for (int j = i; j <= num; j += i)
                {
                    isPrime[j] = true;
                }
            }
        }
    }
}

