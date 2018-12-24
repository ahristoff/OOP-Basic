using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<BankAccount> Accounts { get; set; }

    public Person()
    {

    }

    public Person(string name, int age)
        :this()       
    {
        this.Name = name;
        this.Age = age;
        this.Accounts = new List<BankAccount>(); 
    }

    public decimal GetBalance()
    {
        return Accounts.Sum(s => s.Balance);
    }
}
