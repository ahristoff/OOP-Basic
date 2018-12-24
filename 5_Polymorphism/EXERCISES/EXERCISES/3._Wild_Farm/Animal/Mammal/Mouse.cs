
public class Mouse: Mammal
{
    public Mouse(string name, double weight, string livingRegion) 
        : base(name, weight, livingRegion)
    {
        ProducingSound = "Squeak";
    }

    public override bool IsEat(string food)
    {
        if (food == "Vegetable" || food == "Fruit")
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
            return weight + (0.10 * foodQuantity);
        }

        return weight;
    }
}

