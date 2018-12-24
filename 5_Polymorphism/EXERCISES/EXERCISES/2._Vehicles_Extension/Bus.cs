using System;

public class Bus: Vehicle
{

    public Bus(double fuelQuantity, double fuelConsumation, double tankCapacity) : base(fuelQuantity, fuelConsumation, tankCapacity)
    {
        FuelConsumation = FuelConsumation + 1.4;
    }

    public void DriveEmpty(double distance)
    {

        if (distance <= FuelQuantity / (FuelConsumation - 1.4))
        {
            FuelQuantity -= distance * (FuelConsumation - 1.4);

            Console.WriteLine($"{GetType().Name} travelled {distance} km");
        }

        else
        {
            Console.WriteLine($"{GetType().Name} needs refueling");
        }
    }
}

