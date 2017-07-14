using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Horsepower { get; set; }
}

class VehicleCatalogue
{
    static void Main(string[] args)
    {
        string inputs = null;
        var vehicles = AddVehicle(inputs);
        string models = null;

        while ((models = Console.ReadLine()) != "Close the Catalogue")
        {
            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].Model == models)
                {
                    Console.WriteLine($"Type: {vehicles[i].Type}");
                    Console.WriteLine($"Model: {vehicles[i].Model}");
                    Console.WriteLine($"Color: {vehicles[i].Color}");
                    Console.WriteLine($"Horsepower: {vehicles[i].Horsepower}");
                }
            }
        }
        TotalSumHorspowers(vehicles);
    }

    private static List<Vehicle> AddVehicle(string inputs)
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        while ((inputs = Console.ReadLine()) != "End")
        {
            var input = inputs.ToLower().Split().ToArray();
            var type = input[0].First().ToString().ToUpper() + string.Join("", input[0].Skip(1));
            var model = input[1].First().ToString().ToUpper() + input[1].Substring(1);
            var color = input[2];
            var horsepower = int.Parse(input[3]);

            Vehicle vehicle = new Vehicle();

            vehicle.Type = type;
            vehicle.Model = model;
            vehicle.Color = color;
            vehicle.Horsepower = horsepower;

            vehicles.Add(vehicle);
        }
        return vehicles;
    }

    private static void TotalSumHorspowers(List<Vehicle> vehicles)
    {
        var carCount = 0;
        var truckCount = 0;
        double sumCarsHorspowers = 0;
        double sumTruckHorspowers = 0;

        foreach (var item in vehicles)
        {
            if (item.Type == "Car")
            {
                sumCarsHorspowers += item.Horsepower;
                carCount++;
            }
            else if (item.Type == "Truck")
            {
                sumTruckHorspowers += item.Horsepower;
                truckCount++;
            }
        }
        double totalCarsHorspower = sumCarsHorspowers / carCount;
        double totalTrucksHorspower = sumTruckHorspowers / truckCount;
        if (sumCarsHorspowers != 0)
        {
            Console.WriteLine($"Cars have average horsepower of: {totalCarsHorspower:f2}.");
        }
        else
        {
            Console.WriteLine("Cars have average horsepower of: 0.00.");
        }
        if (sumTruckHorspowers != 0)
        {
            Console.WriteLine($"Trucks have average horsepower of: {totalTrucksHorspower:f2}.");
        }
        else
        {
            Console.WriteLine("Trucks have average horsepower of: 0.00.");

        }

    }
}

