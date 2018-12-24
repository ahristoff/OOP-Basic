using System;

public abstract class Vehicle
{
   
    public Vehicle(double fuelQuantity, double fuelConsumation)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumation = fuelConsumation;        
    }
   
    public double FuelConsumation { get; set; }
   
    public double FuelQuantity { get; set; }

    public virtual void Drive(double distance)
    {
        if (distance <= FuelQuantity / FuelConsumation)
        {
            FuelQuantity -= distance * FuelConsumation;

            Console.WriteLine($"{GetType().Name} travelled {distance} km");
        }

        else
        {
            Console.WriteLine($"{GetType().Name} needs refueling");
        }
    }

    public virtual void Refuel(double liters)
    {
        FuelQuantity += liters;
    }
   
    public override string ToString()
    {
        return $"{GetType().Name}: {FuelQuantity:f2}";
    }
}

