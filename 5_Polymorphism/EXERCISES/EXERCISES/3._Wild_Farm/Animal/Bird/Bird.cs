using System.Text;

public abstract class Bird: Animal
{

    public Bird(string name, double weight, double wingSize) 
        : base(name, weight)
    {
        WingSize = wingSize;
    }

    public double WingSize { get; set; }
   
    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.Append($"{GetType().Name} [{Name}, {WingSize}, {FoodEat}, {FoodQvn}]");  

        return sb.ToString();
    }
}

