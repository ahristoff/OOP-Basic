using System;
using System.Collections.Generic;

namespace _7.Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
              
                if (!dict.ContainsKey(car.Model))
                {
                    dict[car.Model] = car;
                }
            }

            var command = Console.ReadLine();

            while (command != "End")
            {
                var line = command.Split();

                if (dict.ContainsKey(line[1]))
                {
                    var car = dict[line[1]];
                    car.Drive(double.Parse(line[2]));
                }
                
                command = Console.ReadLine();
            }

            foreach (var x in dict)
            {
                Console.WriteLine(x.Value.ToString());
            }
        }
    }
}
