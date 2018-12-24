using System;

 class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise 1");
        var dog = new Dog();
        dog.Eat();
        dog.Bark();
        Console.WriteLine();

        Console.WriteLine("Exercise 2");
        var puppy = new Puppy();
        puppy.Eat();
        puppy.Bark();
        puppy.Weep();
        Console.WriteLine();

        Console.WriteLine("Exercise 3");
        dog.Eat();
        dog.Bark();
        var cat = new Cat();
        cat.Eat();
        cat.Meow();     
    }
}

