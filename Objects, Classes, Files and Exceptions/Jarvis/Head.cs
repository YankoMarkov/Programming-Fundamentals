using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Head
{
    public int EnergyConsumption { get; set; }
    public int IQ { get; set; }
    public string SkinMaterial { get; set; }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result = result.Append("#Head:\n")
            .Append(string.Format($"###Energy consumption: {EnergyConsumption}\n"))
            .Append(string.Format($"###IQ: {IQ}\n"))
            .Append(string.Format($"###Skin material: {SkinMaterial}\n"));

        return result.ToString();
    }
}

