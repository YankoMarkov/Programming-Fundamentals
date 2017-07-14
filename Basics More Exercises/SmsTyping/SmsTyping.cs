using System;
using System.Collections.Generic;
using System.Linq;

public class smsTyping
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var messege = "";

        for (int i = 0; i < n; i++)
        {
            var digits = Console.ReadLine();
            var mainDigit = int.Parse(digits[0].ToString());
            var offset = (mainDigit - 2) * 3;

            if (mainDigit == 8 || mainDigit == 9)
            {
                offset += 1;
            }
            var letterIndex = offset + digits.Length - 1;
            if (mainDigit == 0)
            {
                messege += " ";
            }
            else
            {
                messege += (char)(97 + letterIndex);
            }
        }
        Console.WriteLine(messege);
    }
}

