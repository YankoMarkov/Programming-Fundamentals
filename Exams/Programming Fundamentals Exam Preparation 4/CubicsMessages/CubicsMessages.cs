using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class CubicsMessages
{
    static void Main(string[] args)
    {
        string inputs = null;
        Regex regex = new Regex(@"^(?<leftPart>\d+)(?<message>[a-zA-Z]+)(?<rightPart>[^a-zA-Z]*)$");

        while ((inputs = Console.ReadLine()) != "Over!")
        {
            var messageLength = int.Parse(Console.ReadLine());
            var matches = regex.Match(inputs);

            if (!matches.Success)
            {
                continue;
            }
            var leftPart = matches.Groups["leftPart"].Value;
            var message = matches.Groups["message"].Value;
            var rightPart = matches.Groups["rightPart"].Value;

            if (messageLength != message.Length)
            {
                continue;
            }
            var verificationCode = new string((leftPart + rightPart)
                .Where(char.IsDigit)
                .Select(@char => int.Parse(@char.ToString()))
                .Select(index => index >= 0 && index < message.Length ? message[index] : ' ')
                .ToArray());
            Console.WriteLine($"{message} == {verificationCode}");
        }
    }
}

