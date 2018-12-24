using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


public class Family
{
 
    public Family()
    {
        this.Persons = new List<Person>();
    }

    public List<Person> Persons { get; set; }

    public void AddMember(Person member)
    {
        this.Persons.Add(member);
    }

    public Person GetOldestMember()
    {
        return this.Persons.OrderByDescending(s => s.Age).FirstOrDefault();
    }

    public List<Person> MoreThenThirty()
    {
        return Persons
            .Where(s => s.Age > 30)
            .OrderBy(d => d.Name)
            .ToList();
    }
}
