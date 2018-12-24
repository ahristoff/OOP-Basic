using System.Text;

public abstract class Feline: Mammal
{

    public Feline(string name, double weight, string livingRegion, string breed) 
        : base(name, weight, livingRegion)
    {
        Breed = breed;
    }

    public string Breed { get; set; }
   
    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.Append($"{GetType().Name} [{Name}, {Breed}, {FoodEat}, {LivingRegion}, {FoodQvn}]");

        return sb.ToString();
    }
}

