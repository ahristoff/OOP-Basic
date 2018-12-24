using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _6._Company_Roster
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employee = GetEmployees();

            var dict = new Dictionary<string, List<Employee>>();

            foreach (var x in employee)
            {
                if (!dict.ContainsKey(x.Department))
                {
                    dict[x.Department] = new List<Employee>();
                }

                dict[x.Department].Add(x);
            }

            Console.WriteLine();

            foreach (var x in dict.OrderByDescending(p => p.Value.Average(c => c.Salary)))
            {
                Console.WriteLine($"Highest Average Salary: {x.Key}");

                foreach (var y in x.Value.OrderByDescending(p => p.Salary))
                {
                    Console.WriteLine(y.ToString());
                }

                break;
            }
        }

        private static List<Employee> GetEmployees()
        {
            var list = new List<Employee>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();

                if (input.Count == 5)
                {
                    try
                    {
                        var empl = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], int.Parse(input[4]));
                        list.Add(empl);
                    }
                    catch
                    {
                        var empl = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], input[4]);
                        list.Add(empl);
                    }
                }

                else
                {
                    try
                    {
                       var empl = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], input[4], int.Parse(input[5]));
                        list.Add(empl);
                    }
                    catch (Exception)
                    {
                        var empl = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], "n/a", -1);
                        list.Add(empl);
                    }
                }                              
            }      
            
            return list;
        }
    }
}
