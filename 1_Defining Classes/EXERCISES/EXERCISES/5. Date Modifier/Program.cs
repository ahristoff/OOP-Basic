using System;

namespace _5._Date_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {         
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();
            Console.WriteLine(DateModifier.GetDateDifference(firstDate, secondDate));
        }
    }
}
