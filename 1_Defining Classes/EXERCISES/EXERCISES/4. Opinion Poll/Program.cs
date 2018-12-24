using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _4._Opinion_Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                var name = input[0];
                var age = int.Parse(input[1]);

                var person = new Person(age, name);
                people.AddMember(person);
            }

            var output = people.MoreThenThirty();

            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine($"{output[i].Name} - {output[i].Age}");
            }
        }
    }
}
