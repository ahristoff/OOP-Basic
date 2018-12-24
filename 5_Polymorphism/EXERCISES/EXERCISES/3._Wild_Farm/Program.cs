using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        Animal type = null;

        var countInputLines = 0;

        var animals = new List<Animal>();

        while (input != "End")
        {
            var com = input.Split();

            if (countInputLines % 2 == 0)
            {
                type = Animals(com, type);
            }

            else
            {
                Foods(com, type);

                animals.Add(type);
            }

            countInputLines++;

            input = Console.ReadLine();
        }

        Print(animals);
    }

    private static void Print(List<Animal> animals)
    {

        foreach (var x in animals)
        {
            Console.WriteLine(x.ToString());
        }
    }

    private static void Foods(string[] com, Animal type)
    {
        var foodType = com[0];

        var foodQuantity = double.Parse(com[1]);

        if (type.IsEat(foodType) == false)
        {
            Console.WriteLine($"{type.GetType().Name} does not eat {foodType}!");
        }

        type.FoodEat = type.AnimalWeight(type.Weight, foodQuantity, foodType);

        type.FoodQvn = type.FoodEaten(foodType, foodQuantity);
    }

    private static Animal Animals(string[] com, Animal type)
    {

        if (com[0] == "Hen" || com[0] == "Owl")
        {
            var animalName = com[1];
            var animalWeight = double.Parse(com[2]);
            var wingSize = double.Parse(com[3]);

            if (com[0] == "Hen")
            {
                type = new Hen(animalName, animalWeight, wingSize);

                Console.WriteLine($"{((Hen)type).ProducingSound}");
            }

            else if (com[0] == "Owl")
            {
                type = new Owl(animalName, animalWeight, wingSize);

                Console.WriteLine($"{((Owl)type).ProducingSound}");
            }
        }

        else if (com[0] == "Cat" || com[0] == "Tiger")
        {
            var animalName = com[1];
            var animalWeight = double.Parse(com[2]);
            var livingRegion = com[3];
            var breed = com[4];

            if (com[0] == "Cat")
            {
                type = new Cat(animalName, animalWeight, livingRegion, breed);

                Console.WriteLine($"{((Cat)type).ProducingSound}");
            }

            else if (com[0] == "Tiger")
            {
                type = new Tiger(animalName, animalWeight, livingRegion, breed);

                Console.WriteLine($"{((Tiger)type).ProducingSound}");
            }
        }

        else if (com[0] == "Mouse" || com[0] == "Dog")
        {
            var animalName = com[1];
            var animalWeight = double.Parse(com[2]);
            var livingRegion = com[3];

            if (com[0] == "Mouse")
            {
                type = new Mouse(animalName, animalWeight, livingRegion);

                Console.WriteLine($"{((Mouse)type).ProducingSound}");
            }
            else if (com[0] == "Dog")
            {
                type = new Dog(animalName, animalWeight, livingRegion);

                Console.WriteLine($"{type.ProducingSound}");
            }
        }

        return type;
    }
}

