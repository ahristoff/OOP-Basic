
public class Pet:IBeing
{

    public Pet(string name, string birthdate)
    {
        Name = name;
        Birthdate = birthdate;
    }

    public string Birthdate { get; set; }
    
    public string Name { get; set; }  
}

