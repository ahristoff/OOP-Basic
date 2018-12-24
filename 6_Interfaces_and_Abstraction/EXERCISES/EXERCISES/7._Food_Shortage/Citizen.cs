
public class Citizen: IBuyer
{
    public const int Food = 10;

    public Citizen(string name, int age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
    }
  
    public string Birthdate { get; set; }
 
    public string Id { get; set; }
  
    public int Age { get; set; }

    public string Name { get; set; }


    public int BuyFood()
    {       
        return Food;
    }
}

