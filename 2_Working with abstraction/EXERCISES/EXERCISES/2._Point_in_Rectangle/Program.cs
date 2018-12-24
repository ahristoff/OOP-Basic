using System;
using System.Linq;

namespace _2._Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var coords = Console.ReadLine().Split().Select(int.Parse).ToList();

            var rectangle = new Rectangle(coords[0], coords[1], coords[2], coords[3]);

            var pointscount = int.Parse(Console.ReadLine());

            for (int i = 0; i < pointscount; i++)
            {
                var pointCoords = Console.ReadLine().Split().Select(int.Parse).ToList();

                var point = new Point(pointCoords[0], pointCoords[1]);
                var contains = rectangle.Contains(point);

                Console.WriteLine(contains);
            }
        }
    }
}
