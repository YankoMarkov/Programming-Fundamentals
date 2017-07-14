using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Jarvis
{
    public long Energy { get; set; }
    public Head Head { get; set; }
    public Torso Torso { get; set; }
    public List<Arm> Arms { get; set; }
    public List<Leg> Legs { get; set; }

    public void AddHead(Head headInput)
    {
        if (Head == null || headInput.EnergyConsumption < Head.EnergyConsumption)
        {
            Head = headInput;
        }
    }

    public void AddTorso(Torso torsoInput)
    {
        if (Torso == null || torsoInput.EnergyConsumption < Torso.EnergyConsumption)
        {
            Torso = torsoInput;
        }
    }

    public void AddArms(Arm armInput)
    {
        if (Arms == null)
        {
            Arms = new List<Arm>();
        }
        if (Arms.Count < 2)
        {
            Arms.Add(armInput);
        }
        else if(Arms.Any(s => s.EnergyConsumption > armInput.EnergyConsumption))
        {
            Arms.RemoveAt(0);
            Arms.Add(armInput);
        }
    }

    public void AddLegs(Leg legInput)
    {
        if (Legs == null)
        {
            Legs = new List<Leg>();
        }
        if (Legs.Count < 2)
        {
            Legs.Add(legInput);
        }
        else if (Legs.Any(s => s.EnergyConsumption > legInput.EnergyConsumption))
        {
            Legs.RemoveAt(0);
            Legs.Add(legInput);
        }
    }

    public override string ToString()
    {
        if (Head == null || Torso == null || Arms.Count < 2 || Legs.Count < 2)
        {
            return "We need more parts!";
        }
        long totalEnergy = 0;
        totalEnergy += Head.EnergyConsumption;
        totalEnergy += Torso.EnergyConsumption;
        totalEnergy += Arms.Select(s => long.Parse(s.EnergyConsumption.ToString())).Sum();
        totalEnergy += Legs.Select(s => long.Parse(s.EnergyConsumption.ToString())).Sum();

        if (totalEnergy > Energy)
        {
            return "We need more power!";
        }
        StringBuilder result = new StringBuilder();
        result = result.Append("Jarvis:\n")
            .Append(Head.ToString())
            .Append(Torso.ToString());
        foreach (var item in Arms.OrderBy(s => s.EnergyConsumption))
        {
            result = result.Append(item.ToString());
        }
        foreach (var item in Legs.OrderBy(s => s.EnergyConsumption))
        {
            result = result.Append(item.ToString());
        }
        return result.ToString();
    }
}

