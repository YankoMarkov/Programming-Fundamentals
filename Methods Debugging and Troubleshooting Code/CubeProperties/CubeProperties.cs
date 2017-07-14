using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CubeProperties
{
    public static void Main(string[] args)
    {
        var cubeSide = double.Parse(Console.ReadLine());
        var command = Console.ReadLine();

        switch (command)
        {
            case "face":
                Console.WriteLine($"{GetCubFace(cubeSide):F2}");
                break;
            case "space":
                Console.WriteLine($"{GetCubeSpace(cubeSide):F2}");
                break;
            case "volume":
                Console.WriteLine($"{GetCubeVolume(cubeSide):F2}");
                break;
            case "area":
                Console.WriteLine($"{GetCubeArea(cubeSide):F2}");
                break;
            default:
                break;
        }
    }

    public static double GetCubFace(double cubeSide)
    {
        return Math.Sqrt(2 * Math.Pow(cubeSide, 2));
    }

    public static double GetCubeSpace(double cubeSide)
    {
        return Math.Sqrt(3 * Math.Pow(cubeSide, 2));
    }

    public static double GetCubeArea(double cubeSide)
    {
        return 6 * Math.Pow(cubeSide, 2);
    }

    public static double GetCubeVolume(double cubeSide)
    {
        return Math.Pow(cubeSide, 3);
    }
}

