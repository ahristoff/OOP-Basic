using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var listCar = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {               
                var com = Console.ReadLine().Split(" ").ToList();
            
                var car = new Car();
                car.Model = com[0];
                car.Engine = new Engine(int.Parse(com[1]), int.Parse(com[2]));
                car.Cargo = new Cargo(int.Parse(com[3]), com[4]);
               
                for (int j = 0; j < 8; j = j + 2)
                {
                    car.Tires.Add(new Tire(double.Parse(com[5 + j]), int.Parse(com[6 + j]))); 
                }               

                listCar.Add(car);
            }

            var command = Console.ReadLine();

            if (command == "fragile")
            {
                var car = listCar.Where(c => c.IsFragile()).ToList();

                for (int i = 0; i < car.Count; i++)
                {
                    Console.WriteLine($"{car[i].Model}");
                }
            }

            else if (command == "flamable")
            {
                var car = listCar.Where(c => c.IsFlamable()).ToList();

                for (int i = 0; i < car.Count; i++)
                {
                    Console.WriteLine($"{car[i].Model}");
                }
            }                      
        }
    }
}
