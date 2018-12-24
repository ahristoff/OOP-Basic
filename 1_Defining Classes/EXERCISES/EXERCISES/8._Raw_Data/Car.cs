using System.Collections.Generic;
using System.Linq;

class Car
{
    public Car()
    {
        Tires = new List<Tire>();
    }

    public List<Tire> Tires { get; set; }

    public Cargo Cargo { get; set; }

    public Engine Engine { get; set; }

    public string Model { get; set; }

    public bool IsFragile()
    {
        bool isFragile = Cargo.CargoType == "fragile" && Tires.Any(v => v.TirePressure < 1);
        return isFragile;
    }

    public bool IsFlamable()
    {
        bool isFlamable = Cargo.CargoType == "flamable" && Engine.EnginePower > 250;
        return isFlamable;
    }
}

