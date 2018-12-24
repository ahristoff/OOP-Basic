using System;
using System.Collections.Generic;
using System.Linq;

class Pizza
{
    private string name;
    private Dough dough;
    private List<Topping> toppings;

    public Pizza(string name, Dough dough, List<Topping> toppings)
    {
        Name = name;
        Dough = dough;
        Toppings = toppings;
    }

    public List<Topping> Toppings
    {
        get { return toppings; }
        set
        {
            if (value.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings = value;
        }
    }

    public Dough Dough
    {
        get { return dough; }
        set { dough = value; }
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (value == "" || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            name = value;
        }
    }

    public double GetTotalCalories()
    {
        return Toppings.Sum(c => c.GetToppingCalories()) + Dough.GetFlourCalories();
    }
}