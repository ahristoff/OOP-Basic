using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        DraftManager manager = new DraftManager();

        while (true)
        {
            var commandArgs = Console.ReadLine().Split().ToList();
            var command = commandArgs[0];
            commandArgs = commandArgs.Skip(1).ToList(); 

            if (command == "RegisterHarvester")
            {
                Console.WriteLine(manager.RegisterHarvester(commandArgs));
            }

            else if (command == "RegisterProvider")
            {
                Console.WriteLine(manager.RegisterProvider(commandArgs));
            }

            else if (command == "Day")
            {
                Console.WriteLine(manager.Day());
            }

            else if (command == "Mode")
            {
                Console.WriteLine(manager.Mode(commandArgs));
            }

            else if (command == "Check")
            {
                Console.WriteLine(manager.Check(commandArgs));
            }

            else if (command == "Shutdown")
            {
                Console.WriteLine(manager.ShutDown());
                break;
            }
        }
    }
}

