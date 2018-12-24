
public class Hen: Bird
{
    public Hen(string name, double weight, double wingSize) 
        : base(name, weight, wingSize)
    {
        ProducingSound = "Cluck";
    }

    public override bool IsEat(string food)
    {
        return true;
    }
   
    public override double AnimalWeight(double weight, double foodQuantity, string foodType)
    {
        if (IsEat(foodType))
        {
            return weight + (0.35 * foodQuantity);
        }
        return weight;
    }
}

