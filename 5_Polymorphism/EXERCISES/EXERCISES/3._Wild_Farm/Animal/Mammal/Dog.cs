
public class Dog: Mammal
{
    public Dog(string name, double weight, string livingRegion) 
        : base(name, weight, livingRegion)
    {
        ProducingSound = "Woof!";
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
            return weight + (0.40 * foodQuantity);
        }
        return weight;
    }
}

