
class Tire
{
    public Tire(double tirePressure, int tireAge)
    {
        this.TireAge = tireAge;
        this.TirePressure = tirePressure;
    }

    public int TireAge { get; set; }
   
    public double TirePressure { get; set; }
}

