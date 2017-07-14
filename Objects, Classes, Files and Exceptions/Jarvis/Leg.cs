using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Leg
{
    public int EnergyConsumption { get; set; }
    public int Strength { get; set; }
    public int Speed { get; set; }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result = result.Append("#Leg:\n")
            .Append(string.Format($"###Energy consumption: {EnergyConsumption}\n"))
            .Append(string.Format($"###Strength: {Strength}\n"))
            .Append(string.Format($"###Speed: {Speed}\n"));

        return result.ToString();
    }
}
