
public class Citizen:IBeing, ICitizen
{

    public Citizen(string name, int age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
    }

    public string Birthdate { get; set; }   

    public int Age { get; set; }
  
    public string Name { get; set; }

    public string Id { get; set; }   
}

