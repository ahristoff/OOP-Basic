using System;

class Program
{
    static void Main()
    {
        var input1 = Console.ReadLine().Split();
        var input2 = Console.ReadLine().Split();
        var input3 = Console.ReadLine().Split();

        var car = new Car(CheckFuelQuantity(input1), double.Parse(input1[2]), double.Parse(input1[3]));
        var truck = new Truck(CheckFuelQuantity(input2), double.Parse(input2[2]), double.Parse(input2[3]));
        var bus = new Bus(CheckFuelQuantity(input3), double.Parse(input3[2]), double.Parse(input3[3]));

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
            else if (com[1] == "Bus")
            {

                if (com[0] == "Drive")
                {
                    bus.Drive(double.Parse(com[2]));
                }

                else if (com[0] == "Refuel")
                {
                    bus.Refuel(double.Parse(com[2]));
                }

                else if (com[0] == "DriveEmpty")
                {
                    bus.DriveEmpty(double.Parse(com[2]));
                }
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }

    private static double CheckFuelQuantity(string[] inputs)
    {
        var fuelQuantity = double.Parse(inputs[1]);

        if (fuelQuantity > double.Parse(inputs[3]))
        {
            return 0;
        }

        else
        {
            return fuelQuantity;
        }
    }
}

