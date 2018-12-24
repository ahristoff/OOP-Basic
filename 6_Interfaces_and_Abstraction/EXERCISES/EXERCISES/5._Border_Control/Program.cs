using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {

        var command = Console.ReadLine();

        var citizens = new List<Citizen>();
        var robots = new List<Robot>();

        while (command != "End")
        {
            var com = command.Split();

            if (com.Length == 2)
            {
                var model = com[0];
                var id = com[1];

                var robot = new Robot(model, id);
                robots.Add(robot);
            }

            else if (com.Length == 3)
            {
                var name = com[0];
                var age = int.Parse(com[1]);
                var id = com[2];

                var citizen = new Citizen(name, age, id);
                citizens.Add(citizen);
            }

            command = Console.ReadLine();
        }

        var endNum = Console.ReadLine();

        Print(robots, citizens, endNum);
    }

    private static void Print(List<Robot> robots, List<Citizen> citizens, string endNum)
    {
        foreach (var x in robots)
        {

            if (x.ValidateId(endNum, x.Id) != "r")
            {
                Console.WriteLine(x.ValidateId(endNum, x.Id));
            }
        }

        foreach (var x in citizens)
        {

            if (x.ValidateId(endNum, x.Id) != "c")
            {
                Console.WriteLine(x.ValidateId(endNum, x.Id));
            }
        }
    }
}

