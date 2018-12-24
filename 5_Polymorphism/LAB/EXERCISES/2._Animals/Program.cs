using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Animal dog = new Dog("Gosho", "Meat");
        Animal cat = new Cat("Pesho", "Whiskas");

        var listOfAnimals = new List<Animal>();

        listOfAnimals.Add(cat);
        listOfAnimals.Add(dog);

        Print(listOfAnimals);
    }

    private static void Print(IList<Animal> animals)
    {
        foreach (var x in animals)
        {
            Console.WriteLine(x.ExplainMyself());
        }
    }
}

