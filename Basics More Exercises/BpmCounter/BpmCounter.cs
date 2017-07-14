using System;
using System.Collections.Generic;
using System.Linq;

public class bpmCounter
{
    public static void Main(string[] args)
    {
        var beatsPerMinute = int.Parse(Console.ReadLine());
        var numberOfBeats = double.Parse(Console.ReadLine());

        var bars = numberOfBeats / 4;
        var time = (numberOfBeats / beatsPerMinute) * 60;
        var minutes = (int)time / 60;
        var seconds = (int)time % 60;
        Console.WriteLine($"{Math.Round(bars, 1)} bars - {minutes}m {seconds}s");
    }
}

