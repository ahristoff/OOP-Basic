using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            try
            {              
                people = GetPeople();
                var products = GetProduct();

                BuyProducts(people, products);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            PrintBuiersWithProducts(people);           
        }

        private static void PrintBuiersWithProducts(List<Person> people)
        {
            foreach (var x in people)
            {
                var personBag = x.BagOfProducts;

                if (personBag.Count != 0)
                {
                    Console.WriteLine($"{x.Name} - {string.Join(", ", x.BagOfProducts.Select(c => c.Name))}");
                }

                else
                {
                    Console.WriteLine($"{x.Name} - Nothing bought");
                }
            }
        }

        private static void BuyProducts(List<Person> people, List<Product> products)
        {
            var command = Console.ReadLine();

            while (command != "END")
            {
                var com = command.Split();
                var personName = com[0];
                var productName = com[1];

                var buyer = people.FirstOrDefault(c => c.Name == personName);
                var purchase = products.FirstOrDefault(c => c.Name == productName);

                try
                {
                    buyer.BuyProduct(purchase);

                    Console.WriteLine($"{buyer.Name} bought {purchase.Name}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine();
            }
        }

        private static List<Product> GetProduct()
        {
            var products = new List<Product>();

            var line2 = Console.ReadLine().Split(new string[] { "=", ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < line2.Count; i = i + 2)
            {
                products.Add(new Product(line2[i], decimal.Parse(line2[i + 1])));
            }

            return products;
        }

        private static List<Person> GetPeople()
        {
            var people = new List<Person>();

            var line1 = Console.ReadLine().Split(new string[] { "=", ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < line1.Count; i = i + 2)
            {
                people.Add(new Person(line1[i], decimal.Parse(line1[i + 1])));
            }

            return people;
        }
    }
}
