using System;

public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private double weight;

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        FlourType = flourType;
        BakingTechnique = bakingTechnique;
        Weight = weight;
    }

    public double Weight
    {
        get { return weight; }
        private set
        {
            if (value < 1 || value > 200 )
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            weight = value;
        }
    }

    public string BakingTechnique
    {
        get { return bakingTechnique; }
        private set
        {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            bakingTechnique = value;
        }
    }

    public string FlourType
    {
        get { return flourType; }
        private set
        {
            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            flourType = value;
        }       
    }

    public double GetFlourCalories()
    {
        return 2 * Weight * GetFlourType() * GetBakingTechnique();
    }

    private double GetFlourType()
    {
        if (FlourType.ToLower() == "white")
        {
            return 1.5;
        }
        return 1.0;
    }

    private double GetBakingTechnique()
    {
        if (BakingTechnique.ToLower() == "crispy")
        {
            return 0.9;
        }

        else if (BakingTechnique.ToLower() == "chewy")
        {
            return 1.1;
        }

        return 1.0;
    }
}
