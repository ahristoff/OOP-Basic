using System;

namespace _3._Ferrari
{
    public class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            IFerrari person = new Ferrari(name);

            Console.WriteLine(person.ToString());
        }
    }
}
