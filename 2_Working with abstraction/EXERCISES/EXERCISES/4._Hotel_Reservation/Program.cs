using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Hotel_Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

            var priceCalculator = new PriceCalculator(command);

            var totalPrice = priceCalculator.CalculatePrice();

            Console.WriteLine(totalPrice);
        }
    }
}
