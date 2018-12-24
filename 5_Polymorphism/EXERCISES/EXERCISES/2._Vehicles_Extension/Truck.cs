using System;

public class Truck: Vehicle
{

    public Truck(double fuelQuantity, double fuelConsumation, double tankCapacity) 
        : base(fuelQuantity, fuelConsumation, tankCapacity)
    {
        FuelConsumation = fuelConsumation + 1.6;
    }

    public override void Refuel(double liters)
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
            FuelQuantity += liters * 0.95;
        }
    }
}
