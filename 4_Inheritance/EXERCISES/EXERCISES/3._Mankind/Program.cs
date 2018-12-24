using System;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            var inputStudent = Console.ReadLine().Split();
            var firstNameS = inputStudent[0];
            var lastNameS = inputStudent[1];
            var facultyNumber = inputStudent[2];

            var student = new Student(firstNameS, lastNameS, facultyNumber);

            var inputWorker = Console.ReadLine().Split();
            var firstNameW = inputWorker[0];
            var lastNameW = inputWorker[1];
            var weekSalary = decimal.Parse(inputWorker[2]);
            var hoursPerDay = decimal.Parse(inputWorker[3]);

            var worker = new Worker(firstNameW, lastNameW, weekSalary, hoursPerDay);

            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

