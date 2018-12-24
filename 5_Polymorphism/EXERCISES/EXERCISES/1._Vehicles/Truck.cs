
public class Truck : Vehicle
{

    public Truck(double fuelQuantity, double fuelConsumation) 
        : base(fuelQuantity, fuelConsumation)
    {        
       FuelConsumation = fuelConsumation + 1.6;        
    }
  
    public override void Refuel(double liters)
    {       
        base.Refuel(liters * 0.95);
        //FuelQuantity += liters * 0.95;
    }
}

