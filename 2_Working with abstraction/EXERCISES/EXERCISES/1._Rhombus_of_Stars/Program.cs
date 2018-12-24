using System;

namespace _1._Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var rombusSize = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rombusSize; i++)
            {
                PrintRow(rombusSize, i);
            }

            for (int i = rombusSize - 1; i > 0; i--)
            {
                PrintRow(rombusSize, i);
            }
        }

        private static void PrintRow(int rombusSize, int rowSize)
        {
            for (int i = 0; i < rombusSize - rowSize; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < rowSize; i++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}
