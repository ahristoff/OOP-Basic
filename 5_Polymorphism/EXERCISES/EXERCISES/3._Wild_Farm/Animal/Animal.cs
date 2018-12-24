
public abstract class Animal
{

    public Animal(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }

    public double FoodQvn { get; set; }

    public double FoodEat { get; set; }

    public double Weight { get; set; }
 
    public string Name { get; set; }

    public string ProducingSound { get; set; }

    public abstract bool IsEat(string food);

    public abstract double AnimalWeight(double weight, double foodQuantity, string foodType);

    public double FoodEaten(string foodType, double foodQuantity)
    {
        return IsEat(foodType) ? foodQuantity : 0;
    }
}

