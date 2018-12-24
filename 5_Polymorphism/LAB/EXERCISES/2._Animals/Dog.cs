using System;

public class Dog: Animal
{
    public Dog(string name, string favouriteFood)
        : base(name, favouriteFood)
    {
    }

    public sealed override string ExplainMyself()
    {
        return base.ExplainMyself()+ Environment.NewLine + "DJAAF";
    }
}

