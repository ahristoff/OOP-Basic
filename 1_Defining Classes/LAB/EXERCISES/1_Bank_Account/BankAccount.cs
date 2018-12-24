using System;
using System.Collections.Generic;
using System.Text;


public class BankAccount
{
    private int id;
    private decimal balance;
    private Person person;

    public BankAccount()
    {
        Person = new Person();
    }

    public Person Person
    {
        get { return person; }
        set { person = value; }
    }

    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public decimal Balance
    {
        get { return this.balance; }
        set
        {
            if (value < 0)
            {
                throw new Exception("Balance can not be negativ");
            }
            this.balance = value;
        }
    }

    public void Deposit(decimal amount) 
    {
       this.Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        this.Balance -= amount;
    }

    public override string ToString()
    {
        return $"Account ID {this.id}, belongs {this.person.Name}, Age {this.person.Age} has balance {this.balance:f2}";
    }
}

