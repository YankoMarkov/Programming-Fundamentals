using System;
using System.Collections.Generic;
using System.Linq;

public class employeeData
{
    public static void Main(string[] args)
    {
        var firstName = Console.ReadLine();
        var lastName = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var gender = char.Parse(Console.ReadLine());
        var idNumber = long.Parse(Console.ReadLine());
        var employeeNumber = int.Parse(Console.ReadLine());

        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Last name: {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Personal ID: {idNumber}");
        Console.WriteLine($"Unique Employee number: {employeeNumber}");
    }
}

