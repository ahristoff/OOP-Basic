
public class Owl: Bird
{
    public Owl(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
    {
        ProducingSound = "Hoot Hoot";
    }

    public override bool IsEat(string food)
    {
        if (food == "Meat")
        {
            return true;
        }

        else
        {
            return false;
        }
    }
   
    public override double AnimalWeight(double weight, double foodQuantity, string foodType)
    {
        if (IsEat(foodType))
        {
            return weight + (0.25 * foodQuantity);
        }

        return weight;
    }
}

