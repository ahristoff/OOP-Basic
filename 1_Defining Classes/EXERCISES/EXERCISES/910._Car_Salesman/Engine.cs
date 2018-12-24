
class Engine
{
    public Engine(string model, int power, string displacement = "n/a", string efficiency = "n/a")
    {
        Model = model;
        Power = power;
        Displacement = displacement;
        Efficiency = efficiency;
    }

    public string Efficiency { get; set; }
  
    public string Displacement { get; set; }
  
    public int Power { get; set; }
   
    public string Model { get; set; }  
}

