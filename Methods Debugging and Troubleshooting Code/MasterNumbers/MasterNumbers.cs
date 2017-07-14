using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MasterNumbers
{
    public static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());

        var getPalindrome = GetPalindrome(num);
        var getSumOfDigitsDivisibleBy7 = GetSumOfDigitsDivisibleBy7(getPalindrome);
        var getContainsEvenDigit = GetContainsEvenDigit(getSumOfDigitsDivisibleBy7);

        if (getContainsEvenDigit.Count > 0)
        {
            foreach (var item in getContainsEvenDigit)
            {
                Console.WriteLine(item);
            }
        }
    }

    public static List<string> GetPalindrome(int num)
    {
        var result = new List<string>();

        for (int i = 1; i <= num; i++)
        {
            string number = i.ToString();
            var leftSide = "";
            var rightSide = "";
            if (number.Length > 1 && number.Length % 2 != 0)
            {
                leftSide = number.Substring(0, number.Length / 2);
                rightSide = number.Substring(number.Length / 2 + 1, number.Length / 2);
                rightSide = new string(rightSide.Reverse().ToArray());
                if (leftSide == rightSide)
                {
                    result.Add(number);
                }
            }
            else if (number.Length > 1 && number.Length % 2 == 0)
            {
                leftSide = number.Substring(0, number.Length / 2);
                rightSide = number.Substring(number.Length / 2, number.Length / 2);
                rightSide = new string(rightSide.Reverse().ToArray());
                if (leftSide == rightSide)
                {
                    result.Add(number);
                }
            }

        }
        return result;
    }

    public static List<string> GetSumOfDigitsDivisibleBy7(List<string> num)
    {
        var result = new List<string>();

        for (int i = 0; i < num.Count; i++)
        {
            var sum = 0;
            var digit = num[i];
            for (int j = 0; j < digit.Length; j++)
            {
                sum += digit[j] - 48;
            }
            if (sum % 7 == 0)
            {
                result.Add(digit);
            }
        }
        return result;
    }

    public static List<string> GetContainsEvenDigit(List<string> num)
    {
        var result = new List<string>();
        for (int i = 0; i < num.Count; i++)
        {
            var count = 0;
            var digit = num[i];
            for (int j = 0; j < digit.Length; j++)
            {
                if ((digit[j] - 48) % 2 == 0)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                result.Add(digit);
            }
        }
        return result;
    }
}

