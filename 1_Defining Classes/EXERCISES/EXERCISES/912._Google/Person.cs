using System;
using System.Collections.Generic;
using System.Text;


class Person
{
    public Person(string name)
    {
        Name = name;        
        Parents = new List<Parents>();
        Children = new List<Children>();
        Pokemons = new List<Pokemon>();
    }


    public List<Pokemon> Pokemons { get; set; }

    public List<Children> Children { get; set; }

    public List<Parents> Parents { get; set; }

    public Car Car { get; set; }

    public string Name { get; set; }

    public Company Company { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{Name}");

        sb.AppendLine("Company:"); 
        if (Company != null)
        {
            sb.AppendLine($"{Company.Name} {Company.Department} {Company.Salary}");
        }

        sb.AppendLine("Car:");
        if (Car != null)
        {
            sb.AppendLine($"{Car.Model} {Car.Speed}");
        }

        sb.AppendLine("Pokemon:");       
        if (Pokemons.Count > 0)
        {          
            Pokemons.ForEach(c => sb.AppendLine($"{c.Name} {c.Type}"));
        }

        sb.AppendLine("Parents:");
        if (Parents.Count > 0)
        {
            Parents.ForEach(c => sb.AppendLine($"{c.Name} {c.Birthday}"));
        }

        sb.AppendLine("Children:");
        if (Children.Count > 0)
        {
            Children.ForEach(c => sb.AppendLine($"{c.Name} {c.Birthday}"));
        }

        return sb.ToString();
    }
}

