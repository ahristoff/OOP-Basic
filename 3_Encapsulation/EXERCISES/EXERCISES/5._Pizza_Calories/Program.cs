using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {       
        try
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Dough":
                        var dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
                        Console.WriteLine($"{dough.GetFlourCalories():f2}");
                        break;

                    case "Topping":
                        var topping = new Topping(tokens[1], double.Parse(tokens[2]));
                        Console.WriteLine($"{topping.GetToppingCalories():f2}");
                        break;

                    case "Pizza":
                        MakePizza(tokens);
                        return;
                }

                input = Console.ReadLine();
            }       
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void MakePizza(string[] tokens)
    {
        //pizz Name
        var pizzaName = tokens[1];

        // Dough
        var doughInfo = Console.ReadLine().Split(' ');
        var dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));

        //  toppings     
        var toppings = new List<Topping>();

        var toppingsInfo = Console.ReadLine();

        while (toppingsInfo != "END")
        {
            var topInfo = toppingsInfo.Split(' ');
            var topping = new Topping(topInfo[1], double.Parse(topInfo[2]));

            toppings.Add(topping);

            toppingsInfo = Console.ReadLine();
        }

        var pizza = new Pizza(pizzaName, dough, toppings);

        Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():f2} Calories.");       
    }
}

