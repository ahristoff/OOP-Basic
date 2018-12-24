using System.Text;

class Car
{ 
    public Car(string model, Engine engine, string weight = "n/a", string color = "n/a")
    {
        Model = model;
        Engine = engine;
        Weight = weight;
        Color = color;
    }

    public string Color { get; set; }
   
    public string Weight { get; set; }
   
    public Engine Engine { get; set; }

    public string Model { get; set; }
   
    public override string ToString()
    {
        var sb = new StringBuilder()
            .AppendLine($"{Model}:")
            .AppendLine($"  {Engine.Model}:")
            .AppendLine($"    Power: {Engine.Power}")
            .AppendLine($"    Displacement: {Engine.Displacement}")
            .AppendLine($"    Efficiency: {Engine.Efficiency}")
            .AppendLine($"  Weight: {Weight}")
            .AppendLine($"  Color: {Color}");

        return sb.ToString();
    }
}

