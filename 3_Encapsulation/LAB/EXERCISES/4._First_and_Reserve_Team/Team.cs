using System;
using System.Collections.Generic;
using System.Text;


public class Team
{
    private string name;
    private readonly List<Person> firstTeam;
    private List<Person> reserveTeam;

    public Team(string name)
    {
        Name = name;
        firstTeam = new List<Person>();
        reserveTeam = new List<Person>();
    }

    public IReadOnlyCollection<Person> ReserveTeam
    {
        get
        {
            return new List<Person>(reserveTeam);
        }
    }

    public IReadOnlyCollection<Person> FirstTeam => firstTeam.AsReadOnly(); //same as above
   
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void AddPlayer(Person person)
    {
        
        if (person.Age < 40)
        {
            firstTeam.Add(person);
        }
        else
        {
            reserveTeam.Add(person);
        }
    }    
}

