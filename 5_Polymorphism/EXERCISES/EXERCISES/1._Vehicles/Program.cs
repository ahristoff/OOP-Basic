using System;

public class Program
{
    static void Main()
    {
        var input1 = Console.ReadLine().Split();
        var input2 = Console.ReadLine().Split();

        var car = new Car(double.Parse(input1[1]), double.Parse(input1[2]));
        var truck = new Truck(double.Parse(input2[1]), double.Parse(input2[2]));

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var com = Console.ReadLine().Split();
            if (com[1] == "Car")
            {
                if (com[0] == "Drive")
                {
                    car.Drive(double.Parse(com[2]));
                }
                else if (com[0] == "Refuel")
                {
                    car.Refuel(double.Parse(com[2]));
                }
            }
            else if (com[1] == "Truck")
            {
                if (com[0] == "Drive")
                {
                    truck.Drive(double.Parse(com[2]));
                }
                else if (com[0] == "Refuel")
                {
                    truck.Refuel(double.Parse(com[2]));
                }
            }
        }
        Console.WriteLine(car);
        Console.WriteLine(truck);
    }
}

