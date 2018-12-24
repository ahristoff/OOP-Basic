
public class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    {
        ProducingSound = "ROAR!!!";
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
            return weight + (1.00 * foodQuantity);
        }

        return weight;
    }
}

