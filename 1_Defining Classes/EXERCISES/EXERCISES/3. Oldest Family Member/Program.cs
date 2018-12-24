using System;
using System.Linq;


namespace _3._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                var name = input[0];
                var age = int.Parse(input[1]);

                var person = new Person(age, name);
                            
                family.AddMember(person);
            }
          
            var oldest = family.GetOldestMember();

            Console.WriteLine($"{oldest.Name} {oldest.Age}");          
        }
    }
}
