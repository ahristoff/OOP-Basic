using System;

namespace _3._Student_System
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentSystem studentSystem = new StudentSystem();
            while (true)
            {
                studentSystem.ParseCommand();
            }
        }
    }
}
