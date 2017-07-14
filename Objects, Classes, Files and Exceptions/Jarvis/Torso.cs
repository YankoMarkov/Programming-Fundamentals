using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Torso
{
    public int EnergyConsumption { get; set; }
    public double ProcessorCentimeterSize { get; set; }
    public string HousingMaterial { get; set; }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result = result.Append("#Torso:\n")
            .Append(string.Format($"###Energy consumption: {EnergyConsumption}\n"))
            .Append(string.Format($"###Processor size: {ProcessorCentimeterSize:f1}\n"))
            .Append(string.Format($"###Corpus material: {HousingMaterial}\n"));

        return result.ToString();
    }
}