using System;

class Car
{
    public Car(string model, double fuelAmounnt, double fuelConsumption, double distanceTraveled = 0)
    {
        this.Model = model;
        this.FuelAmount = fuelAmounnt;
        this.FuelConsumption = fuelConsumption;
        this.DistanceTraveled = distanceTraveled;
    }

    public string Model { get; set; }

    public double FuelAmount { get; set; }

    public double FuelConsumption { get; set; }
   
    public double DistanceTraveled { get; set; }
   
    public void Drive(double distance)
    {
        if (FuelAmount >= distance * FuelConsumption)
        {
            DistanceTraveled += distance;
            FuelAmount -= distance * FuelConsumption;
        }

        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

    public override string ToString()
    {
        return $"{Model} {FuelAmount:f2} {DistanceTraveled}";
    }
}

