using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        var command = Console.ReadLine();

        var beings = new List<IBeing>();

        while (command != "End")
        {
            var com = command.Split();

            if (com[0] == "Citizen")
            {
                IBeing citizen = new Citizen(com[1], int.Parse(com[2]), com[3], com[4]);
                beings.Add(citizen);
            }

            else if (com[0] == "Pet")
            {
                IBeing pet = new Pet(com[1], com[2]);
                beings.Add(pet);
            }

            else if (com[0] == "Robot")
            {
                var robot = new Robot(com[1], com[2]);
            }

            command = Console.ReadLine();
        }

        var date = Console.ReadLine();

        Print(beings, date);
    }

    private static void Print(List<IBeing> beings, string date)
    {
        foreach (var x in beings)
        {
            var birtday = x.Birthdate.Split("/");

            if (birtday[2] == date)
            {
                Console.WriteLine(x.Birthdate);
            }
        }
    }
}

