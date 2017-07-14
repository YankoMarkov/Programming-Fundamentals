using System;

public class convertSpeedUnits
{
    public static void Main(string[] args)
    {
        var distance = int.Parse(Console.ReadLine());
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());
        var seconds = int.Parse(Console.ReadLine());
        
        var hoursInSeconds = hours * 60 * 60;
        var minutesInSeconds = minutes * 60;
        var totalInSeconds = hoursInSeconds + minutesInSeconds + seconds;
        var meterPerSeconds = (float) distance / (float) totalInSeconds;
        var kilometersPerHour = (meterPerSeconds * 60 * 60) / 1000;
        var milesPerHour = (meterPerSeconds * 60 * 60) / 1609;

        Console.WriteLine(meterPerSeconds);
        Console.WriteLine(kilometersPerHour);
        Console.WriteLine(milesPerHour);
    }
}

