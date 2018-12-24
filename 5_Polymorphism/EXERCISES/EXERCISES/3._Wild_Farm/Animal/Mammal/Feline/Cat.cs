
public class Cat:Feline
{
    public Cat(string name, double weight, string livingRegion, string breed) 
        : base(name, weight, livingRegion, breed)
    {
        ProducingSound = "Meow";
    }
    
    public override bool IsEat(string food)
    {

        if (food == "Vegetable" || food == "Meat")
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
            return weight + (0.30 * foodQuantity);
        }

        return weight;
    }
}

