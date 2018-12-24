using System;
using System.Collections.Generic;
using System.Linq;

namespace _912._Google
{
    class Program
    {
        static void Main(string[] args) 
        {
            var persons = new List<Person>();
            var command = Console.ReadLine();

            while (command != "End")
            {              
                var com = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var namePerson = com[0];              


                var person = persons.FirstOrDefault(c => c.Name == namePerson); 

                if (person == null)
                {
                    person = new Person(namePerson);
                }

                if (com[1] == "car")
                {
                    var model = com[2];
                    var speed = com[3];
                    person.Car = new Car(model, speed);

                }

                else if (com[1] =="company")
                {
                    var name = com[2];
                    var department = com[3];
                    var salary = com[4];

                    person.Company = new Company(name, department, salary);
                }

                else  if (com[1] == "pokemon")
                {
                    var name = com[2];
                    var type = com[3];

                    person.Pokemons.Add(new Pokemon(name, type));
                }

                else if (com[1] == "parents")
                {
                    var name = com[2];
                    var birthday = com[3];

                    person.Parents.Add(new Parents(name, birthday));
                }

                else if (com[1] == "children")
                {
                    var name = com[2];
                    var birthday = com[3];

                    person.Children.Add(new Children(name, birthday));
                }

                persons.Add(person);

                command = Console.ReadLine();
            }

            var personName = Console.ReadLine();

            var personality = persons.FirstOrDefault(c => c.Name == personName); 

            if (personality != null)
            {
                Console.WriteLine(personality);   
            }
        }
    }
}
