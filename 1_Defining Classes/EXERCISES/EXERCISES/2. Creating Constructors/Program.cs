using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _2._Creating_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            var person2 = new Person(18);
            var person3 = new Person("Stamat", 43);

            Console.WriteLine($"{person1.Name} - {person1.Age}");
            Console.WriteLine($"{person2.Name} - {person2.Age}");
            Console.WriteLine($"{person3.Name} - {person3.Age}");
        }
    }
}
