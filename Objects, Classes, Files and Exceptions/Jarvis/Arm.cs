using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Arm
{
    public int EnergyConsumption { get; set; }
    public int ReachDistance { get; set; }
    public int CountFingers { get; set; }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result = result.Append("#Arm:\n")
            .Append(string.Format($"###Energy consumption: {EnergyConsumption}\n"))
            .Append(string.Format($"###Reach: {ReachDistance}\n"))
            .Append(string.Format($"###Fingers: {CountFingers}\n"));

        return result.ToString();
    }
}