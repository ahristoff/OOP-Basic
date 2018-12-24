using System;

public abstract class Vehicle
{

    public Vehicle(double fuelQuantity, double fuelConsumation, double tankCapacity)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumation = fuelConsumation;
        TankCapacity = tankCapacity;
    }

    public double TankCapacity { get; set; }
   
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
        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }

        else if (liters > TankCapacity)
        {
            Console.WriteLine($"Cannot fit {liters} fuel in the tank");
        }

        else
        {
            FuelQuantity += liters;
        }       
    }

    public override string ToString()
    {
        return $"{GetType().Name}: {FuelQuantity:f2}";
    }
}
