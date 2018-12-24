using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var bayers = new List<IBuyer>();

        for (int i = 0; i < n; i++)
        {
            var com = Console.ReadLine().Split();

            if (com.Length == 4)
            {
                var citizen = new Citizen(com[0], int.Parse(com[1]), com[2], com[3]);
                bayers.Add(citizen);
            }

            else if (com.Length == 3)
            {
                var rebel = new Rebel(com[0], int.Parse(com[1]), com[2]);
                bayers.Add(rebel);
            }
        }

        var comm = Console.ReadLine();

        var sum = 0;

        while (comm != "End")
        {
            if (bayers.Any(c => c.Name == comm))
            {
                sum += bayers.FirstOrDefault(c => c.Name == comm).BuyFood();
            }

            comm = Console.ReadLine();
        }

        Console.WriteLine(sum);
    }
}

