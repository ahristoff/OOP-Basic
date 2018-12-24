using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Car_Salesman
{
    class Program
    {      
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var engines = GetEngine(n);

            int m = int.Parse(Console.ReadLine());
            var cars = GetCar(m, engines);

            for (int i = 0; i < cars.Count; i++)
            {
                Console.Write(cars[i]);
            }
        }

        private static List<Car> GetCar(int m, List<Engine>engines)
        {
            var cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {               
                var input = Console.ReadLine().Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries);

                var car = new Car(input[0], engines.FirstOrDefault(c => c.Model == input[1]));

                if (input.Length == 3)
                {
                    int num;
                    var IsNumber = int.TryParse(input[2], out num);

                    if (IsNumber)
                    {
                        car.Weight = input[2];
                    }

                    else
                    {
                        car.Color = input[2];
                    }
                }

                else if (input.Length == 4)
                {
                    car.Weight = input[2];
                    car.Color = input[3];
                }

                cars.Add(car);
            }

            return cars;
        }

        private static List<Engine> GetEngine(int n)
        {
            var engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                var engine = new Engine(input[0], int.Parse(input[1]));

                if (input.Length == 3)
                {
                    int num;
                    bool isNumber = int.TryParse(input[2], out num);

                    if (isNumber)
                    {
                        engine.Displacement = input[2];
                    }

                    else
                    {
                        engine.Efficiency = input[2];
                    }
                }

                else if (input.Length == 4)
                {
                    engine.Displacement = input[2];
                    engine.Efficiency = input[3];
                }

                engines.Add(engine);
            }

            return engines;
        }
    }
}
