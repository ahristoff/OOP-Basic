
public class Citizen : IPerson
{

    public Citizen(string name, int age)
    {
        Name = name;
        Age = age;      
    }

    public int Age { get; set; }
    
    public string Name { get; set; }   
}

