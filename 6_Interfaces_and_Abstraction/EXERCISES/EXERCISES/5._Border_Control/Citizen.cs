
public class Citizen:IBeing, ICitizen
{

    public Citizen(string name, int age, string id)
    {
        Name = name;
        Age = age;
        Id = id;
    }

    public int Age { get; set; }
    
    public string Name { get; set; }
   
    public string Id { get; set; }
   
    public string ValidateId(string num, string id)
    {
        if (id.EndsWith(num))
        {
            return id;
        }

        else
        {
            return "c";
        }     
    }
}

