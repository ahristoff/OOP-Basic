
public class Car: Vehicle
{

    public Car(double fuelQuantity, double fuelConsumation, double tankCapacity) 
        : base(fuelQuantity, fuelConsumation, tankCapacity)
    {
        FuelConsumation = FuelConsumation + 0.9;
    }
}


