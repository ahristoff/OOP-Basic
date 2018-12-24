using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Rectangle_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            var rectangles = new List<Rectangle>();

            for (int i = 0; i < int.Parse(input[0]); i++)
            {
                var com = Console.ReadLine().Split().ToList();
                var id = com[0];
                var width = int.Parse(com[1]);
                var hight = int.Parse(com[2]);
                var topLeftX = int.Parse(com[3]);
                var topLeftY = int.Parse(com[4]);

                var rectangle = new Rectangle(id, width, hight, topLeftX, topLeftY);

                rectangles.Add(rectangle);
            }

            for (int i = 0; i < int.Parse(input[1]); i++)
            {
                var com = Console.ReadLine().Split().ToList();
                var id1 = com[0];
                var id2 = com[1];

                var firstRectangle = rectangles.FirstOrDefault(r => r.id == id1);
                var secondRectangle = rectangles.FirstOrDefault(r => r.id == id2);

                if (firstRectangle == null || secondRectangle == null)
                {
                    Console.WriteLine("false");
                }

                else
                {
                    Console.WriteLine(firstRectangle.IntersectsRectangle(secondRectangle) ? "true" : "false");
                }
            }           
        }
    }
}
