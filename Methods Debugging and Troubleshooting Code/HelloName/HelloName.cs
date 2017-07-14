using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HelloName
{
    public static void Main(string[] args)
    {
        var name = Console.ReadLine();

        PrintName(name);
    }

    static void PrintName(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

