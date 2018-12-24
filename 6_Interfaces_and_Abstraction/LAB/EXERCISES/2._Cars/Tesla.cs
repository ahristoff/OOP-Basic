using System.Text;

public class Tesla:ICar, IElectricCar
{
   
    public Tesla(string model, string color, int batteries)
    {
        Model = model;
        Color = color;
        Batteries = batteries;
    }

    public string Model { get; private set; }

    public string Color { get; private set; }

    public int Batteries { get; private set; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{Color} {GetType().Name} {Model} with {Batteries} Batteries");
        sb.AppendLine($"{Start()}");
        sb.Append($"{Stop()}");

        return sb.ToString();
    }
}

