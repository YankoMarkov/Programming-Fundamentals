﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class ConvertFromBaseNToBase10
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Trim().Split();
        int baseN = int.Parse(input[0]);
        char[] number = input[1].ToCharArray();
        BigInteger result = new BigInteger(0);

        for (int i = number.Length - 1, n = 0; i >= 0; i--, n++)
        {
            BigInteger num = new BigInteger(char.GetNumericValue(number[n]));
            BigInteger forSum = BigInteger.Multiply(num, BigInteger.Pow(new BigInteger(baseN), i));
            result += forSum;
        }
        Console.WriteLine(result.ToString());
    }
}

