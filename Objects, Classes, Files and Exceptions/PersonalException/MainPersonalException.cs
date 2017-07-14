using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainPersonalException
{
    static void Main(string[] args)
    {
        try
        {
            while (true)
            {
                var input = int.Parse(Console.ReadLine());
                if (input < 0)
                {
                    throw new PersonalException();
                }
                Console.WriteLine(input);
            }
        }
        catch (PersonalException pe)
        {
            Console.WriteLine(pe.Message);
            return;
        }
    }
}

