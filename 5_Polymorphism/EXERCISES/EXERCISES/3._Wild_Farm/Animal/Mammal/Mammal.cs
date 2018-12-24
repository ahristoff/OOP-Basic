using System.Text;

public abstract class Mammal: Animal
{

    public Mammal(string name, double weight, string livingRegion) 
        : base(name, weight)
    {
        LivingRegion = livingRegion;
    }

    public string LivingRegion { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.Append($"{GetType().Name} [{Name}, {FoodEat}, {LivingRegion}, {FoodQvn}]");

        return sb.ToString();
    }
}

