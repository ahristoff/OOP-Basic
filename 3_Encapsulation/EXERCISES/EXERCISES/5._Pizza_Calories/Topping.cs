using System;

public class Topping
{
    private string type;
    private double weight;

    public Topping(string type, double weight)
    {
        Type = type;
        Weight = weight;
    }

    public double Weight
    {
        get { return weight; }
        private set
        {
            if (value < 1 || value > 50)
            {
                throw new ArgumentException($"{Type} weight should be in the range [1..50].");
            }
            weight = value;
        }
    }

    public string Type
    {
        get { return type; }
        private set
        {
            if (value.ToLower() != "meat" 
                && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            type = value;
        }
    }

    public double GetToppingCalories()
    {
        return 2 * GetTypeModifier() * Weight;
    }

    private double GetTypeModifier()
    {
        if (type.ToLower() == "meat")
        {
            return 1.2;
        }

        else if (type.ToLower() == "veggies")
        {
            return 0.8;
        }

        else if (type.ToLower() == "cheese")
        {
            return 1.1;
        }

        return 0.9;
    }
}
