using System;

public class Dog: Animal
{

    public override void Eat()
    {
        Console.WriteLine("the dog eat meat");
    }

    public void Bark()
    {
        Console.WriteLine("barking ...");
    }
}
