using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var accounts = new Dictionary<int, BankAccount>();

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            var cmdArgs = input.Split();
            var command = cmdArgs[0];

            switch (command)
            {
                case "Create": Create(cmdArgs, accounts);break;
                case "Deposit": Deposit(cmdArgs, accounts); break;
                case "Withdraw": Withdraw(cmdArgs, accounts); break;
                case "Print": Print(cmdArgs, accounts); break;
            }
        }
    }

    private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {       
        var id = int.Parse(cmdArgs[1]);
        var name = cmdArgs[2];
        var age = int.Parse(cmdArgs[3]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }

        else
        {
            var acc = new BankAccount();
            acc.Id = id;
            acc.Person.Name = name;
            acc.Person.Age = age;

            accounts[id] = acc;

            Console.WriteLine($"{acc.Person.Name} {acc.Person.Age} age old has create a bankaccount with id = {acc.Id}");
        }
    }

    private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        var amount = decimal.Parse(cmdArgs[2]);

        if (accounts.ContainsKey(id))
        {
            accounts[id].Deposit(amount);

            Console.WriteLine($"{accounts[id].Person.Name} {accounts[id].Person.Age} age old has deposit in bankaccount with id = {accounts[id].Id} {amount}lw");
            Console.WriteLine(accounts[id].ToString());
        }

        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        var amount = decimal.Parse(cmdArgs[2]);

        if (accounts.ContainsKey(id))
        {
            if (accounts[id].Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }

            else
            {
                accounts[id].Withdraw(amount);              

                Console.WriteLine($"{accounts[id].Person.Name} {accounts[id].Person.Age} age old has withdraw from bankaccount with id = {accounts[id].Id} {amount}lw");
                Console.WriteLine(accounts[id].ToString());
            }           
        }

        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine(accounts[id].ToString());
        }

        else
        {
            Console.WriteLine("Account does not exist");
        }
    }  
}

