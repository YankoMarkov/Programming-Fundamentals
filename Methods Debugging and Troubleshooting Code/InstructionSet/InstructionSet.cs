using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InstructionSet
{
    static void Main()
    {
        string opCode = null;

        while ((opCode = Console.ReadLine()) != "END")
        {
            string[] codeArgs = opCode.Split(' ');

            long result = 0;
            long operandOne = 0;
            long operandTwo = 0;
            switch (codeArgs[0])
            {
                case "INC":
                    operandOne = long.Parse(codeArgs[1]);
                    result = ++operandOne;
                    break;
                case "DEC":
                    operandOne = long.Parse(codeArgs[1]);
                    result = --operandOne;
                    break;
                case "ADD":
                    operandOne = long.Parse(codeArgs[1]);
                    operandTwo = long.Parse(codeArgs[2]);
                    result = operandOne + operandTwo;
                    break;
                case "MLA":
                    operandOne = long.Parse(codeArgs[1]);
                    operandTwo = long.Parse(codeArgs[2]);
                    result = operandOne * operandTwo;
                    break;
            }
            Console.WriteLine(result);
        }
    }
}

