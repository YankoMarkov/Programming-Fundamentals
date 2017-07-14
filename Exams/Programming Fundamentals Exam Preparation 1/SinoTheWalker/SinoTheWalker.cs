using System;

public class SinoTheWalker
{
    public static void Main()
    {
        var timeLeave = Console.ReadLine().Split(':');
        var hoursInSecond = int.Parse(timeLeave[0]) * 60 * 60;
        var minutesInSeconds = int.Parse(timeLeave[1]) * 60;
        var second = int.Parse(timeLeave[2]);
        var numberOfSteps = int.Parse(Console.ReadLine());
        var timeInSecondsForStep = int.Parse(Console.ReadLine());

        ulong distance = (ulong)numberOfSteps * (ulong)timeInSecondsForStep;
        ulong totalTime = (ulong)hoursInSecond + (ulong)minutesInSeconds + (ulong)second + distance;
        var hours = (totalTime / (60 * 60)) % 24;
        var minutes = (totalTime / 60) % 60;
        var seconds = totalTime % 60;

        Console.WriteLine($"Time Arrival: {hours:D2}:{minutes:D2}:{seconds:D2}");
    }
}

