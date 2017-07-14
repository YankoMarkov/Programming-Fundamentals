using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LargestCommonEnd
{
    public static void Main(string[] args)
    {
        var firstArr = Console.ReadLine().Split(' ').ToArray();
        var secondArr = Console.ReadLine().Split(' ').ToArray();
        var leftCount = 0;
        var rightCount = 0;
        var length = 0;

        if (firstArr.Length <= secondArr.Length)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    leftCount++;
                }
            }
            for (int i = firstArr.Length - 1; i >= 0; i--)
            {
                length = secondArr.Length - firstArr.Length;
                if (firstArr[i] == secondArr[i + length])
                {
                    rightCount++;
                }
            }

        }
        else
        {
            for (int i = 0; i < secondArr.Length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    leftCount++;
                }
            }
            for (int i = secondArr.Length - 1; i >= 0; i--)
            {
                length = firstArr.Length - secondArr.Length;
                if (firstArr[i + length] == secondArr[i])
                {
                    rightCount++;
                }
            }
        }
        if (leftCount >= rightCount)
        {
            Console.WriteLine(leftCount);
        }
        else
        {
            Console.WriteLine(rightCount);
        }
    }
}

