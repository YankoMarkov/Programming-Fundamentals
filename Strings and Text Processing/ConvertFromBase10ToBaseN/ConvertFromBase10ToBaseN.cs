using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class ConvertFromBase10ToBaseN
{
    public static object BigInteger { get; private set; }

    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().ToArray();
        string x = input[0];
        string number = input[1];

        BigInteger n = new BigInteger();
        n.CompareTo(number);

     //   while (number > 0)
     //   {
     //       BigInteger temp = number % n;
     //       result += temp.ToString();
     //       number = number / n;
     //   }
     //   result = new string(result.Reverse().ToArray());
     //   Console.WriteLine(result);
    }
}

