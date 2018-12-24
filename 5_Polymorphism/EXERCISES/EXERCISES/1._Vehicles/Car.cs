
public class Car : Vehicle
{

    public Car(double fuelQuantity, double fuelConsumation) 
        : base(fuelQuantity, fuelConsumation)
    {
        FuelConsumation = FuelConsumation + 0.9;       
    }           
}

