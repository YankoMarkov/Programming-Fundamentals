using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class JarvisMain
{
    static void Main(string[] args)
    {
        var jarvisPower = long.Parse(Console.ReadLine());
        string inputs = null;
        Jarvis jarvis = new Jarvis();
        jarvis.Energy = jarvisPower;

        while ((inputs = Console.ReadLine()) != "Assemble!")
        {
            var input = inputs.Split().ToArray();
            var typeOfComponent = input[0];
            var energyConsumption = int.Parse(input[1]);
            var property1 = input[2];
            var property2 = input[3];

            switch (typeOfComponent)
            {
                case "Head":
                    Head head = new Head();
                    head.EnergyConsumption = energyConsumption;
                    head.IQ = int.Parse(property1);
                    head.SkinMaterial = property2;
                    jarvis.AddHead(head);
                    break;
                case "Torso":
                    Torso torso = new Torso();
                    torso.EnergyConsumption = energyConsumption;
                    torso.ProcessorCentimeterSize = double.Parse(property1);
                    torso.HousingMaterial = property2;
                    jarvis.AddTorso(torso);
                    break;
                case "Arm":
                    Arm arm = new Arm();
                    arm.EnergyConsumption = energyConsumption;
                    arm.ReachDistance = int.Parse(property1);
                    arm.CountFingers = int.Parse(property2);
                    jarvis.AddArms(arm);
                    break;
                case "Leg":
                    Leg leg = new Leg();
                    leg.EnergyConsumption = energyConsumption;
                    leg.Strength = int.Parse(property1);
                    leg.Speed = int.Parse(property2);
                    jarvis.AddLegs(leg);
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(jarvis.ToString());
    }
}

