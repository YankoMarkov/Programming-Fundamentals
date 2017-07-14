using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class centuriesToNanoseconds
{
    public static void Main(string[] args)
    {
        var centuries = int.Parse(Console.ReadLine());

        var years = centuries * 100;
        var days = (int) (years * 365.2422);
        long hours = days * 24;
        BigInteger minutes = hours * 60;
        BigInteger seconds = minutes * 60;
        BigInteger milliseconds = seconds * 1000;
        BigInteger microseconds = milliseconds * 1000;
        BigInteger nanoseconds = microseconds * 1000;
        

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}

